namespace GitCommitPush
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title_lbl = new Label();
            init_btn = new Button();
            commit_btn = new Button();
            push_btn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            title_lbl.Location = new Point(32, 73);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(612, 51);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Init GIT / Commit / Push Changes";
            // 
            // init_btn
            // 
            init_btn.Location = new Point(32, 159);
            init_btn.Name = "init_btn";
            init_btn.Size = new Size(200, 35);
            init_btn.TabIndex = 1;
            init_btn.Text = "Init GIT";
            init_btn.UseVisualStyleBackColor = true;
            // 
            // commit_btn
            // 
            commit_btn.Location = new Point(238, 159);
            commit_btn.Name = "commit_btn";
            commit_btn.Size = new Size(200, 35);
            commit_btn.TabIndex = 2;
            commit_btn.Text = "Commit Changes";
            commit_btn.UseVisualStyleBackColor = true;
            // 
            // push_btn
            // 
            push_btn.Location = new Point(444, 159);
            push_btn.Name = "push_btn";
            push_btn.Size = new Size(200, 35);
            push_btn.TabIndex = 3;
            push_btn.Text = "Push Changes";
            push_btn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(678, 24);
            menuStrip1.TabIndex = 4;
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
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(push_btn);
            Controls.Add(commit_btn);
            Controls.Add(init_btn);
            Controls.Add(title_lbl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        private Label title_lbl;
        private Button init_btn;
        private Button commit_btn;
        private Button push_btn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}