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
            string strCmdLine = @"cd C:\RUO folder\test_cmd_git";

            Process.Start(@"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe --cd-to-home", strCmdLine);

            Process gitProcess = new Process();
            gitInfo.Arguments = YOUR_GIT_COMMAND; // such as "fetch origin"
            gitInfo.WorkingDirectory = YOUR_GIT_REPOSITORY_PATH;
            gitInfo.UseShellExecute = false;

            gitProcess.StartInfo = gitInfo;
            gitProcess.Start();

            string stderr_str = gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            string stdout_str = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            gitProcess.WaitForExit();
            gitProcess.Close();
        }
    }
}
