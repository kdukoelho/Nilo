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
            this.passwordsList = passwordsList;
            this.toChangeIndex = toChangeIndex;
            InitializeComponent();
            PutElementsOnTextBox(SplitStringComponents(passwordsList, toChangeIndex));
            PutGroupsOnComboBox(GetGroups(passwordsList));
        }

        private void GoToPasswordsScreen()
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

        private string[] SplitStringComponents(List<string> passwordsList, int toChangeIndex)
        {
            string[] elementsArray = new string[4];
            if (toChangeIndex > -1)
            {
                string str = passwordsList[toChangeIndex];
                int indexCloseBracket = str.IndexOf("]");         
                int indexLastOpenBracket = str.LastIndexOf("[");
                int indexEqual = str.IndexOf("=");
                string group = str.Substring(2, indexCloseBracket - 3);
                string tittle = str.Substring(indexCloseBracket + 2, indexLastOpenBracket - indexCloseBracket - 3);
                string login = str.Substring(indexLastOpenBracket + 2, indexEqual - indexLastOpenBracket - 5);
                string password = str.Substring(indexEqual + 2);
                elementsArray[0] = group; elementsArray[1] = tittle; elementsArray[2] = login; elementsArray[3] = password;
                return elementsArray;
            }
            return elementsArray;
        }

        private void PutElementsOnTextBox(string[] elementsArray)
        {
            groupComboBox.Text = elementsArray[0];
            tittleTextBox.Text = elementsArray[1];
            loginTextBox.Text = elementsArray[2];
            passwordTextBox.Text = elementsArray[3];
        }

        public List<string> GetGroups(List<string> passwordsList)
        {
            List<string> groupsList = new List<string>();
            foreach (string str in passwordsList)
            {
                int indexCloseBracket = str.IndexOf("]");
                string group = str.Substring(2, indexCloseBracket - 3);
                groupsList.Add(group);
            }
            return groupsList.Distinct().ToList();
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

        private void ReplaceLine(string toReplaceLine, string olderLine)
        {
            try
            {
                int lastBackslashIndex = filePath.LastIndexOf(@"\");
                string path = filePath.Substring(0, lastBackslashIndex + 1);
                string fileName = filePath;
                string tmpFilePath = path + "tmpDF.txt";

                using (var fileContent = new StreamReader(filePath)) {
                    using (var tmpFile = new StreamWriter(tmpFilePath))
                    {
                        string? actualLine;
                        while ((actualLine = fileContent.ReadLine()) != null)
                        {
                            actualLine = Password_Manager.Database.DecodeData(actualLine);
                            if (actualLine == olderLine)
                            {
                                toReplaceLine = Password_Manager.Database.EncodeData(toReplaceLine);
                                tmpFile.WriteLine(toReplaceLine);
                            }
                            else
                            {
                                actualLine = Password_Manager.Database.EncodeData(actualLine);
                                tmpFile.WriteLine(actualLine);
                            }
                        }
                        tmpFile.Close();
                        fileContent.Close();
                    }
                    File.Delete(filePath);
                    File.Move(tmpFilePath, fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in ReplaceLine: {ex.Message}");
            }
        }

        private string GenerateId()
        {
            int actualId = 0;
            if (passwordsList.Count > 0)
            {                
                foreach (string line in passwordsList)
                {
                    actualId = Convert.ToInt32(line.Substring(0, line.IndexOf('[')).Replace(' ', Char.MinValue));
                }
                actualId += 1;
            }
            return Convert.ToString(actualId);
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
                    string passwordId = GenerateId();
                    string groupString = groupComboBox.Text.Length > 0 ? "[ " + groupComboBox.Text + " ] " : String.Empty;
                    string buildedString = passwordId + groupString + tittleTextBox.Text + " [ " + loginTextBox.Text + " ] " + "= " + generatedPassword;
                    string checkString = buildedString.Substring(0, buildedString.IndexOf("="));
                    foreach (string str in passwordsList) 
                    {
                        string toCompareStr = str.Substring(0, str.IndexOf("="));
                        if (checkString == toCompareStr)
                        {
                            DialogResult dialogResult = MessageBox.Show("Do you really want to change this field?", "Confirmation", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                ReplaceLine(buildedString, passwordsList[toChangeIndex]);
                            }
                        }
                    }
                    string encodedString = Password_Manager.Database.EncodeData(buildedString);
                    Password_Manager.Database.WriteLinesOnFile(encodedString, Form1.GetPath);
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
