using System.Diagnostics;
using System.Text;

namespace GitCommitPush
{
    public partial class Init : Form
    {

        public string getPath { get; set; }

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
            StringBuilder sb = new StringBuilder();
            //string command = @"git init & git add .";
            sb.Append("git init");
            sb.Append(" sleep 0.1 ");
            sb.Append("git add .");
            //sb.Append("git remote add origin " + remoteUri_txt.Text + " & git commit -m '" + commit_txt.Text + "'");

            string workingDir = @"" + path_text.Text + "";

            // C:\RUO folder\test_cmd_git
            Debug.WriteLine(workingDir);

            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, "-c \" " + sb + " \"")
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
