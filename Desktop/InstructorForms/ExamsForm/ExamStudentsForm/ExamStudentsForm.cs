using Desktop.Data;
using Desktop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
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
    public partial class ExamStudentsForm : Form
    {
        Form super;
        Exam exam;
        ExamContext context = new();
        public ExamStudentsForm(Form super, Exam exam)
        {
            InitializeComponent();
            this.super = super;
            this.exam = exam;
            Utilites.InitForm(this, $"Questions of '{exam.Name}'");
            FillTable();
        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var students = context.Students
                .Include(std => std.Person)
                .Where(qt => qt.Answer_Exams.Any(ans => ans.ExamID == exam.ID))
                .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Grade");
            dt.Columns.Add("NID");

            float maxPossible = context.Answer_Exams
                                .Where(ae => ae.ExamID == exam.ID)
                                .Select(ae => ae.Question)
                                .Distinct()
                                .ToList()
                                .Sum(qt => qt.Degree);

            foreach (var student in students)
            {
                float totalObtained = context.Student_Exams
                    .Where(se => se.StdID == student.StdID && se.Exam.ID == exam.ID)
                    .Sum(se => se.Grade) ?? 0;  // Handle null grades as 0

                // Get maximum possible grade for this course

                var grade = exam.EndDate >= DateTime.Now ? "N/A" : $"{(totalObtained / maxPossible):P}";
                dt.Rows.Add(student.StdID, student.Person.Name, student.Person.Email, grade, student.Person.NID);
            }
            studentDATA.DataSource = dt;
            studentDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentDATA.AllowUserToAddRows = false;

        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void questionDATA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                var dataGrid = sender as DataGridView;
                idTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[0].Value}";
                answersBTN.Enabled = true;
            }


        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void answersBTN_Click(object sender, EventArgs e)
        {
            var student = context.Students.Find(Convert.ToInt32(idTXT.Text));
            var examCheck = context.Exams.Find(exam.ID);

            if (student != null && examCheck != null)
            {
                StudentAnswersForm form = new StudentAnswersForm(this,examCheck,student);
                form.Show();
                Hide();
            }
            else if(student == null)
            {
                MessageBox.Show("The student's Exam entry may have been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refreshBTN_Click(sender, e);
            }
            else if(examCheck == null)
            {
                MessageBox.Show("The Exam may have been deleted, returning to previous form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
