namespace GitCommitPush
{
    partial class Push
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
            gitInit_btn = new Button();
            path_lbl = new Label();
            path_text = new TextBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            SuspendLayout();
            // 
            // gitInit_btn
            // 
            gitInit_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gitInit_btn.Location = new Point(296, 144);
            gitInit_btn.Name = "gitInit_btn";
            gitInit_btn.Size = new Size(200, 35);
            gitInit_btn.TabIndex = 7;
            gitInit_btn.Text = "Push";
            gitInit_btn.UseVisualStyleBackColor = true;
            gitInit_btn.Click += gitInit_btn_Click;
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
            // path_lbl
            // 
            path_lbl.AutoSize = true;
            path_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            path_lbl.Location = new Point(360, 40);
            path_lbl.Name = "path_lbl";
            path_lbl.Size = new Size(71, 32);
            path_lbl.TabIndex = 6;
            path_lbl.Text = "Path:";
            // 
            // path_text
            // 
            path_text.Location = new Point(200, 73);
            path_text.Name = "path_text";
            path_text.Size = new Size(400, 23);
            path_text.TabIndex = 5;
            // 
            // Push
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 194);
            Controls.Add(gitInit_btn);
            Controls.Add(path_lbl);
            Controls.Add(path_text);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Push";
            Text = "Push";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gitInit_btn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label path_lbl;
        public TextBox path_text;
    }
}