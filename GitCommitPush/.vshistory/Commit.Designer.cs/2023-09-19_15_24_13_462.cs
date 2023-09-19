namespace GitCommitPush
{
    partial class Commit
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
            remoteUri_txt = new TextBox();
            remoteUri_lbl = new Label();
            commit_lbl = new Label();
            commit_txt = new RichTextBox();
            commit_btn = new Button();
            path_lbl = new Label();
            path_text = new TextBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(468, 24);
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
            // remoteUri_txt
            // 
            remoteUri_txt.Location = new Point(24, 128);
            remoteUri_txt.Name = "remoteUri_txt";
            remoteUri_txt.Size = new Size(400, 23);
            remoteUri_txt.TabIndex = 16;
            // 
            // remoteUri_lbl
            // 
            remoteUri_lbl.AutoSize = true;
            remoteUri_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            remoteUri_lbl.Location = new Point(120, 96);
            remoteUri_lbl.Name = "remoteUri_lbl";
            remoteUri_lbl.Size = new Size(227, 32);
            remoteUri_lbl.TabIndex = 15;
            remoteUri_lbl.Text = "Enter Remote URL:";
            // 
            // commit_lbl
            // 
            commit_lbl.AutoSize = true;
            commit_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            commit_lbl.Location = new Point(128, 176);
            commit_lbl.Name = "commit_lbl";
            commit_lbl.Size = new Size(175, 32);
            commit_lbl.TabIndex = 14;
            commit_lbl.Text = "Enter commit:";
            // 
            // commit_txt
            // 
            commit_txt.Location = new Point(24, 208);
            commit_txt.Name = "commit_txt";
            commit_txt.Size = new Size(400, 48);
            commit_txt.TabIndex = 13;
            commit_txt.Text = "";
            // 
            // commit_btn
            // 
            commit_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            commit_btn.Location = new Point(121, 280);
            commit_btn.Name = "commit_btn";
            commit_btn.Size = new Size(200, 35);
            commit_btn.TabIndex = 12;
            commit_btn.Text = "Commit";
            commit_btn.UseVisualStyleBackColor = true;
            commit_btn.Click += commit_btn_Click;
            // 
            // path_lbl
            // 
            path_lbl.AutoSize = true;
            path_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            path_lbl.Location = new Point(185, 16);
            path_lbl.Name = "path_lbl";
            path_lbl.Size = new Size(71, 32);
            path_lbl.TabIndex = 11;
            path_lbl.Text = "Path:";
            // 
            // path_text
            // 
            path_text.Location = new Point(25, 49);
            path_text.Name = "path_text";
            path_text.Size = new Size(400, 23);
            path_text.TabIndex = 10;
            // 
            // Commit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 331);
            Controls.Add(remoteUri_txt);
            Controls.Add(remoteUri_lbl);
            Controls.Add(commit_lbl);
            Controls.Add(commit_txt);
            Controls.Add(commit_btn);
            Controls.Add(path_lbl);
            Controls.Add(path_text);
            Name = "Commit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Commit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox remoteUri_txt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label remoteUri_lbl;
        private Label commit_lbl;
        private RichTextBox commit_txt;
        private Button commit_btn;
        private Label path_lbl;
        public TextBox path_text;
    }
}