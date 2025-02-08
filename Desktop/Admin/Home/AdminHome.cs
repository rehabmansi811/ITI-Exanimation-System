using Desktop.Admin.CourseTopicForm;
using Desktop.Admin.ExamQuestionsForm;
using Desktop.Admin.InstructorCourseForm;
using Desktop.Admin.StudentCourseForm;
using Desktop.Admin.StudentDepartmentForm;
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
    public partial class AdminHome : Form
    {
        Form Super;
        ImageList imageList = new ImageList();
        public AdminHome(Form Super)
        {
            InitializeComponent();
            this.Super = Super;
            Utilites.InitForm(this, $"Welcome Admin {Utilites.Person.Name}");
            titleLBL.Text = $"Welcome {Utilites.Person.Name}";

            var buttons = new[] { crsTopBTN, examQuReport, stdAnsBTN,
                        insCrsBTN, stdGradeBTN, stdDeptBTN, logOutBTN };

            foreach (var btn in buttons)
            {
                btn.Tag = btn.BackColor;

                btn.MouseEnter += (s, e) =>
                {
                    var originalColor = (Color)btn.Tag;
                    btn.BackColor = ControlPaint.Dark(originalColor, 0.1f);
                };

                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = (Color)btn.Tag;
                };
            }

            imageList.ImageSize = new Size(128, 128);
            string imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "book.png"
                );

            imageList.Images.Add("topic", Image.FromFile(imagePath));

            imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "exam.png"
                );

            imageList.Images.Add("exam", Image.FromFile(imagePath));

            imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "examAnswer.png"
                );

            imageList.Images.Add("examAnswer", Image.FromFile(imagePath));

            imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "students.png"
                );

            imageList.Images.Add("students", Image.FromFile(imagePath));

            imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "answering.png"
                );

            imageList.Images.Add("answering", Image.FromFile(imagePath));

            imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "teaching.png"
                );

            imageList.Images.Add("teaching", Image.FromFile(imagePath));


            crsTopBTN.ImageList = imageList;
            crsTopBTN.ImageKey = "topic";
            crsTopBTN.TextImageRelation = TextImageRelation.TextAboveImage;

            examQuReport.ImageList = imageList;
            examQuReport.ImageKey = "exam";
            examQuReport.TextImageRelation = TextImageRelation.TextAboveImage;

            stdAnsBTN.ImageList = imageList;
            stdAnsBTN.ImageKey = "answering";
            stdAnsBTN.TextImageRelation = TextImageRelation.TextAboveImage;

            stdDeptBTN.ImageList = imageList;
            stdDeptBTN.ImageKey = "students";
            stdDeptBTN.TextImageRelation = TextImageRelation.TextAboveImage;

            stdGradeBTN.ImageList = imageList;
            stdGradeBTN.ImageKey = "examAnswer";
            stdGradeBTN.TextImageRelation = TextImageRelation.TextAboveImage;

            insCrsBTN.ImageList = imageList;
            insCrsBTN.ImageKey = "teaching";
            insCrsBTN.TextImageRelation = TextImageRelation.TextAboveImage;

        }


        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Super.Show();
        }

        private void logOutBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crsTopBTN_Click(object sender, EventArgs e)
        {
            CourseTopicForm form = new CourseTopicForm(this);
            form.Show();
            Hide();
        }

        private void examQuReport_Click(object sender, EventArgs e)
        {
            ExamQuestionForm form = new ExamQuestionForm(this);
            form.Show();
            Hide();
        }

        private void stdAnsBTN_Click(object sender, EventArgs e)
        {
            StudentAnswerForm form = new StudentAnswerForm(this);
            form.Show();
            Hide();
        }

        private void insCrsBTN_Click(object sender, EventArgs e)
        {
            InstructorCourseForm form = new InstructorCourseForm(this);
            form.Show();
            Hide();
        }

        private void stdGradeBTN_Click(object sender, EventArgs e)
        {
            StudentCourseForm form = new StudentCourseForm(this);
            form.Show();
            Hide();
        }

        private void stdDeptBTN_Click(object sender, EventArgs e)
        {
            StudentDepartmentForm form = new StudentDepartmentForm(this);
            form.Show();
            Hide();
        }
    }
}
