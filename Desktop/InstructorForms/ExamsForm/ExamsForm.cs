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
    public partial class ExamsForm : Form
    {
        Form super;
        Course course;
        ExamContext context = new ExamContext();
        public ExamsForm(Form super, Course course)
        {
            InitializeComponent();
            this.super = super;
            this.course = course;
            Utilites.InitForm(this, $"Exams of '{course.Name}'");
            datePICK.Format = DateTimePickerFormat.Custom;
            datePICK.CustomFormat = "dd-MM-yyyy hh:mm tt";
            datePICK.Value = DateTime.Now.Date.AddDays( 1 ).AddHours(9);
            FillTable();
        }

        private void ExamsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var exams = context.Exams
                .Where(qt => qt.CrsID == course.ID)
                .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Start Time");
            dt.Columns.Add("End Time");
            foreach (var exam in exams)
            {
                dt.Rows.Add(exam.ID, exam.Name, exam.StartDate.ToString("dd-MM-yyyy"), exam.StartDate.ToString("t"), ((DateTime)exam.EndDate).ToString("hh:mm tt"));
            }
            examDATA.DataSource = dt;
            examDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            examDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            examDATA.AllowUserToAddRows = false;

        }

        private void examDATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                var dataGrid = sender as DataGridView;
                idTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[0].Value}";
                nameTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value}";
                datePICK.Value = DateTime.Parse($"{dataGrid.Rows[e.RowIndex].Cells[2].Value} {dataGrid.Rows[e.RowIndex].Cells[3].Value}");

                questionsBTN.Visible = studentsBTN.Visible =
                nameTXT.ReadOnly = updateBTN.Visible =
                deleteBTN.Visible = endViewBTN.Visible = true;
                insertBTN.Visible = false;
            }
        }

        private void endViewBTN_Click(object sender, EventArgs e)
        {
            questionsBTN.Visible = studentsBTN.Visible =
            nameTXT.ReadOnly = updateBTN.Visible =
            deleteBTN.Visible = endViewBTN.Visible = false;
            insertBTN.Visible = true;

            idTXT.Text = nameTXT.Text = "";
            datePICK.Value = DateTime.Now.Date.AddDays(1).AddHours(9);
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            if (nameTXT.Text.Trim() == "")
            {
                MessageBox.Show("Name cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (datePICK.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Date cannot be today or in the past", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var questions = context.Questions
                    .FromSqlInterpolated($"SELECT TOP 10 * FROM Question WHERE CrsID = {course.ID} AND isDeleted = 0 ORDER BY NEWID()")
                    .ToList();
                if (questions.Count != 10)
                {
                    MessageBox.Show($"This course has only {questions.Count} questions, you need at least 10 questions to generate an exam", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var courseExist = context.Courses.Find(course.ID);
                    if (courseExist == null)
                    {
                        MessageBox.Show("The course may have been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var transaction = context.Database.BeginTransaction();

                        try
                        {
                            var exam = new Exam()
                            {
                                Name = nameTXT.Text,
                                StartDate = datePICK.Value,
                                CrsID = course.ID,
                            };

                            context.Exams.Add(exam);
                            context.SaveChanges();

                            var studentIds = context.StudentCourses
                                .Where(sc => sc.CrsID == exam.CrsID)
                                .Select(sc => sc.StdID)
                                .ToList();

                            var studentExams = studentIds.Select(stdId => new Student_Exam
                            {
                                ExamID = exam.ID,
                                StdID = stdId,
                                Grade = 0
                            }).ToList();

                            context.Student_Exams.AddRange(studentExams);

                            var answerExams = new List<Answer_Exam>();

                            foreach (var stdId in studentIds)
                            {
                                foreach (var qId in questions)
                                {
                                    answerExams.Add(new Answer_Exam
                                    {
                                        ExamID = exam.ID,
                                        StdID = stdId,
                                        QID = qId.ID,
                                        Answer = null
                                    });
                                }
                            }

                            context.Answer_Exams.AddRange(answerExams);
                            context.SaveChanges();

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                        MessageBox.Show("The exam have been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        endViewBTN_Click(sender, e);
                    }
                    refreshBTN_Click(sender, e);
                }
            }
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            var exam = context.Exams.Find(Convert.ToInt32(idTXT.Text));
            if (exam != null)
            {
                if (datePICK.Value.Date <= DateTime.Now.Date)
                {
                    MessageBox.Show("Date cannot be today or in the past", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    exam.StartDate = datePICK.Value;
                    context.SaveChanges();
                    MessageBox.Show("The exam's start date been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    endViewBTN_Click(sender, e);
                    refreshBTN_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("The exam may have been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                endViewBTN_Click(sender, e);
                refreshBTN_Click(sender, e);
            }

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            var exam = context.Exams.Find(Convert.ToInt32(idTXT.Text));
            if (exam != null)
            {
                context.Exams.Remove(exam);
                context.SaveChanges();
                MessageBox.Show("The exam has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The exam may have been already deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            endViewBTN_Click(sender, e);
            refreshBTN_Click(sender, e);
        }

        private void questionsBTN_Click(object sender, EventArgs e)
        {
            var exam = context.Exams.Find(Convert.ToInt32(idTXT.Text));
            if (exam != null)
            {
                ExamQuestionsForm form = new ExamQuestionsForm(this, exam);
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("The exam may have been already deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                endViewBTN_Click(sender, e);
                refreshBTN_Click(sender, e);
            }
        }

        private void studentsBTN_Click(object sender, EventArgs e)
        {
            var exam = context.Exams.Find(Convert.ToInt32(idTXT.Text));
            if (exam != null)
            {
                ExamStudentsForm form = new ExamStudentsForm(this, exam);
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("The exam may have been already deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                endViewBTN_Click(sender, e);
                refreshBTN_Click(sender, e);
            }
        }
    }
}
