using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildWindows
{
    public partial class DragDropWindow : Form
    {
        public DragDropWindow()
        {
            InitializeComponent();
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.DoDragDrop(button1.Text, DragDropEffects.Copy |
    DragDropEffects.Move);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
                //label1.Text = "Можно";
            }
            else
            {
                e.Effect = DragDropEffects.None;
                //label1.Text = "Нельзя";
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void textBox1_DragLeave(object sender, EventArgs e)
        {
       //     label1.Text = "Нельзя";
        }

        private void DragDropWindow_DragOver(object sender, DragEventArgs e)
        {
            label1.Top = e.Y;
            label1.Left = e.X;
            e.Effect = DragDropEffects.Move;
            Refresh();
        }

        private void DragDropWindow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }
    }
}
