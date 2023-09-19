namespace GitCommitPush
{
    public partial class Main : Form
    {
        public Main()
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
    }
}