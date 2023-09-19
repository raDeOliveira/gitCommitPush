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
            commit_txt = new RichTextBox();
            commit_lbl = new Label();
            remoteUri_lbl = new Label();
            remoteUri_txt = new TextBox();
            commit_btn = new Button();
            SuspendLayout();
            // 
            // commit_txt
            // 
            commit_txt.Location = new Point(24, 272);
            commit_txt.Name = "commit_txt";
            commit_txt.Size = new Size(400, 48);
            commit_txt.TabIndex = 1;
            commit_txt.Text = "";
            // 
            // commit_lbl
            // 
            commit_lbl.AutoSize = true;
            commit_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            commit_lbl.Location = new Point(128, 232);
            commit_lbl.Name = "commit_lbl";
            commit_lbl.Size = new Size(175, 32);
            commit_lbl.TabIndex = 2;
            commit_lbl.Text = "Enter commit:";
            // 
            // remoteUri_lbl
            // 
            remoteUri_lbl.AutoSize = true;
            remoteUri_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            remoteUri_lbl.Location = new Point(120, 32);
            remoteUri_lbl.Name = "remoteUri_lbl";
            remoteUri_lbl.Size = new Size(227, 32);
            remoteUri_lbl.TabIndex = 4;
            remoteUri_lbl.Text = "Enter Remote URL:";
            // 
            // remoteUri_txt
            // 
            remoteUri_txt.Location = new Point(24, 64);
            remoteUri_txt.Name = "remoteUri_txt";
            remoteUri_txt.Size = new Size(400, 23);
            remoteUri_txt.TabIndex = 5;
            // 
            // commit_btn
            // 
            commit_btn.Location = new Point(112, 392);
            commit_btn.Name = "commit_btn";
            commit_btn.Size = new Size(200, 35);
            commit_btn.TabIndex = 6;
            commit_btn.Text = "Commit";
            commit_btn.UseVisualStyleBackColor = true;
            // 
            // Commit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(commit_btn);
            Controls.Add(remoteUri_txt);
            Controls.Add(remoteUri_lbl);
            Controls.Add(commit_lbl);
            Controls.Add(commit_txt);
            Name = "Commit";
            Text = "Commit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox commit_txt;
        private Label commit_lbl;
        private Label remoteUri_lbl;
        private TextBox remoteUri_txt;
        private Button commit_btn;
    }
}