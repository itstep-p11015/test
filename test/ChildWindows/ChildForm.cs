using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildWindows
{
    public partial class ChildForm : Form
    {
        int barCount = 3;
        int progress = 0;

        void SeparateThread()
        {
            for (int i = 0; i <= 100; i++)
            {
                progress = i;
                Thread.Sleep(100);
            }
            return;
        }

        public ChildForm(ParentForm form)
        {
            InitializeComponent();
            this.MdiParent = form;

        }

        private void ChildForm_Shown(object sender, EventArgs e)
        {
            //SeparateThread();
            Thread t = new Thread(SeparateThread);
            t.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        Brush b = new LinearGradientBrush(ClientRectangle,
   Color.Red, Color.Yellow, System.Drawing.Drawing2D.
   LinearGradientMode.Vertical);
            int h = pictureBox1.Height;
            int w = pictureBox1.Width;

            int wBar = w/barCount;

            for (int i = 0; i < barCount; i++)
            {
                // рисуем столбик высоты h
                int length = progress * h / 100;
                e.Graphics.FillRectangle(b,wBar*i,h-length,wBar/2,length);
            }
        }
    }
}
