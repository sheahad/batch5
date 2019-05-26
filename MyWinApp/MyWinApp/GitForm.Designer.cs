namespace MyWinApp
{
    partial class GitForm
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
            this.NameButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(93, 93);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(75, 23);
            this.NameButton.TabIndex = 0;
            this.NameButton.Text = "Full Name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(68, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(12, 31);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 2;
            this.namelabel.Text = "Name";
            // 
            // GitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.NameButton);
            this.Name = "GitForm";
            this.Text = "GitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label namelabel;
    }
}