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
       
        private void backButton_Click(object sender, EventArgs e)
        {
            GoToPasswordsScreen();
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
                    string generatedPassword = Password_Manager.Password.ShuflePassword(charQtt, letters, numbers, upperLetters, symbols);
                    generatedPasswordLabel.Text = generatedPassword;

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Unexpected error in generateButton_Click: {ex.Message}");
            }
        }
    }
}
