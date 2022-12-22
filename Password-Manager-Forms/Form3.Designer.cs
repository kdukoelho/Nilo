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
            this.passwordsListBox = new System.Windows.Forms.ListBox();
            this.addPasswordsButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copyInstructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordsListBox
            // 
            this.passwordsListBox.BackColor = System.Drawing.Color.DimGray;
            this.passwordsListBox.FormattingEnabled = true;
            this.passwordsListBox.ItemHeight = 23;
            this.passwordsListBox.Location = new System.Drawing.Point(203, 47);
            this.passwordsListBox.Name = "passwordsListBox";
            this.passwordsListBox.Size = new System.Drawing.Size(321, 188);
            this.passwordsListBox.TabIndex = 0;
            this.passwordsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordsListBox_MouseClick);
            this.passwordsListBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // addPasswordsButton
            // 
            this.addPasswordsButton.BackColor = System.Drawing.Color.Black;
            this.addPasswordsButton.ForeColor = System.Drawing.Color.White;
            this.addPasswordsButton.Location = new System.Drawing.Point(16, 103);
            this.addPasswordsButton.Name = "addPasswordsButton";
            this.addPasswordsButton.Size = new System.Drawing.Size(170, 35);
            this.addPasswordsButton.TabIndex = 1;
            this.addPasswordsButton.Text = "Add Passwords";
            this.addPasswordsButton.UseVisualStyleBackColor = false;
            this.addPasswordsButton.Click += new System.EventHandler(this.addPasswordsButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Black;
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(104, 152);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(82, 35);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Black;
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(16, 152);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(82, 35);
            this.changeButton.TabIndex = 3;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Manager_Forms.Properties.Resources.cat_eyes;
            this.pictureBox1.Location = new System.Drawing.Point(13, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(375, 12);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(149, 31);
            this.groupComboBox.TabIndex = 12;
            this.groupComboBox.Text = "All";
            this.groupComboBox.TextChanged += new System.EventHandler(this.groupComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Group:";
            // 
            // copyInstructionLabel
            // 
            this.copyInstructionLabel.AutoSize = true;
            this.copyInstructionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.copyInstructionLabel.Location = new System.Drawing.Point(244, 240);
            this.copyInstructionLabel.Name = "copyInstructionLabel";
            this.copyInstructionLabel.Size = new System.Drawing.Size(244, 23);
            this.copyInstructionLabel.TabIndex = 14;
            this.copyInstructionLabel.Text = "Double click to copy password";
            this.copyInstructionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 269);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addPasswordsButton);
            this.Controls.Add(this.passwordsListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyInstructionLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PASSWORDS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addPasswordsButton;
        private Button removeButton;
        private Button changeButton;
        private PictureBox pictureBox1;
        private ListBox passwordsListBox;
        private ComboBox groupComboBox;
        private Label label1;
        private Label copyInstructionLabel;
    }
}