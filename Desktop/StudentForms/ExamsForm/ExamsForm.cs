using Desktop.Data;
using Desktop.Models;
using Desktop.StudentForms.AnswersForm;
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

namespace Desktop.StudentForms.ExamsForm
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
            datePICK.Value = DateTime.Now.Date.AddDays(1).AddHours(9);
            FillTable();
        }

        private void ExamsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var exams = context.Student_Exams
                .Include(exm => exm.Exam)
                .Where(qt => qt.StdID == Utilites.Person.ID && qt.Exam.CrsID == course.ID)
                .OrderByDescending(qt => qt.Exam.StartDate)
                .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Start Time");
            dt.Columns.Add("End Time");
            dt.Columns.Add("Grade");
            foreach (var exam in exams)
            {
                float maxPossible = context.Answer_Exams
                                .Where(ae => ae.ExamID == exam.Exam.ID)
                                .Select(ae => ae.Question)
                                .Distinct()
                                .ToList()
                                .Sum(qt => qt.Degree);
                dt.Rows.Add(
                    exam.Exam.ID,
                    exam.Exam.Name,
                    exam.Exam.StartDate.ToString("dd-MM-yyyy"),
                    exam.Exam.StartDate.ToString("t"),
                    ((DateTime)exam.Exam.EndDate).ToString("hh:mm tt"),
                    exam.Exam.EndDate < DateTime.Now ? $"{(exam.Grade / maxPossible):P}" : "N/A");
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

                enterBTN.Enabled = endViewBTN.Enabled = true;
            }
        }

        private void endViewBTN_Click(object sender, EventArgs e)
        {
            enterBTN.Enabled = endViewBTN.Enabled = false;

            idTXT.Text = nameTXT.Text = "";
            datePICK.Value = DateTime.Now.Date.AddDays(1).AddHours(9);
        }



        private void refreshBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameTXT_MouseDown(object sender, MouseEventArgs e)
        {
            nameLBL.Focus();
        }

        private void enterBTN_Click(object sender, EventArgs e)
        {
            var examEntry = context.Student_Exams
                .Include(exm => exm.Exam)
                .ThenInclude(exm => exm.Course)
                .SingleOrDefault(exm => exm.ExamID == Convert.ToInt32(idTXT.Text) && exm.StdID == Utilites.Person.ID);
            if (examEntry != null)
            {
                var exam = examEntry.Exam;
                if(exam != null)
                {
                    if (exam.StartDate > DateTime.Now)
                    {
                        MessageBox.Show($"Exam Starts at {exam.StartDate:F}\nTime Now: {DateTime.Now:F}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (exam.EndDate < DateTime.Now)
                    {
                        MessageBox.Show($"Exam Ended at {exam.StartDate:F}\nTime Now: {DateTime.Now:F}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        AnswerForm form = new AnswerForm(this, exam);
                        form.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("The Exam may have been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    refreshBTN_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("You may not be registered to participate in this Exam, Exit this form and re-enter again to double check", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refreshBTN_Click(sender, e);
            }
        }
    }
}
