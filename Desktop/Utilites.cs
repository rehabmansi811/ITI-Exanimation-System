using Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Desktop
{
    static class Utilites
    {
        public static Person? Person;

        public static void InitForm(Form form , string name)
        {
            form.Text = name;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;

            string imagePath = Path.Combine(
                System.Windows.Forms.Application.StartupPath.Split(@"\bin")[0],
                "Images",
                "iti-logo.ico"
                );
            form.Icon = new Icon(imagePath);
            form.BackColor = Color.White;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
        }
    }
}
