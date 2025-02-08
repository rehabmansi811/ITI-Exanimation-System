using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    static public class UIConfig
    {
        // Primary Colors
        public static readonly Color PrimaryColor = Color.FromArgb(74, 144, 226);  // Soft Blue
        public static readonly Color PrimaryColorLight = Color.FromArgb(173, 216, 230); // Light Blue
        public static readonly Color PrimaryColorDark = Color.FromArgb(25, 25, 112);   // Dark Blue
        public static readonly Color PrimaryColorLighter = Color.FromArgb(200, 230, 255); // Lighter Blue

        // Secondary Colors
        public static readonly Color SecondaryColor = Color.FromArgb(245, 245, 245); // Light Gray
        public static readonly Color SecondaryColorLight = Color.White;             // White
        public static readonly Color SecondaryColorDark = Color.FromArgb(220, 220, 220);  // Dark Gray
        public static readonly Color SecondaryColorLighter = Color.FromArgb(255, 250, 250); // Lighter Gray

        // Accent Colors
        public static readonly Color AccentColor = Color.FromArgb(126, 211, 33);  // Green
        public static readonly Color AccentColorLight = Color.FromArgb(152, 251, 152); // Light Green
        public static readonly Color AccentColorDark = Color.FromArgb(34, 139, 34);   // Dark Green
        public static readonly Color AccentColorLighter = Color.FromArgb(180, 255, 180); // Lighter Green

        // Error Color
        public static readonly Color ErrorColor = Color.FromArgb(210, 2, 27);     // Red
        public static readonly Color ErrorColorLighter = Color.FromArgb(255, 102, 102); // Lighter Red

        // Text Color
        public static readonly Color TextColor = Color.FromArgb(51, 51, 51);      // Dark Gray

        // Font Styles
        public static readonly Font HeaderFont = new Font("Segoe UI", 18, FontStyle.Bold);
        public static readonly Font BodyFont = new Font("Segoe UI", 12);
        public static readonly Font ButtonFont = new Font("Segoe UI", 12);
    }
}
