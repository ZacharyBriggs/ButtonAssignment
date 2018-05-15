using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonAssignment
{
    public class Button
    {
        public Point pos;
        public int Area;

        public delegate void TMouseClicked();
        public event EventHandler Click;

        public Button(int x, int y, int area)
        {
            pos.X = x;
            pos.Y = y;
            Area = area;
        }
        public bool CheckClick()
        {
            if (Cursor.Position.X > pos.X - Area / 2 && Cursor.Position.X < pos.X + Area / 2 &&
                Cursor.Position.Y > pos.Y - Area / 2 && Cursor.Position.Y < pos.Y + Area / 2)
            {
                return true;
            }
            return false;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
