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
            //string strCmdLine = @"cd C:\RUO folder\test_cmd_git";

            //Process.Start(@"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe --cd-to-home", strCmdLine);

            string fileName = @"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe";
            string command = "reflog";
            string workingDir = @"C:\RUO folder\test_cmd_git";

            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, "-c \" " + command + " \"")
            {
                WorkingDirectory = workingDir,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(processStartInfo);
            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            var exitCode = process.ExitCode;

            process.Close();
        }
    }
}
