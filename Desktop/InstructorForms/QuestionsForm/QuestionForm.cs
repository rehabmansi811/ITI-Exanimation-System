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

namespace Desktop.InstructorForms
{
    public partial class QuestionsForm : Form
    {
        Form super;
        Course course;
        ExamContext context = new();
        public QuestionsForm(Form super, Course course)
        {
            InitializeComponent();
            this.super = super;
            this.course = course;
            Utilites.InitForm(this, $"Questions of '{course.Name}'");
            typeBOX.SelectedIndex = 0;
            FillTable();
        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var questions = context.Questions
                .Include(qt => qt.Choices)
                .Where(qt => qt.CrsID == course.ID)
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
            foreach (var question in questions)
            {
                var choices = question.Choices.OrderBy(c => c.ChoiceNum).ToList();
                if (choices.Count() == 4)
                    dt.Rows.Add(question.ID, question.Body, question.Type, question.Degree, choices[0].Body, choices[1].Body, choices[2].Body, choices[3].Body, question.IsDeleted, question.CorrectChoice);
                else if (choices.Count() == 2)
                    dt.Rows.Add(question.ID, question.Body, question.Type, question.Degree, choices[0].Body, choices[1].Body, null, null, question.IsDeleted, question.CorrectChoice);
            }
            questionDATA.DataSource = dt;
            questionDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            questionDATA.AllowUserToAddRows = false;
            questionDATA.Columns[^1].Visible = false;

            questionDATA.DataBindingComplete += (sender, e) =>
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    questionDATA.Rows[i].Cells[questions[i].CorrectChoice + 3].Style.BackColor = Color.Green;
                    questionDATA.Rows[i].Cells[questions[i].CorrectChoice + 3].Style.ForeColor = Color.White;
                    questionDATA.Rows[i].Cells[questions[i].CorrectChoice + 3].Style.SelectionBackColor = Color.GreenYellow;
                }
            };

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

                if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "1") correctChoice1.PerformClick();
                else if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "2") correctChoice2.PerformClick();
                else if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "3") correctChoice3.PerformClick();
                else if ((string)dataGrid.Rows[e.RowIndex].Cells[9].Value == "4") correctChoice4.PerformClick();

                bodyTXT.ReadOnly = degreeNUM.ReadOnly =
                choice1TXT.ReadOnly = choice2TXT.ReadOnly =
                choice3TXT.ReadOnly = choice4TXT.ReadOnly = true;
                typeBOX.Enabled =
                correctChoice1.Enabled = correctChoice2.Enabled =
                correctChoice3.Enabled = correctChoice4.Enabled = false;

                insertBTN.Visible = false;
                deleteBTN.Visible = endViewBTN.Visible = true;
                if ((string)dataGrid.Rows[e.RowIndex].Cells[8].Value == "True") deleteBTN.Text = "Undelete";
                else if ((string)dataGrid.Rows[e.RowIndex].Cells[8].Value == "False") deleteBTN.Text = "Delete";
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


            insertBTN.Visible = true;
            endViewBTN.Visible = deleteBTN.Visible = false;

            bodyTXT.Text = idTXT.Text =
            choice3TXT.Text = choice4TXT.Text = "";

            degreeNUM.Value = 1;
            typeBOX.SelectedItem = "T/F";
            choice1TXT.Text = "True";
            choice2TXT.Text = "False";
            correctChoice1.PerformClick();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            var question = context.Questions.Find(Convert.ToInt32(idTXT.Text));
            if (question != null)
            {
                question.IsDeleted = !question.IsDeleted;
                context.SaveChanges();
                MessageBox.Show($"Question {(question.IsDeleted ? "deletion" : "Undeletion")} is successfull", "Succuss", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The question you selected may have been already deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            refreshBTN.PerformClick();
            endViewBTN.PerformClick();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            if (bodyTXT.Text.Trim() == "")
            {
                MessageBox.Show("Body cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (typeBOX.SelectedItem == "T/F")
                {
                    int correctAnswer = 0;
                    if (correctChoice1.BackColor == Color.Green) correctAnswer = 1;
                    else if (correctChoice2.BackColor == Color.Green) correctAnswer = 2;

                    var newQuestion = new Question()
                    {
                        Body = bodyTXT.Text,
                        Degree = (int)degreeNUM.Value,
                        Type = typeBOX.SelectedItem.ToString(),
                        CrsID = course.ID,
                        IsDeleted = false,
                        CorrectChoice = correctAnswer,
                        Choices = new List<Choice>
                        {
                            new Choice{ ChoiceNum = 1 , Body = "True"},
                            new Choice{ ChoiceNum = 2 , Body = "False"}
                        }
                    };

                    context.Questions.Add(newQuestion);
                    context.SaveChanges();
                    MessageBox.Show($"Question added successfull", "Succuss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    endViewBTN_Click(new object(), new EventArgs());
                    refreshBTN.PerformClick();
                    refreshBTN.PerformClick();
                }
                else if (typeBOX.SelectedItem == "MCQ")
                {
                    if (
                        choice1TXT.Text.Trim() == "" ||
                        choice2TXT.Text.Trim() == "" ||
                        choice3TXT.Text.Trim() == "" ||
                        choice4TXT.Text.Trim() == "")
                    {
                        MessageBox.Show("Choices body cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (new[] { choice1TXT.Text.Trim(), choice2TXT.Text.Trim(), choice3TXT.Text.Trim(), choice4TXT.Text.Trim() }
                            .Distinct().Count() != 4)
                    {
                        MessageBox.Show("There can't be any duplicate choices", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int correctAnswer = 0;
                        if (correctChoice1.BackColor == Color.Green) correctAnswer = 1;
                        else if (correctChoice2.BackColor == Color.Green) correctAnswer = 2;
                        else if (correctChoice3.BackColor == Color.Green) correctAnswer = 3;
                        else if (correctChoice4.BackColor == Color.Green) correctAnswer = 4;

                        var newQuestion = new Question()
                        {
                            Body = bodyTXT.Text,
                            Degree = (int)degreeNUM.Value,
                            Type = typeBOX.SelectedItem.ToString(),
                            CrsID = course.ID,
                            IsDeleted = false,
                            CorrectChoice = correctAnswer,
                            Choices = new List<Choice>
                            {
                                new Choice{ ChoiceNum = 1 , Body = choice1TXT.Text},
                                new Choice{ ChoiceNum = 2 , Body = choice2TXT.Text},
                                new Choice{ ChoiceNum = 3 , Body = choice3TXT.Text},
                                new Choice{ ChoiceNum = 4 , Body = choice4TXT.Text}
                            }
                        };

                        context.Questions.Add(newQuestion);
                        context.SaveChanges();
                        MessageBox.Show($"Question added successfull", "Succuss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        endViewBTN_Click(new object(), new EventArgs());
                        refreshBTN.PerformClick();
                        refreshBTN.PerformClick();
                    }
                }
            }
        }

    }
}
