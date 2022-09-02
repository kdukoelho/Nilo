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
            this.label4 = new System.Windows.Forms.Label();
            this.passwordSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.upperLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.lettersCheckBox = new System.Windows.Forms.CheckBox();
            this.charQttLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.addListButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.generatedPasswordLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password Size:";
            // 
            // passwordSizeTrackBar
            // 
            this.passwordSizeTrackBar.Location = new System.Drawing.Point(122, 181);
            this.passwordSizeTrackBar.Maximum = 25;
            this.passwordSizeTrackBar.Minimum = 8;
            this.passwordSizeTrackBar.Name = "passwordSizeTrackBar";
            this.passwordSizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.passwordSizeTrackBar.TabIndex = 21;
            this.passwordSizeTrackBar.Value = 8;
            this.passwordSizeTrackBar.Scroll += new System.EventHandler(this.passwordSizeTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Title:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(100, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 18);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 9);
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
            // groupTextBox
            // 
            this.groupTextBox.BackColor = System.Drawing.Color.White;
            this.groupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupTextBox.Location = new System.Drawing.Point(100, 51);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(131, 18);
            this.groupTextBox.TabIndex = 16;
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Checked = true;
            this.numbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersCheckBox.Location = new System.Drawing.Point(131, 146);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(89, 23);
            this.numbersCheckBox.TabIndex = 15;
            this.numbersCheckBox.Text = "Numbers";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperLettersCheckBox
            // 
            this.upperLettersCheckBox.AutoSize = true;
            this.upperLettersCheckBox.Checked = true;
            this.upperLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperLettersCheckBox.Location = new System.Drawing.Point(131, 117);
            this.upperLettersCheckBox.Name = "upperLettersCheckBox";
            this.upperLettersCheckBox.Size = new System.Drawing.Size(115, 23);
            this.upperLettersCheckBox.TabIndex = 14;
            this.upperLettersCheckBox.Text = "Upper Letters";
            this.upperLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Checked = true;
            this.symbolsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.symbolsCheckBox.Location = new System.Drawing.Point(37, 146);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(85, 23);
            this.symbolsCheckBox.TabIndex = 13;
            this.symbolsCheckBox.Text = "Symbols";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // lettersCheckBox
            // 
            this.lettersCheckBox.AutoSize = true;
            this.lettersCheckBox.Checked = true;
            this.lettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lettersCheckBox.Location = new System.Drawing.Point(37, 117);
            this.lettersCheckBox.Name = "lettersCheckBox";
            this.lettersCheckBox.Size = new System.Drawing.Size(71, 23);
            this.lettersCheckBox.TabIndex = 12;
            this.lettersCheckBox.Text = "Letters";
            this.lettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // charQttLabel
            // 
            this.charQttLabel.AutoSize = true;
            this.charQttLabel.Location = new System.Drawing.Point(233, 183);
            this.charQttLabel.Name = "charQttLabel";
            this.charQttLabel.Size = new System.Drawing.Size(16, 19);
            this.charQttLabel.TabIndex = 23;
            this.charQttLabel.Text = "8";
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Black;
            this.copyButton.ForeColor = System.Drawing.Color.White;
            this.copyButton.Location = new System.Drawing.Point(101, 287);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 28);
            this.copyButton.TabIndex = 24;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // addListButton
            // 
            this.addListButton.BackColor = System.Drawing.Color.Black;
            this.addListButton.ForeColor = System.Drawing.Color.White;
            this.addListButton.Location = new System.Drawing.Point(182, 287);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(75, 28);
            this.addListButton.TabIndex = 25;
            this.addListButton.Text = "Add List";
            this.addListButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(18, 287);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 28);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password:";
            // 
            // generatedPasswordLabel
            // 
            this.generatedPasswordLabel.AutoSize = true;
            this.generatedPasswordLabel.Location = new System.Drawing.Point(85, 257);
            this.generatedPasswordLabel.Name = "generatedPasswordLabel";
            this.generatedPasswordLabel.Size = new System.Drawing.Size(0, 19);
            this.generatedPasswordLabel.TabIndex = 28;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.Black;
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(93, 221);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(79, 28);
            this.generateButton.TabIndex = 29;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(269, 327);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.generatedPasswordLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addListButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.charQttLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordSizeTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.numbersCheckBox);
            this.Controls.Add(this.upperLettersCheckBox);
            this.Controls.Add(this.symbolsCheckBox);
            this.Controls.Add(this.lettersCheckBox);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PASSWORD GENERATOR";
            ((System.ComponentModel.ISupportInitialize)(this.passwordSizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TrackBar passwordSizeTrackBar;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox groupTextBox;
        private CheckBox numbersCheckBox;
        private CheckBox upperLettersCheckBox;
        private CheckBox symbolsCheckBox;
        private CheckBox lettersCheckBox;
        private Label charQttLabel;
        private Button copyButton;
        private Button addListButton;
        private Button backButton;
        private Label label5;
        private Label generatedPasswordLabel;
        private Button generateButton;
    }
}