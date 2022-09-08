using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_Forms
{
    public partial class Form4 : Form
    {
        Thread? nt;
        private string? generatedPassword;
        public Form4()
        {
            InitializeComponent();
        }

        public void GoToPasswordsScreen()
        {
            this.Close();
            nt = new Thread(OpenPasswordsWindow);
            nt.SetApartmentState(ApartmentState.STA);            
            nt.Start();
        }

        private void OpenPasswordsWindow()
        {
            Application.Run(new Form3());
        }

        private int TurnFalseOnZero(int charQtt, bool checkBoxValue) 
        {
            if (checkBoxValue)
            {
                return charQtt;
            } 
            else
            {
                return 0;
            }
        }

        private void passwordSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            charQttLabel.Text = Convert.ToString(passwordSizeTrackBar.Value);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int charQtt;
                if (lettersCheckBox.Checked == false && upperLettersCheckBox.Checked == false && symbolsCheckBox.Checked == false && numbersCheckBox.Checked == false)
                {
                    MessageBox.Show("Mark at least one type of char.");
                }
                else
                {
                    charQtt = passwordSizeTrackBar.Value;
                    string letters = Password_Manager.Password.LetterGen(TurnFalseOnZero(charQtt, lettersCheckBox.Checked));
                    string upperLetters = Password_Manager.Password.UpperLetterGen(TurnFalseOnZero(charQtt, upperLettersCheckBox.Checked));
                    string symbols = Password_Manager.Password.SymbolsGen(TurnFalseOnZero(charQtt, symbolsCheckBox.Checked));
                    string numbers = Password_Manager.Password.NumGen(TurnFalseOnZero(charQtt, numbersCheckBox.Checked));
                    generatedPassword = Password_Manager.Password.ShuflePassword(charQtt, letters, numbers, upperLetters, symbols);
                    passwordTextBox.Text = generatedPassword;

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Unexpected error in generateButton_Click: {ex.Message}");
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedPassword);
        }

        public void addListButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tittleTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty)
                {                  
                    MessageBox.Show("Tittle and password can't be null.");
                }
                else
                {
                    string toEnconde = tittleTextBox.Text + " [" + loginTextBox.Text + ']' + " = " + generatedPassword;
                    string encodedString = Password_Manager.Database.EncodeData(toEnconde);
                    using (StreamWriter textFile = File.AppendText(Form1.GetPath))
                    {
                        textFile.Write(encodedString);
                    }
                    GoToPasswordsScreen();                    
                    this.Close();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
