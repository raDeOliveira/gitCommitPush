﻿namespace GitCommitPush
{
    public partial class Init : Form
    {

        public Init()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string cmdString = @" " + path_text.Text + "";

            string strCmdLine = "/k ipconfig";

            System.Diagnostics.Process.Start(@"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe --cd-to-home", strCmdLine);
        }
    }
}
