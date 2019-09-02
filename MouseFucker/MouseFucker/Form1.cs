using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MouseFucker
{
    public partial class Form1 : Form
    {
        private int X = 0;
        private int Y = 0;
        private PointConverter pc = new PointConverter();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //bounds the mouse within the form
            Cursor.Clip = this.Bounds;
        }

        private void Click_Click(object sender, EventArgs e)
        {
            //frees the mouse
            Cursor.Clip = Rectangle.Empty;
            //move the mouse
            Cursor.Position = new Point(Convert.ToInt32(xbox.Value), Convert.ToInt32(ybox.Value));
            //click
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            //move back to the form
            Cursor.Position = new Point(this.Bounds.X + 100, this.Bounds.Y + 100);
            //bound the mouse again
            Cursor.Clip = this.Bounds;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!this.Focused)
            {
                this.Activate();
            }
        }
    }
}
