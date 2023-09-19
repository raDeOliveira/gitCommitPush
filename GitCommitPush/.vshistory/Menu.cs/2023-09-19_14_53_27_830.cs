using System.Diagnostics;

namespace GitCommitPush
{
    public partial class Menu : Form
    {

        public string getPath { get; set; }
        public Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void init_btn_Click(object sender, EventArgs e)
        {
            var initform = new Init();
            initform.ShowDialog();
        }

        private void push_btn_Click(object sender, EventArgs e)
        {
            string workingDir = @"" + getPath + "";

            string fileName = @"C:\Users\RUO\AppData\Local\Programs\Git\git-bash.exe";
            string command = @"git push -u origin master";


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