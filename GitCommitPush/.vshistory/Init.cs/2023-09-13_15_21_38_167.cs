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

            string strCmdLine = "/C ipconfig pause";

            System.Diagnostics.Process.Start("cmd.exe", strCmdLine);
        }
    }
}
