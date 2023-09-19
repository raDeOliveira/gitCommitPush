namespace GitCommitPush
{
    public partial class Init : Form
    {

        public string path { get; set; }
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
            rst_lbl.Text = path;
        }
    }
}
