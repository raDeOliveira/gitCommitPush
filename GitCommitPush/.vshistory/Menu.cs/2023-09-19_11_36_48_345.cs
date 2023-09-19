namespace GitCommitPush
{
    public partial class Menu : Form
    {
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

        private void commit_btn_Click(object sender, EventArgs e)
        {
            var commitForm = new Commit();
            commitForm.ShowDialog();
        }
    }
}