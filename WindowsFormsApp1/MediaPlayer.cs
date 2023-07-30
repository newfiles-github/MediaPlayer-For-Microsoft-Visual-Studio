using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class MediaPlayer : Form
    {
        public static string[] text = new string[10000];
        public static string[] time = new string[10000];
        public static int i = 0;
        public static string Language = "Chinese";
        public MediaPlayer()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetSize();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {

            }
            else
            {
                this.axWindowsMediaPlayer1.URL = textBox1.Text;
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
                text[i] = textBox1.Text;
                time[i] = DateTime.Now.ToString();
                i++;
                列表 s = new 列表();
                s.UpData(text, time, i);
            }
        }
        private void SetSize()
        {
            int width=this.ClientSize.Width;
            int height=this.ClientSize.Height;
            textBox1.Width = Convert.ToInt32(width * 0.92);
            button1.Location = new Point(width - 80, 28);
            axWindowsMediaPlayer1.Width= width;
            axWindowsMediaPlayer1.Height = Convert.ToInt32(height * 0.85);
        }

 
        private void 打开ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "选择文件";
            //openFileDialog1.Filter = "所有文件|*.*|";
            openFileDialog1.ShowDialog(this);
            textBox1.Text= openFileDialog1.FileName;
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            欢迎 Formw = new 欢迎();
            Formw.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Language == "Chinese")
            {
                if (MessageBox.Show("确定要退出吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
            }
            else if (Language == "English") { if (MessageBox.Show("Are you sure you want to quit?", "prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close(); }
            else if (Language == "Japan") { if (MessageBox.Show("やめてよろしいですか?", "プロンプト", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close(); }
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            列表 s=new 列表();
            if (Language == "Chinese") s.Text = "历史记录";
            else if (Language == "English") s.Text = "History";
            else if (Language == "Japan") s.Text = "歴史";
            s.See();
            if (i != 0) s.UpData(text, time, i);
            s.Show();
        }

        private void 简体中文ChineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "Chinese";
            this.Text = "视频播放器";
            #region 文件
            this.文件ToolStripMenuItem.Text = "文件";
            this.打开ToolStripMenuItem.Text = "打开";
            this.退出ToolStripMenuItem.Text = "退出";
            #endregion
            #region 显示
            this.显示ToolStripMenuItem.Text = "显示";
            this.深色和浅色模式ToolStripMenuItem.Text = "深色和浅色模式";
            #endregion
            #region 关于
            关于ToolStripMenuItem.Text = "关于";
            版本ToolStripMenuItem.Text = "版本";
            #endregion
            #region 历史记录
            this.历史记录ToolStripMenuItem.Text = "历史记录";
            this.查看ToolStripMenuItem.Text = "查看";
            #endregion
            #region 语言
            语言ToolStripMenuItem.Text = "语言";
            #endregion
            button1.Text = "播放";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "English";
            this.Text = "Video Player";
            #region 文件
            this.文件ToolStripMenuItem.Text = "File";
            this.打开ToolStripMenuItem.Text = "Open";
            this.退出ToolStripMenuItem.Text = "Exit";
            #endregion
            #region 显示
            this.显示ToolStripMenuItem.Text = "DisPlay";
            this.深色和浅色模式ToolStripMenuItem.Text = "Dark & Light Mode";
            #endregion
            #region 关于
            关于ToolStripMenuItem.Text = "About";
            版本ToolStripMenuItem.Text = "Version";
            #endregion
            #region 历史记录
            this.历史记录ToolStripMenuItem.Text = "History";
            this.查看ToolStripMenuItem.Text = "View";
            #endregion
            #region 语言
            语言ToolStripMenuItem.Text = "Language";
            #endregion
            button1.Text = "Play";
        }

        private void 日本語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "Japan";
            this.Text = "ビデオプレーヤー";
            #region 文件
            this.文件ToolStripMenuItem.Text = "ファイル";
            this.打开ToolStripMenuItem.Text = "開けて下さい";
            this.退出ToolStripMenuItem.Text = "辞める";
            #endregion
            #region 显示
            this.显示ToolStripMenuItem.Text = "陳列";
            this.深色和浅色模式ToolStripMenuItem.Text = "ダークモードとライトモード";
            #endregion
            #region 关于
            关于ToolStripMenuItem.Text = "について";
            版本ToolStripMenuItem.Text = "バージョン";
            #endregion
            #region 历史记录
            this.历史记录ToolStripMenuItem.Text = "歴史";
            this.查看ToolStripMenuItem.Text = "眺める";
            #endregion
            #region 语言
            语言ToolStripMenuItem.Text = "言語";
            #endregion
            button1.Text = "遊ぶ";
        }

        private void 深色和浅色模式ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                Color black = Color.Black;
                BackColor = black;
            }
            else
            {
                Color white = Color.White;
                BackColor = white;
            }
        }
    }
}
