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

namespace Desktop.Admin.StudentDepartmentForm
{
    public partial class StudentDepartmentForm : Form
    {
        Form super;
        ExamContext context = new();
        public StudentDepartmentForm(Form super)
        {
            InitializeComponent();
            this.super = super;
            Utilites.InitForm(this, "Course and Topics Reports");
            deptLIST.DisplayMember = "Name";
            deptLIST.ValueMember = "ID";
            deptLIST.DataSource = context.Departments.ToList();
        }

        private void CourseTopicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var students = context.Students
                        .Include(std => std.Person)
                        .Where(std => std.Person.DeptID == (int)deptLIST.SelectedValue)
                        .ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Gender");
            dt.Columns.Add("DOB", typeof(DateOnly));
            dt.Columns.Add("Phone");
            dt.Columns.Add("Salary", typeof(decimal));
            dt.Columns.Add("College");
            foreach (var student in students)
            {
                dt.Rows.Add(
                    student.StdID,
                    student.Person.Name,
                    student.Person.Email,
                    student.Person.Address,
                    student.Person.Gender,
                    student.Person.DOB,
                    student.Person.Phone,
                    student.Person.Salary,
                    student.College);
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
                nameTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value}";
                emailTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[2].Value}";
                addressTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[3].Value}";
                dobTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[5].Value}";
                phoneTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[6].Value}";
                salaryTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[7].Value}";
                collegeTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[8].Value}";
            }
        }

        private void idTXT_MouseDown(object sender, MouseEventArgs e)
        {
            nameLBL.Focus();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idTXT_Mouse(object sender, MouseEventArgs e)
        {
            nameLBL.Focus();
        }
    }
}
