namespace Password_Manager_Forms
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label4 = new System.Windows.Forms.Label();
            this.passwordSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tittleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.upperLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.lettersCheckBox = new System.Windows.Forms.CheckBox();
            this.charQttLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.addListButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password Size:";
            // 
            // passwordSizeTrackBar
            // 
            this.passwordSizeTrackBar.BackColor = System.Drawing.Color.Black;
            this.passwordSizeTrackBar.Location = new System.Drawing.Point(126, 201);
            this.passwordSizeTrackBar.Maximum = 51;
            this.passwordSizeTrackBar.Minimum = 8;
            this.passwordSizeTrackBar.Name = "passwordSizeTrackBar";
            this.passwordSizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.passwordSizeTrackBar.TabIndex = 7;
            this.passwordSizeTrackBar.Value = 15;
            this.passwordSizeTrackBar.Scroll += new System.EventHandler(this.passwordSizeTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tittle:";
            // 
            // tittleTextBox
            // 
            this.tittleTextBox.BackColor = System.Drawing.Color.White;
            this.tittleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tittleTextBox.ForeColor = System.Drawing.Color.Black;
            this.tittleTextBox.Location = new System.Drawing.Point(100, 83);
            this.tittleTextBox.MaxLength = 25;
            this.tittleTextBox.Name = "tittleTextBox";
            this.tittleTextBox.Size = new System.Drawing.Size(131, 18);
            this.tittleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password Generator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Group:";
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Checked = true;
            this.numbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersCheckBox.Location = new System.Drawing.Point(131, 166);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(89, 23);
            this.numbersCheckBox.TabIndex = 6;
            this.numbersCheckBox.Text = "Numbers";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperLettersCheckBox
            // 
            this.upperLettersCheckBox.AutoSize = true;
            this.upperLettersCheckBox.Checked = true;
            this.upperLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperLettersCheckBox.Location = new System.Drawing.Point(131, 137);
            this.upperLettersCheckBox.Name = "upperLettersCheckBox";
            this.upperLettersCheckBox.Size = new System.Drawing.Size(115, 23);
            this.upperLettersCheckBox.TabIndex = 4;
            this.upperLettersCheckBox.Text = "Upper Letters";
            this.upperLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Checked = true;
            this.symbolsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.symbolsCheckBox.Location = new System.Drawing.Point(37, 166);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(85, 23);
            this.symbolsCheckBox.TabIndex = 5;
            this.symbolsCheckBox.Text = "Symbols";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // lettersCheckBox
            // 
            this.lettersCheckBox.AutoSize = true;
            this.lettersCheckBox.Checked = true;
            this.lettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lettersCheckBox.Location = new System.Drawing.Point(37, 137);
            this.lettersCheckBox.Name = "lettersCheckBox";
            this.lettersCheckBox.Size = new System.Drawing.Size(71, 23);
            this.lettersCheckBox.TabIndex = 3;
            this.lettersCheckBox.Text = "Letters";
            this.lettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // charQttLabel
            // 
            this.charQttLabel.AutoSize = true;
            this.charQttLabel.Location = new System.Drawing.Point(233, 203);
            this.charQttLabel.Name = "charQttLabel";
            this.charQttLabel.Size = new System.Drawing.Size(23, 19);
            this.charQttLabel.TabIndex = 23;
            this.charQttLabel.Text = "15";
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Black;
            this.copyButton.ForeColor = System.Drawing.Color.White;
            this.copyButton.Location = new System.Drawing.Point(97, 311);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 28);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // addListButton
            // 
            this.addListButton.BackColor = System.Drawing.Color.Black;
            this.addListButton.ForeColor = System.Drawing.Color.White;
            this.addListButton.Location = new System.Drawing.Point(179, 311);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(75, 28);
            this.addListButton.TabIndex = 9;
            this.addListButton.Text = "Add List";
            this.addListButton.UseVisualStyleBackColor = false;
            this.addListButton.Click += new System.EventHandler(this.addListButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password:";
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.Black;
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(79, 241);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(107, 33);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Black;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(92, 281);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(154, 18);
            this.passwordTextBox.TabIndex = 30;
            // 
            // groupComboBox
            // 
            this.groupComboBox.BackColor = System.Drawing.Color.White;
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupComboBox.ForeColor = System.Drawing.Color.Black;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(100, 47);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(131, 26);
            this.groupComboBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.Location = new System.Drawing.Point(100, 110);
            this.loginTextBox.MaxLength = 80;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(131, 18);
            this.loginTextBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(16, 311);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 28);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(269, 351);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addListButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.charQttLabel);
            this.Controls.Add(this.passwordSizeTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tittleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numbersCheckBox);
            this.Controls.Add(this.upperLettersCheckBox);
            this.Controls.Add(this.symbolsCheckBox);
            this.Controls.Add(this.lettersCheckBox);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nilo - Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordSizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TrackBar passwordSizeTrackBar;
        private Label label3;
        private TextBox tittleTextBox;
        private Label label2;
        private Label label1;
        private CheckBox numbersCheckBox;
        private CheckBox upperLettersCheckBox;
        private CheckBox symbolsCheckBox;
        private CheckBox lettersCheckBox;
        private Label charQttLabel;
        private Button copyButton;
        private Button addListButton;
        private Label label5;
        private Button generateButton;
        private TextBox passwordTextBox;
        private ComboBox groupComboBox;
        private Label label6;
        private TextBox loginTextBox;
        private Button backButton;
    }
}