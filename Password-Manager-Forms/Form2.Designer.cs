namespace Password_Manager_Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Rpassword = new System.Windows.Forms.TextBox();
            this.saveDatabaseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Repeat password:";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(169, 71);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(250, 25);
            this.textBox.TabIndex = 0;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(201, 112);
            this.password.MaxLength = 100;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(191, 18);
            this.password.TabIndex = 2;
            // 
            // Rpassword
            // 
            this.Rpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rpassword.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rpassword.Location = new System.Drawing.Point(201, 143);
            this.Rpassword.MaxLength = 100;
            this.Rpassword.Name = "Rpassword";
            this.Rpassword.PasswordChar = '●';
            this.Rpassword.ShortcutsEnabled = false;
            this.Rpassword.Size = new System.Drawing.Size(191, 18);
            this.Rpassword.TabIndex = 3;
            // 
            // saveDatabaseButton
            // 
            this.saveDatabaseButton.BackColor = System.Drawing.Color.Black;
            this.saveDatabaseButton.ForeColor = System.Drawing.Color.White;
            this.saveDatabaseButton.Location = new System.Drawing.Point(12, 71);
            this.saveDatabaseButton.Name = "saveDatabaseButton";
            this.saveDatabaseButton.Size = new System.Drawing.Size(151, 25);
            this.saveDatabaseButton.TabIndex = 11;
            this.saveDatabaseButton.Text = "Save database in >";
            this.saveDatabaseButton.UseVisualStyleBackColor = false;
            this.saveDatabaseButton.Click += new System.EventHandler(this.saveDatabaseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Black;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(184, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(78, 31);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Black;
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(281, 180);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(106, 31);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.White;
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileName.Location = new System.Drawing.Point(425, 71);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(88, 26);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "Safes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "File name:";
            // 
            // Form2
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 269);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveDatabaseButton);
            this.Controls.Add(this.Rpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox textBox;
        private TextBox password;
        private TextBox Rpassword;
        private Button saveDatabaseButton;
        private Button cancelButton;
        private Button CreateButton;
        private TextBox fileName;
        private Label label1;
    }
}