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

namespace Desktop.StudentForms.AnswersForm
{
    public partial class AnswerForm : Form
    {
        ExamContext context = new();
        Form super;
        Exam exam;
        int number = 0;
        List<Answer_Exam> questions;
        Student_Exam studentDegree;
        System.Windows.Forms.Timer timer;
        public AnswerForm(Form super, Exam exam)
        {
            InitializeComponent();
            this.super = super;
            this.exam = exam;

            Utilites.InitForm(this, $"{exam.Name} : Course '{exam.Course.Name}' : {DateTime.Now:D}");
            choice1TXT.BackColor =
            choice2TXT.BackColor =
            choice3TXT.BackColor =
            choice4TXT.BackColor = Color.White;

            choice1TXT.SelectionAlignment =
            choice2TXT.SelectionAlignment =
            choice3TXT.SelectionAlignment =
            choice4TXT.SelectionAlignment = HorizontalAlignment.Center;

            questions = context.Answer_Exams
                .Include(qt => qt.Question)
                .ThenInclude(qt => qt.Choices)
                .Where(qt => qt.ExamID == exam.ID && qt.StdID == Utilites.Person.ID)
                .ToList();

            studentDegree = context.Student_Exams
                .SingleOrDefault(exm => exm.ExamID == exam.ID && exm.StdID == Utilites.Person.ID);
            if (studentDegree == null)
            {
                MessageBox.Show("The Student doesn't show up in the Exam Registeration, Try entering the exam again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ShowQuestion();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeTXT.Text = $"{((TimeSpan)(exam.EndDate - DateTime.Now)).ToString(@"hh\:mm\:ss")}";
            if (exam.EndDate < DateTime.Now)
            {
                timer.Stop();
                MessageBox.Show("The Exam has ended", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel panel)
            {
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.FromArgb(194, 39, 45), ButtonBorderStyle.Dashed);
            }
        }

        private void ShowQuestion()
        {
            questionLBL.Text = $"Question {number + 1}";
            var question = questions[number].Question;
            bodyTXT.Text = question.Body;
            var choices = question.Choices.OrderBy(cho => cho.ChoiceNum).ToList();
            if (question.Type == "MCQ")
            {
                choice1TXT.Text = choices[0].Body;
                choice2TXT.Text = choices[1].Body;
                choice3TXT.Text = choices[2].Body;
                choice4TXT.Text = choices[3].Body;
                panel3.Visible = panel4.Visible =
                choice3TXT.Visible = choice4TXT.Visible = true;
            }
            else if (question.Type == "T/F")
            {
                choice1TXT.Text = choices[0].Body;
                choice2TXT.Text = choices[1].Body;
                panel3.Visible = panel4.Visible =
                choice3TXT.Visible = choice4TXT.Visible = false;
            }
            if (questions[number].Answer == 1) { choice1TXT_MouseDown(new object(), new MouseEventArgs(MouseButtons.None, 1, 1, 1, 1)); }
            else if (questions[number].Answer == 2) { choice2TXT_MouseDown(new object(), new MouseEventArgs(MouseButtons.None, 1, 1, 1, 1)); }
            else if (questions[number].Answer == 3) { choice3TXT_MouseDown(new object(), new MouseEventArgs(MouseButtons.None, 1, 1, 1, 1)); }
            else if (questions[number].Answer == 4) { choice4TXT_MouseDown(new object(), new MouseEventArgs(MouseButtons.None, 1, 1, 1, 1)); }
            else { choice1TXT.BackColor = choice2TXT.BackColor = choice3TXT.BackColor = choice4TXT.BackColor = Color.White; }

        }

        private void AnswerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Dispose();
            super.Show();
        }

        private void choice1TXT_MouseDown(object sender, MouseEventArgs e)
        {

            if (questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade -= questions[number].Question.Degree;
            }
            questions[number].Answer = 1;
            if (questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade += questions[number].Question.Degree;
            }
            context.SaveChanges();

            questionLBL.Focus();
            choice1TXT.BackColor = Color.FromArgb(218, 217, 218);

            choice2TXT.BackColor = choice3TXT.BackColor = choice4TXT.BackColor = Color.White;
        }

        private void choice2TXT_MouseDown(object sender, MouseEventArgs e)
        {
            if (questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade -= questions[number].Question.Degree;
            }
            questions[number].Answer = 2;
            if(questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade += questions[number].Question.Degree;
            }
            context.SaveChanges();

            questionLBL.Focus();
            choice2TXT.BackColor = Color.FromArgb(218, 217, 218);

            choice1TXT.BackColor = choice3TXT.BackColor = choice4TXT.BackColor = Color.White;
        }

        private void choice3TXT_MouseDown(object sender, MouseEventArgs e)
        {
            if (questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade -= questions[number].Question.Degree;
            }
            questions[number].Answer = 3;
            if (questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade += questions[number].Question.Degree;
            }
            context.SaveChanges();

            questionLBL.Focus();
            choice3TXT.BackColor = Color.FromArgb(218, 217, 218);

            choice2TXT.BackColor = choice1TXT.BackColor = choice4TXT.BackColor = Color.White;
        }

        private void choice4TXT_MouseDown(object sender, MouseEventArgs e)
        {
            if (questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade -= questions[number].Question.Degree;
            }
            questions[number].Answer = 4;
            if (questions[number].Answer == questions[number].Question.CorrectChoice)
            {
                studentDegree.Grade += questions[number].Question.Degree;
            }
            context.SaveChanges();

            questionLBL.Focus();
            choice4TXT.BackColor = Color.FromArgb(218, 217, 218);

            choice2TXT.BackColor = choice3TXT.BackColor = choice1TXT.BackColor = Color.White;
        }

        private void bodyTXT_MouseDown(object sender, MouseEventArgs e)
        {
            questionLBL.Focus();
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            number++;
            number = number > 9 ? 0 : number;
            ShowQuestion();
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            number--;
            number = number < 0 ? 9 : number;
            ShowQuestion();
        }

        private void endBTN_Click(object sender, EventArgs e)
        {
            var unansweredQs = questions.Where(ans => ans.Answer == 0 || ans.Answer == null).Count();
            if(unansweredQs > 0)
            {
                if(MessageBox.Show($"You have left {unansweredQs} unanswered questions. Are you sure you want to exit ?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
    }
}
