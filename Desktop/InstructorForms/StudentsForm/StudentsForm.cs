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

namespace Desktop.InstructorForms.Students
{
    public partial class StudentsForm : Form
    {
        ExamContext context = new();
        Form super;
        Course course;
        public StudentsForm(Form super, Course course)
        {
            InitializeComponent();
            this.super = super;
            this.course = course;
            Utilites.InitForm(this, $"Students of '{course.Name}'");
            FillTable();
            searchTXT.PlaceholderText = "Search by Name";
        }

        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var students = context.StudentCourses
                .Include(crs => crs.Course)
                .Include(crs => crs.Student)
                .ThenInclude(ppl => ppl.Person)
                .Where(crs => crs.Course.ID == course.ID && crs.Student.Person.Name.Contains(searchTXT.Text))
                .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Grade");
            dt.Columns.Add("Exams Taken", typeof(int));
            foreach (var student in students)
            {
                float totalObtained = context.Student_Exams
                    .Where(se => se.StdID == student.StdID && se.Exam.Course.ID == course.ID && se.Exam.EndDate < DateTime.Now)
                    .Sum(se => se.Grade) ?? 0;  // Handle null grades as 0

                var examTaken = context.Student_Exams.Where(se => se.StdID == student.StdID && se.Exam.Course.ID == course.ID && se.Exam.EndDate < DateTime.Now).Count();

                // Get maximum possible grade for this course
                float maxPossible = context.Answer_Exams
                                .Where(ae => ae.Exam.Course.ID == course.ID && ae.Exam.EndDate < DateTime.Now && ae.StdID == student.StdID)
                                .Select(ae => ae.Question)
                                .ToList()
                                .Sum(qt => qt.Degree);
                var percentage = maxPossible > 0
                                ? $"{((totalObtained / maxPossible)):P}"
                                : "No Exams Yet";
                dt.Rows.Add(student.StdID, student.Student.Person.Name, percentage, examTaken);
            }
            studentDATA.DataSource = dt;
            studentDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentDATA.AllowUserToAddRows = false;

        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchTXT_TextChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
