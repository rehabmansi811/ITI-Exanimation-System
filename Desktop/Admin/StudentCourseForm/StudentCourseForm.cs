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

namespace Desktop.Admin.StudentCourseForm
{
    public partial class StudentCourseForm : Form
    {
        Form super;
        ExamContext context = new();
        public StudentCourseForm(Form super)
        {
            InitializeComponent();
            this.super = super;
            Utilites.InitForm(this, "Course and Topics Reports");
            studentLIST.DisplayMember = "Name";
            studentLIST.ValueMember = "ID";
            studentLIST.DataSource = context.Students.Select(ins => ins.Person).ToList();
        }

        private void CourseTopicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var courses = context.StudentCourses
                        .Include(std => std.Course)
                        .ThenInclude(std => std.Students)
                        .Where(std => std.StdID == (int)studentLIST.SelectedValue)
                        .Select(ins => new {ins.Course.ID,ins.Course.Name})
                        .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Grade");
            foreach (var course in courses)
            {
                float totalObtained = context.Student_Exams
                    .Where(se => se.StdID == (int)studentLIST.SelectedValue && se.Exam.Course.ID == course.ID && se.Exam.EndDate < DateTime.Now)
                    .Sum(se => se.Grade) ?? 0;  // Handle null grades as 0

                var examTaken = context.Student_Exams.Where(se => se.StdID == (int)studentLIST.SelectedValue && se.Exam.Course.ID == course.ID && se.Exam.EndDate < DateTime.Now).Count();

                // Get maximum possible grade for this course
                float maxPossible = context.Answer_Exams
                                .Where(ae => ae.Exam.Course.ID == course.ID && ae.Exam.EndDate < DateTime.Now && ae.StdID == (int)studentLIST.SelectedValue)
                                .Select(ae => ae.Question)
                                .ToList()
                                .Sum(qt => qt.Degree);
                var percentage = maxPossible > 0
                                ? $"{((totalObtained / maxPossible)):P}"
                                : "No Exams Yet";
                dt.Rows.Add(course.ID, course.Name, percentage);
            }
            topicDATA.DataSource = dt;
            topicDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            topicDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            topicDATA.AllowUserToAddRows = false;
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void topicDATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                var dataGrid = sender as DataGridView;
                idTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[0].Value}";
                nameTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value}";
            }
        }

        private void idTXT_MouseDown(object sender, MouseEventArgs e)
        {
            idLBL.Focus();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
