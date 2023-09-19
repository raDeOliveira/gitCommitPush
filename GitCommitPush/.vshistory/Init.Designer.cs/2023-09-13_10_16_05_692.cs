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
            textBox1 = new TextBox();
            path_lbl = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 23);
            textBox1.TabIndex = 0;
            // 
            // path_lbl
            // 
            path_lbl.AutoSize = true;
            path_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            path_lbl.Location = new Point(39, 56);
            path_lbl.Name = "path_lbl";
            path_lbl.Size = new Size(139, 32);
            path_lbl.TabIndex = 1;
            path_lbl.Text = "Enter path:";
            // 
            // Init
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(path_lbl);
            Controls.Add(textBox1);
            Name = "Init";
            Text = "Init";
            ResumeLayout(false);
            PerformLayout();
            StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        private TextBox textBox1;
        private Label path_lbl;
    }
}