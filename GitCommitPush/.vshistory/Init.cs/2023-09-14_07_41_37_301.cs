using System.Diagnostics;

namespace GitCommitPush
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

            //string strCmdLine = @"cd=C:\DGSante\Git\dg-sante-new-cpms\ --init-file C:\DGSante\Git\dg-sante-new-cpms\start.sh";
            string strCmdLine = "--cd-to-home";

            Process.Start(@"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe", strCmdLine);
        }
    }
}
