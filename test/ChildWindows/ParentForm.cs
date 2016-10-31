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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm(this);
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string formNames = "";
            foreach (ChildForm f in this.MdiChildren)
            {
                formNames += f.Text+"\n";
            }
            MessageBox.Show(formNames);
        }

        private void dataSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DataSourceForm().Show();
        }
    }
}
