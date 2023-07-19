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
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "选择文件";
            //openFileDialog1.Filter = "所有文件|*.*|";
            openFileDialog1.ShowDialog(this);
            textBox1.Text= openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "深色模式")
            {
                Color black = Color.Black;
                BackColor = black;
                button3.Text = "浅色模式";
            }
            else
            {
                Color white = Color.White;
                BackColor = white;
                button3.Text = "深色模式";
            }
        }
    }
}
