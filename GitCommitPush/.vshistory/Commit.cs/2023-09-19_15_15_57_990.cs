using System.Diagnostics;

namespace GitCommitPush
{
    public partial class Commit : Form
    {
        public Commit()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void commit_btn_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe";
            string gitRemote = @"git remote add origin " + remoteUri_txt.Text + "";
            string gitCommit = @"git commit -m '" + commit_txt.Text + "'";

            string workingDir = @"" + path_text.Text + "";

            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, "-c \" " + gitRemote + " & " + gitCommit + "\"")
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
    }
}
