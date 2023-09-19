namespace GitCommitPush
{
    public partial class Init : Form
    {

        string testVar { get; set; }
        public Init()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
