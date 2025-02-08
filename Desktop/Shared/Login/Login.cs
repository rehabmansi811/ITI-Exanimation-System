using Desktop.Data;
using Microsoft.EntityFrameworkCore;
namespace Desktop
{
    public partial class Login : Form
    {
        readonly ExamContext context = new();
        public Login()
        {
            InitializeComponent();
            //Utilites.InitForm(this, "Login");
            Text = "Login";

            // Header
            Header.ForeColor = UIConfig.TextColor;

            // User TextBox
            //userTXT.PlaceholderText = "e.g Omar@example.com";

            // Password TextBox
            //passTXT.PlaceholderText = "e.g ********* :-)";

            // Login Button
            logBTN.BackColor = Color.FromArgb(194, 39, 45);
            logBTN.ForeColor = Color.White;

            // Warning Label
            warningLBL.Hide();

        }

        private void logBTN_Click(object sender, EventArgs e)
        {
            var user = userTXT.Text;
            var pass = passTXT.Text;

            Utilites.Person = context.People.SingleOrDefault(p => p.Email == user && p.Password == pass);
            if (Utilites.Person != null)
            {
                warningLBL.Hide();
                if (Utilites.Person.Role == "Admin")
                {
                    AdminHome adminHome = new AdminHome(this);
                    adminHome.Show();
                    Hide();
                }
                else if (Utilites.Person.Role == "Student")
                {
                    StudentHome studentHome = new StudentHome(this);
                    studentHome.Show();
                    Hide();
                }
                else if (Utilites.Person.Role == "Instructor")
                {
                    InstructorHome instructorHome = new InstructorHome(this);
                    instructorHome.Show();
                    Hide();
                }
                else
                {
                    warningLBL.Show();
                    warningLBL.Text = "This Person has a role that doesn't have a homepage";
                }

            }
            else
            {
                warningLBL.Show();
            }
            userTXT.Text = "";
            passTXT.Text = "";
        }


        private void logBTN_MouseLeave(object sender, EventArgs e)
        {
            logBTN.BackColor = Color.FromArgb(194, 39, 45);
        }

        private void logBTN_MouseEnter(object sender, EventArgs e)
        {
            logBTN.BackColor = Color.FromArgb(220, 194, 39, 45);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lockPIC_Click(object sender, EventArgs e)
        {
            if (passTXT.UseSystemPasswordChar)
            {
                string imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "unlock.png"
                );
                lockPIC.Image = Image.FromFile(imagePath);
                passTXT.UseSystemPasswordChar = false;
            }
            else
            {
                string imagePath = Path.Combine(
                Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "lock.png"
                );
                lockPIC.Image = Image.FromFile(imagePath);
                passTXT.UseSystemPasswordChar = true;
            }
        }
    }
}
