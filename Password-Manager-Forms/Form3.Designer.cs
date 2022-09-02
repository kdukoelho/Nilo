namespace Password_Manager_Forms
{
    partial class Form3
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
            this.PasswordsTextBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordsTextBox
            // 
            this.PasswordsTextBox.BackColor = System.Drawing.Color.DimGray;
            this.PasswordsTextBox.FormattingEnabled = true;
            this.PasswordsTextBox.ItemHeight = 18;
            this.PasswordsTextBox.Location = new System.Drawing.Point(181, 15);
            this.PasswordsTextBox.Name = "PasswordsTextBox";
            this.PasswordsTextBox.Size = new System.Drawing.Size(343, 238);
            this.PasswordsTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Password Generator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(52, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordsTextBox);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PASSWORDS";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox PasswordsTextBox;
        private Button button1;
        private Button button2;
    }
}