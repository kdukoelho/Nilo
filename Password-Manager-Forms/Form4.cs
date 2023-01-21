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
        List<string> passwordsList;
        string filePath = Form1.GetPath;
        private string? generatedPassword;
        int toChangeIndex;        
        public Form4(List<string> passwordsList, int toChangeIndex = -1)
        {
            try
            {
                this.passwordsList = passwordsList;
                this.toChangeIndex = toChangeIndex;                
                InitializeComponent();                
                PutElementsOnTextBox();
                PutGroupsOnComboBox(GetGroups(passwordsList));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at Form4 Constructor: {ex}");
            }
        }

        // Functions.

        private void GoToPasswordsScreen()
        {
            try 
            {
                this.Close();
                nt = new Thread(OpenPasswordsWindow);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at GoToPasswordsScreen: {ex}");
            }
            
        }

        private void OpenPasswordsWindow()
        {
            try
            {
                Application.Run(new Form3());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at OpenPasswordsWindow: {ex}");
            }
        }

        private void PutElementsOnTextBox()
        {
            try
            {
                if (toChangeIndex > -1)
                {
                    addListButton.Text = "Change";
                    Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(passwordsList[toChangeIndex]);
                    string[] elementsArray = strMpl.SplitElements();
                    groupComboBox.Text = elementsArray[1];
                    tittleTextBox.Text = elementsArray[2];
                    loginTextBox.Text = elementsArray[3];
                    passwordTextBox.Text = elementsArray[4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at PutElementsOnTextBox: {ex}");
            }
            
        }

        public List<string> GetGroups(List<string> passwordsList)
        {
            try
            {
                List<string> groupsList = new List<string>();

                foreach (string line in passwordsList)
                {
                    Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(line);
                    string group = strMpl.GetGroup();
                    groupsList.Add(group);
                }
                return groupsList.Distinct().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at GetGroups: {ex}");
                List<string> emptyList = new List<string>;
                return emptyList;
            }
            
        }

        private void PutGroupsOnComboBox(List<string> groupsList)
        {
            try
            {
                foreach (string group in groupsList)
                {                    
                    groupComboBox.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpeceted error in PutGroupsOnComboBox {ex.Message}");
            }
        }       

        private void AddLine(string toEncode)
        {
            string encodedString = Password_Manager.Database.EncodeData(toEncode);
            using (StreamWriter textFile = File.AppendText(Form1.GetPath))
            {
                textFile.Write(encodedString);
            }
        }

        private int GenerateId()
        {
            int actualId, nextId = 0;
            int biggiestId = 0;           
            if (passwordsList.Count > 0)
            {                
                foreach (string line in passwordsList)
                {
                    Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(line);
                    actualId = Convert.ToInt32(strMpl.GetId());
                    biggiestId = actualId > biggiestId ? actualId : biggiestId;                   
                }
                nextId = biggiestId + 1;
            }
            return nextId;
        }
        private string GenerateBuildedString(int actualId)
        {
            int passwordId = actualId == -1 ? GenerateId() : actualId;
            string groupString = groupComboBox.Text.Length > 0 ? " [ " + groupComboBox.Text + "] " : String.Empty;
            string buildedString = passwordId + " - " + groupString + tittleTextBox.Text + " [ " + loginTextBox.Text + " ] " + "= " + passwordTextBox.Text;
            return buildedString;
        }

        private int TurnFalseOnZero(int charQtt, bool checkBoxValue)
        {
            try
            {
                return checkBoxValue ? charQtt : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at TurnFalseOnZero: {ex}");
                return 0;
            }
        }

        private void GeneratePassword()
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
                MessageBox.Show($"Unexpected error at GeneratePassword: {ex}");
            }
        }

        private void ChangeLine()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to change this field?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(passwordsList[toChangeIndex]);
                    Form3 frm3 = new Form3();
                    frm3.RemoveLine(passwordsList, toChangeIndex);
                    int actualPasswordId = Convert.ToInt32(strMpl.GetId());
                    AddLine(GenerateBuildedString(actualPasswordId));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at ChangeLine: {ex}");
            }
        }

        // Events.

        private void passwordSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            charQttLabel.Text = Convert.ToString(passwordSizeTrackBar.Value);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratePassword();
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
                    if (toChangeIndex > -1)
                    {
                        ChangeLine();                 
                    }
                    else
                    {
                        AddLine(GenerateBuildedString(-1));
                    }
                    GoToPasswordsScreen();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in addListButton_Click: {ex}");
            }            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToPasswordsScreen();
        }
    }
}
