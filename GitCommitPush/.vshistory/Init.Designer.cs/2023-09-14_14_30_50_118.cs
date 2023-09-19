namespace GitCommitPush
{
    partial class Init
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            path_text = new TextBox();
            path_lbl = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            gitInit_btn = new Button();
            remoteUri_txt = new TextBox();
            remoteUri_lbl = new Label();
            commit_lbl = new Label();
            commit_txt = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // path_text
            // 
            path_text.Location = new Point(88, 137);
            path_text.Name = "path_text";
            path_text.Size = new Size(400, 23);
            path_text.TabIndex = 0;
            // 
            // path_lbl
            // 
            path_lbl.AutoSize = true;
            path_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            path_lbl.Location = new Point(248, 104);
            path_lbl.Name = "path_lbl";
            path_lbl.Size = new Size(71, 32);
            path_lbl.TabIndex = 1;
            path_lbl.Text = "Path:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(574, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // gitInit_btn
            // 
            gitInit_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gitInit_btn.Location = new Point(184, 440);
            gitInit_btn.Name = "gitInit_btn";
            gitInit_btn.Size = new Size(200, 35);
            gitInit_btn.TabIndex = 4;
            gitInit_btn.Text = "GIT init";
            gitInit_btn.UseVisualStyleBackColor = true;
            gitInit_btn.Click += button1_Click;
            // 
            // remoteUri_txt
            // 
            remoteUri_txt.Location = new Point(87, 216);
            remoteUri_txt.Name = "remoteUri_txt";
            remoteUri_txt.Size = new Size(400, 23);
            remoteUri_txt.TabIndex = 9;
            // 
            // remoteUri_lbl
            // 
            remoteUri_lbl.AutoSize = true;
            remoteUri_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            remoteUri_lbl.Location = new Point(183, 184);
            remoteUri_lbl.Name = "remoteUri_lbl";
            remoteUri_lbl.Size = new Size(227, 32);
            remoteUri_lbl.TabIndex = 8;
            remoteUri_lbl.Text = "Enter Remote URL:";
            // 
            // commit_lbl
            // 
            commit_lbl.AutoSize = true;
            commit_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            commit_lbl.Location = new Point(191, 264);
            commit_lbl.Name = "commit_lbl";
            commit_lbl.Size = new Size(175, 32);
            commit_lbl.TabIndex = 7;
            commit_lbl.Text = "Enter commit:";
            // 
            // commit_txt
            // 
            commit_txt.Location = new Point(87, 296);
            commit_txt.Name = "commit_txt";
            commit_txt.Size = new Size(400, 48);
            commit_txt.TabIndex = 6;
            commit_txt.Text = "";
            // 
            // Init
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 509);
            Controls.Add(remoteUri_txt);
            Controls.Add(remoteUri_lbl);
            Controls.Add(commit_lbl);
            Controls.Add(commit_txt);
            Controls.Add(gitInit_btn);
            Controls.Add(path_lbl);
            Controls.Add(path_text);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Init";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Init";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox path_text;
        private Label path_lbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button gitInit_btn;
        private TextBox remoteUri_txt;
        private Label remoteUri_lbl;
        private Label commit_lbl;
        private RichTextBox commit_txt;
    }
}