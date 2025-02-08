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

namespace Desktop.InstructorForms.Exams
{
    public partial class StudentAnswersForm : Form
    {
        Form super;
        Exam exam;
        Student student;
        ExamContext context = new();
        public StudentAnswersForm(Form super, Exam exam , Student student)
        {
            InitializeComponent();
            this.super = super;
            this.exam = exam;
            this.student = student;
            Utilites.InitForm(this, $"Answers of '{student.Person.Name}' For Exam '{exam.Name}'");
            typeBOX.SelectedIndex = 0;

            questionDATA.DataBindingComplete += (sender, e) =>
            {
                for (int i = 0; i < questionDATA.Rows.Count; i++)
                {
                    if (Convert.ToInt32(questionDATA.Rows[i].Cells["Student Choice"].Value) != 0)
                    {
                        questionDATA.Rows[i].Cells[Convert.ToInt32(questionDATA.Rows[i].Cells["Student Choice"].Value) + 3].Style.BackColor = Color.Red;
                        questionDATA.Rows[i].Cells[Convert.ToInt32(questionDATA.Rows[i].Cells["Student Choice"].Value) + 3].Style.ForeColor = Color.White;
                        questionDATA.Rows[i].Cells[Convert.ToInt32(questionDATA.Rows[i].Cells["Student Choice"].Value) + 3].Style.SelectionBackColor = Color.OrangeRed;
                    }
                    else
                    {
                        questionDATA.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                        questionDATA.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    questionDATA.Rows[i].Cells[Convert.ToInt32(questionDATA.Rows[i].Cells["Correct Choice"].Value) + 3].Style.BackColor = Color.Green;
                    questionDATA.Rows[i].Cells[Convert.ToInt32(questionDATA.Rows[i].Cells["Correct Choice"].Value) + 3].Style.ForeColor = Color.White;
                    questionDATA.Rows[i].Cells[Convert.ToInt32(questionDATA.Rows[i].Cells["Correct Choice"].Value) + 3].Style.SelectionBackColor = Color.GreenYellow;
                }
            };


            FillTable();
        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var answers = context.Answer_Exams
                .Include(qt => qt.Question)
                .ThenInclude(qt => qt.Choices)
                .Where(qt => qt.ExamID == exam.ID && qt.StdID == student.StdID)
                .ToList();
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
                    dt.Rows.Add(question.ID, question.Body, question.Type, question.Degree, choices[0].Body, choices[1].Body, choices[2].Body, choices[3].Body, question.IsDeleted, question.CorrectChoice,answer.Answer);
                else if (choices.Count() == 2)
                    dt.Rows.Add(question.ID, question.Body, question.Type, question.Degree, choices[0].Body, choices[1].Body, null, null, question.IsDeleted, question.CorrectChoice,answer.Answer);
            }
            questionDATA.DataSource = dt;
            questionDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            questionDATA.AllowUserToAddRows = false;
            questionDATA.Columns[^1].Visible = questionDATA.Columns[^2].Visible  = false;

            

        }

        private void correctChoice1_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Green;
                correctChoice2.BackColor = correctChoice3.BackColor = correctChoice4.BackColor = Color.White;
            }
        }

        private void correctChoice2_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Green;
                correctChoice1.BackColor = correctChoice3.BackColor = correctChoice4.BackColor = Color.White;
            }
        }

        private void correctChoice3_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Green;
                correctChoice2.BackColor = correctChoice1.BackColor = correctChoice4.BackColor = Color.White;
            }
        }

        private void correctChoice4_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Green;
                correctChoice2.BackColor = correctChoice3.BackColor = correctChoice1.BackColor = Color.White;
            }
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void typeBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            if (box.SelectedItem.ToString() == "T/F")
            {
                panel6.Visible = panel7.Visible =
                choice3LBL.Visible = choice4LBL.Visible =
                choice3TXT.Visible = choice4TXT.Visible =
                correctChoice3.Visible = correctChoice4.Visible = false;

                choice1TXT.ReadOnly = choice2TXT.ReadOnly =
                choice3TXT.ReadOnly = choice4TXT.ReadOnly = true;
                correctChoice3.Enabled = correctChoice4.Enabled = false;

                choice1TXT.Text = "True";
                choice2TXT.Text = "False";
                choice3TXT.Text = choice4TXT.Text = "";

                if (correctChoice3.BackColor == Color.Green || correctChoice4.BackColor == Color.Green)
                {
                    correctChoice1.PerformClick();
                }
            }
            else if (box.SelectedItem.ToString() == "MCQ")
            {
                panel6.Visible = panel7.Visible =
                choice3LBL.Visible = choice4LBL.Visible =
                choice3TXT.Visible = choice4TXT.Visible =
                correctChoice3.Visible = correctChoice4.Visible = true;

                choice1TXT.ReadOnly = choice2TXT.ReadOnly =
                choice3TXT.ReadOnly = choice4TXT.ReadOnly = false;
                correctChoice3.Enabled = correctChoice4.Enabled = true;

                choice1TXT.Text = choice2TXT.Text =
                choice3TXT.Text = choice4TXT.Text = "";
            }
        }

        private void questionDATA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                var dataGrid = sender as DataGridView;
                idTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[0].Value}";
                bodyTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value}";
                typeBOX.SelectedItem = $"{dataGrid.Rows[e.RowIndex].Cells[2].Value}";
                degreeNUM.Value = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[3].Value);
                choice1TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[4].Value}";
                choice2TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[5].Value}";
                choice3TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[6].Value}";
                choice4TXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[7].Value}";

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

                bodyTXT.ReadOnly = degreeNUM.ReadOnly =
                choice1TXT.ReadOnly = choice2TXT.ReadOnly =
                choice3TXT.ReadOnly = choice4TXT.ReadOnly = true;
                typeBOX.Enabled =
                correctChoice1.Enabled = correctChoice2.Enabled =
                correctChoice3.Enabled = correctChoice4.Enabled = false;

                endViewBTN.Visible = true;
            }


        }

        private void endViewBTN_Click(object sender, EventArgs e)
        {
            bodyTXT.ReadOnly = degreeNUM.ReadOnly =
            choice1TXT.ReadOnly = choice2TXT.ReadOnly =
            choice3TXT.ReadOnly = choice4TXT.ReadOnly = false;
            typeBOX.Enabled =
            correctChoice1.Enabled = correctChoice2.Enabled =
            correctChoice3.Enabled = correctChoice4.Enabled = true;


            endViewBTN.Visible = false;

            bodyTXT.Text = idTXT.Text =
            choice3TXT.Text = choice4TXT.Text = "";

            degreeNUM.Value = 1;
            typeBOX.SelectedItem = "T/F";
            choice1TXT.Text = "True";
            choice2TXT.Text = "False";
            correctChoice1.PerformClick();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
