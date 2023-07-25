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
    public partial class MediaPlayer : Form
    {
        public static string[] text = new string[10000];
        public static int i = 0;
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = textBox1.Text;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
            text[i] = textBox1.Text;
            i++;
            列表 s = new 列表();
            s.UpData(text);
        }


 
        private void 打开ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "选择文件";
            //openFileDialog1.Filter = "所有文件|*.*|";
            openFileDialog1.ShowDialog(this);
            textBox1.Text= openFileDialog1.FileName;
        }

        private void 深色模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(深色模式ToolStripMenuItem.Text == "深色模式")
            {
                Color black = Color.Black;
                BackColor = black;
                深色模式ToolStripMenuItem.Text = "浅色模式";
            }
            else
            {
                Color white = Color.White;
                BackColor = white;
                深色模式ToolStripMenuItem.Text = "深色模式";
            }
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            欢迎 Formw = new 欢迎();
            Formw.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            列表 s=new 列表();
            if (i == 0) ;
            else s.UpData(text);
            s.Show();
        }
    }
}
