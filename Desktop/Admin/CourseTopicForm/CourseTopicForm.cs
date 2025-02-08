using Desktop.Data;
using Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Admin.CourseTopicForm
{
    public partial class CourseTopicForm : Form
    {
        Form super;
        ExamContext context = new();
        private Color[] buttonColors = new Color[]
        {
            Color.FromArgb(194, 39, 45),   // returnBTN
            Color.FromArgb(76, 175, 80)     // showBTN
        };
        public CourseTopicForm(Form super)
        {
            InitializeComponent();
            this.super = super;
            Utilites.InitForm(this, "Course and Topics Reports");
            courseLIST.DisplayMember = "Name";
            courseLIST.ValueMember = "ID";
            courseLIST.DataSource = context.Courses.ToList();

            SetControlStyles(new Control[] { returnBTN, showBTN });
            ConfigureHoverEffects();
        }
        private void SetControlStyles(Control[] controls)
        {
            foreach (var ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
                    btn.Tag = btn.BackColor;
                }
                else if (ctrl is ComboBox combo)
                {
                    combo.FlatStyle = FlatStyle.Flat;
                }
            }
        }

        private void ConfigureHoverEffects()
        {
            var buttons = new[] { returnBTN, showBTN };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = buttonColors[i];
                buttons[i].MouseEnter += (s, e) =>
                {
                    var btn = (Button)s;
                    btn.BackColor = ControlPaint.Dark(buttonColors[Array.IndexOf(buttons, btn)], 0.1f);
                };
                buttons[i].MouseLeave += (s, e) =>
                {
                    var btn = (Button)s;
                    btn.BackColor = buttonColors[Array.IndexOf(buttons, btn)];
                };
            }
        }

        private void CourseTopicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var topics = context.Topics.Where(top => top.CrsID == (int)courseLIST.SelectedValue);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            foreach (var topic in topics)
            {
                dt.Rows.Add(topic.ID, topic.Name);
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
