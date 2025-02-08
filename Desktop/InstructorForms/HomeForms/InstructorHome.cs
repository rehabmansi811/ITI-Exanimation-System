using Desktop.Data;
using Desktop.InstructorForms;
using Desktop.InstructorForms.Students;
using Desktop.InstructorForms.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class InstructorHome : Form
    {
        Form super;
        ExamContext context = new();
        int courseID = 0;
        public InstructorHome(Form super)
        {
            InitializeComponent();
            this.super = super;
            Utilites.InitForm(this, $"My Courses : {Utilites.Person.Name}");
            searchTXT.PlaceholderText = "Search By Name";
            FillTable();
        }

        private void InstructorHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void courseDATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                var dataGrid = sender as DataGridView;
                courseID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
                idTXT.Text = $"{courseID}";
                nameTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value}";

                questionBTN.Enabled = examBTN.Enabled = studentBTN.Enabled = true;
            }
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            courseID = 0;
            idTXT.Text = "";
            nameTXT.Text = "";
            var myCourses = context.InstructorCourses
                .Include(crs => crs.Course)
                .ThenInclude(crs => crs.Students)
                .Include(crs => crs.Course)
                .ThenInclude(crs => crs.Exams)
                .Where(crs => crs.InsID == Utilites.Person.ID && crs.Course.Name.Contains(searchTXT.Text))
                .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("# of Students", typeof(int));
            dt.Columns.Add("# of Exams", typeof(int));
            foreach (var course in myCourses)
            {
                dt.Rows.Add(course.Course.ID, course.Course.Name, course.Course.Students.Count(), course.Course.Exams.Count());
            }
            courseDATA.DataSource = dt;
            courseDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            courseDATA.Columns[^1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            courseDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            courseDATA.AllowUserToAddRows = false;
            questionBTN.Enabled = examBTN.Enabled = studentBTN.Enabled = false;
        }
        private void searchTXT_TextChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void questionBTN_Click(object sender, EventArgs e)
        {
            var course = context.Courses.SingleOrDefault(crs => crs.ID == courseID);
            if (course == null)
            {
                MessageBox.Show("The course you selected may have been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refreshBTN.PerformClick();
            }
            else
            {
                QuestionsForm form = new QuestionsForm(this, course);
                form.Show();
                Hide();
            }

        }

        private void examBTN_Click(object sender, EventArgs e)
        {
            var course = context.Courses.SingleOrDefault(crs => crs.ID == courseID);
            if (course == null)
            {
                MessageBox.Show("The course you selected may have been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refreshBTN.PerformClick();
            }
            else
            {
                ExamsForm form = new ExamsForm(this, course);
                form.Show();
                Hide();
            }
        }

        private void studentBTN_Click(object sender, EventArgs e)
        {
            var course = context.Courses.SingleOrDefault(crs => crs.ID == courseID);
            if (course == null)
            {
                MessageBox.Show("The course you selected may have been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refreshBTN.PerformClick();
            }
            else
            {
                StudentsForm form = new StudentsForm(this, course);
                form.Show();
                Hide();
            }
        }

        private void idTXT_Enter(object sender, EventArgs e)
        {
            idLBL.Focus();
        }

        private void nameTXT_Enter(object sender, EventArgs e)
        {
            idLBL.Focus();
        }
    }
}
