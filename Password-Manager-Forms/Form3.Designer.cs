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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lettersCB = new System.Windows.Forms.CheckBox();
            this.uLetterCB = new System.Windows.Forms.CheckBox();
            this.numbersCB = new System.Windows.Forms.CheckBox();
            this.symbolsCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(462, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 25);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character quantity:";
            // 
            // lettersCB
            // 
            this.lettersCB.AutoSize = true;
            this.lettersCB.Location = new System.Drawing.Point(305, 91);
            this.lettersCB.Name = "lettersCB";
            this.lettersCB.Size = new System.Drawing.Size(71, 23);
            this.lettersCB.TabIndex = 2;
            this.lettersCB.Text = "Letters";
            this.lettersCB.UseVisualStyleBackColor = true;
            // 
            // uLetterCB
            // 
            this.uLetterCB.AutoSize = true;
            this.uLetterCB.Location = new System.Drawing.Point(305, 132);
            this.uLetterCB.Name = "uLetterCB";
            this.uLetterCB.Size = new System.Drawing.Size(115, 23);
            this.uLetterCB.TabIndex = 3;
            this.uLetterCB.Text = "Upper Letters";
            this.uLetterCB.UseVisualStyleBackColor = true;
            // 
            // numbersCB
            // 
            this.numbersCB.AutoSize = true;
            this.numbersCB.Location = new System.Drawing.Point(435, 91);
            this.numbersCB.Name = "numbersCB";
            this.numbersCB.Size = new System.Drawing.Size(89, 23);
            this.numbersCB.TabIndex = 4;
            this.numbersCB.Text = "Numbers";
            this.numbersCB.UseVisualStyleBackColor = true;
            // 
            // symbolsCB
            // 
            this.symbolsCB.AutoSize = true;
            this.symbolsCB.Location = new System.Drawing.Point(435, 132);
            this.symbolsCB.Name = "symbolsCB";
            this.symbolsCB.Size = new System.Drawing.Size(85, 23);
            this.symbolsCB.TabIndex = 5;
            this.symbolsCB.Text = "Symbols";
            this.symbolsCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Generated password:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(462, 213);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(0, 19);
            this.password.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(309, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symbolsCB);
            this.Controls.Add(this.numbersCB);
            this.Controls.Add(this.uLetterCB);
            this.Controls.Add(this.lettersCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "PASSWORDS";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private CheckBox lettersCB;
        private CheckBox uLetterCB;
        private CheckBox numbersCB;
        private CheckBox symbolsCB;
        private Label label2;
        private Label password;
        private Button button1;
    }
}