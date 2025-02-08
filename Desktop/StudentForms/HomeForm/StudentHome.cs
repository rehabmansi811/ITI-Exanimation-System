using Desktop.Data;
using Desktop.InstructorForms;
using Desktop.InstructorForms.Students;
using Desktop.StudentForms.ExamsForm;
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
    public partial class StudentHome : Form
    {
        Form super;
        ExamContext context = new();
        int courseID = 0;
        public StudentHome(Form super)
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

                examBTN.Enabled = true;
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
            var myCourses = context.StudentCourses
                .Include(crs => crs.Course)
                .Include(crs => crs.Student)
                .ThenInclude(std => std.Exams)
                .ThenInclude(std => std.Exam)
                .Where(crs => crs.StdID == Utilites.Person.ID && crs.Course.Name.Contains(searchTXT.Text))
                .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Exams Taken", typeof(int));
            dt.Columns.Add("Upcoming Exams", typeof(int));
            dt.Columns.Add("Upcoming Exam Date", typeof(DateTime));
            dt.Columns.Add("sortHelper", typeof(int));
            foreach (var course in myCourses)
            {
                var earliestExam = course.Student.Exams
                    .Where(exm => exm.Exam.EndDate > DateTime.Now && exm.Exam.CrsID == course.Course.ID)
                    .OrderBy(exm => exm.Exam.StartDate)
                    .FirstOrDefault();
                dt.Rows.Add(
                    course.Course.ID,
                    course.Course.Name,
                    course.Student.Exams.Where(exm => exm.Exam.EndDate < DateTime.Now && exm.Exam.CrsID == course.Course.ID).Count(),
                    course.Student.Exams.Where(exm => exm.Exam.EndDate >= DateTime.Now && exm.Exam.CrsID == course.Course.ID).Count(),
                    earliestExam == null ? null : earliestExam.Exam.StartDate.ToString("dd-MMM-yyyy hh:mm tt"),
                    earliestExam == null ? 1 : 0
                    );
            }
            DataView date = new(dt);
            date.Sort = "sortHelper ASC, [Upcoming Exam Date] ASC";
            courseDATA.DataSource = date;
            courseDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            courseDATA.Columns[^1].Visible = false;
            courseDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            courseDATA.AllowUserToAddRows = false;
            examBTN.Enabled = false;
        }
        private void searchTXT_TextChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
