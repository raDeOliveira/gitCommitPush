using System.Diagnostics;

namespace GitCommitPush
{
    public partial class Commit : Form
    {
        public Commit()
        {
            InitializeComponent();
        }

        private void commit_btn_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe";
            string command = "git add .&";
            string workingDir = @"" + get_path.Text + "";

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
    }
}
