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

            string strCmdLine =
     "/C C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe " +
     "--load-extension=\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\toolbar-GC\"";

            System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
        }
    }
}
