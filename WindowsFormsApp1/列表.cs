using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 列表 : Form
    {
        public static View s = View.List;
        public 列表()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void UpData(string[] x, string[] z, int y)
        {
            for(int i=0; i<y; i++)
            {
                this.listView1.Items.Add(x[i] + " " + z[i]);
            }
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.List;
            s=View.List;
        }
        public void See()
        {
            this.listView1.View = s;
        }

        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }
    }
}
