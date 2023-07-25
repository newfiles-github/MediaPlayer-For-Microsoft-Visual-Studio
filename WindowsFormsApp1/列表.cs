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
        列表 s;
        public 列表()
        {
            InitializeComponent();
            s = this;
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void UpData(string[] x)
        {
            for(int i=0; i<x.Length; i++)
            {
                this.listView1.Items.Add(x[i]);
            }
        }
    }
}
