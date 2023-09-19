using System.Diagnostics;

namespace GitCommitPush
{
    public partial class Init : Form
    {
        Menu menu = new Menu();
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

            string fileName = @"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe";
            string gitInit = @"git remote add origin " + remoteUri_txt.Text + ""; // & sleep 2 & git commit -m '" + commit_txt.Text + "' & sleep 2 & git push -u origin master";
            string gitCommit = @"git commit -m '" + commit_txt.Text + "'"; // & sleep 2 & git push -u origin master";
            string gitPush = @"git push -u origin master";

            string workingDir = @"" + path_text.Text + "";

            // C:\RUO folder\test_cmd_git
            Debug.WriteLine(workingDir);

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
            process?.WaitForExit();

            //string output = process.StandardOutput.ReadToEnd();
            //string error = process.StandardError.ReadToEnd();
            //var exitCode = process.ExitCode;

            process?.Close();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe";
            string command = @"git init & sleep 0.5 & git add .";

            string workingDir = @"" + path_text.Text + "";

            // C:\RUO folder\test_cmd_git
            Debug.WriteLine(workingDir);

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
            process?.WaitForExit();

            process?.Close();
            this.Close();
        }
    }
}
