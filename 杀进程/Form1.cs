using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 杀进程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcessesByName(textBox1.Text);
            foreach (Process p in process)
            {
                if (!p.HasExited)  // 如果程序没有关闭，结束程序
                {
                    p.Kill();
                    p.WaitForExit();
                }
            }
        }
    }
}
