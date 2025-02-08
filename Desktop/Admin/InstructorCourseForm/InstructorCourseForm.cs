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

namespace Desktop.Admin.InstructorCourseForm
{
    public partial class InstructorCourseForm : Form
    {
        Form super;
        ExamContext context = new();
        public InstructorCourseForm(Form super)
        {
            InitializeComponent();
            this.super = super;
            Utilites.InitForm(this, "Course and Topics Reports");
            insLIST.DisplayMember = "Name";
            insLIST.ValueMember = "ID";
            insLIST.DataSource = context.Instructors.Select(ins => ins.Person).ToList();
        }

        private void CourseTopicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var courses = context.InstructorCourses
                        .Include(ins => ins.Course)
                        .ThenInclude(ins => ins.Students)
                        .Where(top => top.InsID == (int)insLIST.SelectedValue)
                        .Select(ins => new {ins.Course.ID,ins.Course.Name,ins.Course.Students.Count});
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("# of Students", typeof(int));
            foreach (var course in courses)
            {
                dt.Rows.Add(course.ID, course.Name, course.Count);
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
