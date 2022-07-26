namespace Password_Manager_Forms
{
    partial class Form1
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
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.forgetpasswordLK = new System.Windows.Forms.LinkLabel();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.searchBT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(293, 218);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(92, 28);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username >";
            // 
            // forgetpasswordLK
            // 
            this.forgetpasswordLK.ActiveLinkColor = System.Drawing.Color.Orange;
            this.forgetpasswordLK.AutoSize = true;
            this.forgetpasswordLK.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forgetpasswordLK.LinkColor = System.Drawing.Color.Yellow;
            this.forgetpasswordLK.Location = new System.Drawing.Point(299, 185);
            this.forgetpasswordLK.Name = "forgetpasswordLK";
            this.forgetpasswordLK.Size = new System.Drawing.Size(87, 15);
            this.forgetpasswordLK.TabIndex = 2;
            this.forgetpasswordLK.TabStop = true;
            this.forgetpasswordLK.Text = "Forget password?";
            this.forgetpasswordLK.VisitedLinkColor = System.Drawing.Color.Orange;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(257, 131);
            this.username.MaxLength = 100;
            this.username.Name = "username";
            this.username.PasswordChar = '●';
            this.username.Size = new System.Drawing.Size(124, 18);
            this.username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password >";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(257, 166);
            this.password.MaxLength = 100;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(124, 18);
            this.password.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(155, 218);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(132, 28);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register database";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // searchBT
            // 
            this.searchBT.BackColor = System.Drawing.Color.Black;
            this.searchBT.Location = new System.Drawing.Point(73, 85);
            this.searchBT.Name = "searchBT";
            this.searchBT.Size = new System.Drawing.Size(137, 28);
            this.searchBT.TabIndex = 7;
            this.searchBT.Text = "Select database >";
            this.searchBT.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(216, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(221, 25);
            this.textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Manager_Forms.Properties.Resources.cat_eyes;
            this.pictureBox1.Location = new System.Drawing.Point(160, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchBT);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.forgetpasswordLK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private Label label1;
        private LinkLabel forgetpasswordLK;
        private TextBox username;
        private Label label2;
        private TextBox password;
        private Button registerButton;
        private Button searchBT;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}