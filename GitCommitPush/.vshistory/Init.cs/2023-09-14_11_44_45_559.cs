using System.Diagnostics;
using System.Text.RegularExpressions;

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

            string fileName = @"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe";
            //string command = "git init";
            string command = "cd";
            //string workingDir = $@"{path_text}";
            string workingDir = @"C:\RUO folder\test_cmd_git";
            string replaced = Regex.Replace(workingDir, @"(?<!\\)/(?!\\)", @"\");

            // C:\RUO folder\test_cmd_git
            Debug.WriteLine(workingDir);

            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, "-c \" " + command + " \"")
            {
                WorkingDirectory = replaced,
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
        }
    }
}
