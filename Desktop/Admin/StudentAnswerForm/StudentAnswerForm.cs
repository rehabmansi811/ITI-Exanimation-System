using Desktop.Data;
using Desktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Admin.ExamQuestionsForm
{
    public partial class StudentAnswerForm : Form
    {
        Form super;
        ExamContext context = new();
        public StudentAnswerForm(Form super)
        {
            InitializeComponent();
            this.super = super;
            Utilites.InitForm(this, "Student's Exam Reports");
            courseLIST.DisplayMember = examLIST.DisplayMember = studentLIST.DisplayMember = "Name";
            courseLIST.ValueMember = examLIST.ValueMember = studentLIST.ValueMember = "ID";

            courseLIST.DataSource = context.Courses.ToList();

            questionsDATA.DataBindingComplete += (sender, e) =>
            {
                for (int i = 0; i < questionsDATA.Rows.Count; i++)
                {
                    if (Convert.ToInt32(questionsDATA.Rows[i].Cells["Student Choice"].Value) != 0)
                    {
                        questionsDATA.Rows[i].Cells[Convert.ToInt32(questionsDATA.Rows[i].Cells["Student Choice"].Value) + 3].Style.BackColor = Color.Red;
                        questionsDATA.Rows[i].Cells[Convert.ToInt32(questionsDATA.Rows[i].Cells["Student Choice"].Value) + 3].Style.ForeColor = Color.White;
                        questionsDATA.Rows[i].Cells[Convert.ToInt32(questionsDATA.Rows[i].Cells["Student Choice"].Value) + 3].Style.SelectionBackColor = Color.OrangeRed;
                    }
                    else
                    {
                        questionsDATA.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                        questionsDATA.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    questionsDATA.Rows[i].Cells[Convert.ToInt32(questionsDATA.Rows[i].Cells["Correct Choice"].Value) + 3].Style.BackColor = Color.Green;
                    questionsDATA.Rows[i].Cells[Convert.ToInt32(questionsDATA.Rows[i].Cells["Correct Choice"].Value) + 3].Style.ForeColor = Color.White;
                    questionsDATA.Rows[i].Cells[Convert.ToInt32(questionsDATA.Rows[i].Cells["Correct Choice"].Value) + 3].Style.SelectionBackColor = Color.GreenYellow;
                }
            };
        }

        private void ExamQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FillTable()
        {
            var answers = context.Answer_Exams
                .Include(qt => qt.Question)
                .ThenInclude(qt => qt.Choices)
                .Where(qt => qt.ExamID == (int)examLIST.SelectedValue && qt.StdID == (int)studentLIST.SelectedValue)
                .ToList();
            if(answers.Count == 0) { MessageBox.Show($"{((Person)studentLIST.SelectedItem).Name} did not take this exam"); return; }
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Body");
            dt.Columns.Add("Type");
            dt.Columns.Add("Degree", typeof(int));
            dt.Columns.Add("Choice 1");
            dt.Columns.Add("Choice 2");
            dt.Columns.Add("Choice 3");
            dt.Columns.Add("Choice 4");
            dt.Columns.Add("Deleted ?");
            dt.Columns.Add("Correct Choice");
            dt.Columns.Add("Student Choice");
            foreach (var answer in answers)
            {
                var question = answer.Question;
                var choices = question.Choices.OrderBy(c => c.ChoiceNum).ToList();
                if (choices.Count() == 4)
                    dt.Rows.Add(question.ID, question.Body, question.Type, question.Degree, choices[0].Body, choices[1].Body, choices[2].Body, choices[3].Body, question.IsDeleted, question.CorrectChoice, answer.Answer);
                else if (choices.Count() == 2)
                    dt.Rows.Add(question.ID, question.Body, question.Type, question.Degree, choices[0].Body, choices[1].Body, null, null, question.IsDeleted, question.CorrectChoice, answer.Answer);
            }
            questionsDATA.DataSource = dt;
            questionsDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionsDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            questionsDATA.AllowUserToAddRows = false;
            questionsDATA.Columns[^1].Visible = false;
            questionsDATA.Columns[^2].Visible = false;



        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void courseLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            var exams = context.Exams.Where(exm => exm.CrsID == (int)courseLIST.SelectedValue).ToList();
            var students = context.StudentCourses
                .Where(std => std.CrsID == (int)courseLIST.SelectedValue)
                .Select(std => std.Student.Person)
                .ToList();

            examLIST.DataSource = exams;
            studentLIST.DataSource = students;
            if (exams.Count > 0)
            {
                showBTN.Enabled = true;
            }
            else
            {
                showBTN.Enabled = false;
            }

            bodyTXT.Text = choice1TXT.Text = choice2TXT.Text = choice3TXT.Text = choice4TXT.Text = "";
            degreeNUM.Value = 1;
            correctChoice1.BackColor = Color.Green;
            correctChoice2.BackColor = correctChoice3.BackColor = correctChoice4.BackColor = Color.White;

        }

        private void questionsDATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                var dataGrid = sender as DataGridView;
                bodyTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value}";
                degreeNUM.Value = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[3].Value);
                choice1TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[4].Value}";
                choice2TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[5].Value}";
                choice3TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[6].Value}";
                choice4TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[7].Value}";

                var type = $"{dataGrid.Rows[e.RowIndex].Cells[2].Value}";
                if(type == "MCQ")
                {
                    choice3LBL.Visible = choice4LBL.Visible =
                    choice3TXT.Visible = choice4TXT.Visible =
                    correctChoice3.Visible = correctChoice4.Visible = true;
                }
                else if(type == "T/F")
                {
                    choice3LBL.Visible = choice4LBL.Visible =
                    choice3TXT.Visible = choice4TXT.Visible =
                    correctChoice3.Visible = correctChoice4.Visible = false;
                }


                correctChoice1.Enabled = correctChoice2.Enabled =
                correctChoice3.Enabled = correctChoice4.Enabled = true;

                if ((string)dataGrid.Rows[e.RowIndex].Cells["Student Choice"].Value == "1")
                {
                    correctChoice1.BackColor = Color.Red;
                    correctChoice2.BackColor = correctChoice3.BackColor = correctChoice4.BackColor = Color.White;
                }
                else if ((string)dataGrid.Rows[e.RowIndex].Cells["Student Choice"].Value == "2")
                {
                    correctChoice2.BackColor = Color.Red;
                    correctChoice1.BackColor = correctChoice3.BackColor = correctChoice4.BackColor = Color.White;
                }
                else if ((string)dataGrid.Rows[e.RowIndex].Cells["Student Choice"].Value == "3")
                {
                    correctChoice3.BackColor = Color.Red;
                    correctChoice2.BackColor = correctChoice1.BackColor = correctChoice4.BackColor = Color.White;
                }
                else if ((string)dataGrid.Rows[e.RowIndex].Cells["Student Choice"].Value == "4")
                {
                    correctChoice4.BackColor = Color.Red;
                    correctChoice2.BackColor = correctChoice3.BackColor = correctChoice1.BackColor = Color.White;
                }


                if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "1")
                {
                    correctChoice1.BackColor = Color.Green;
                }
                else if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "2")
                {
                    correctChoice2.BackColor = Color.Green;
                }
                else if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "3")
                {
                    correctChoice3.BackColor = Color.Green;
                }
                else if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "4")
                {
                    correctChoice4.BackColor = Color.Green;
                }


                correctChoice1.Enabled = correctChoice2.Enabled =
                correctChoice3.Enabled = correctChoice4.Enabled = false;
            }
        }
    }
}
