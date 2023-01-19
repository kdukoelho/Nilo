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
        int toChangeIndex; string toChangeId;
        public Form4(List<string> passwordsList, int toChangeId = -1, int toChangeIndex = -1)
        {
            this.passwordsList = passwordsList;
            this.toChangeIndex = toChangeIndex;
            this.toChangeId = Convert.ToString(toChangeId);
            //addListButton.Text = toChangeIndex > -1 ? "Change" : "Add";
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
            string[] elementsArray = new string[5];
            if (toChangeIndex > -1)
            {
                string str = passwordsList[toChangeIndex];
                int indexMinus = str.IndexOf('-');
                int indexClosedBracket = str.IndexOf("]");         
                int indexLastOpenBracket = str.LastIndexOf("[");
                int indexEqual = str.IndexOf("=");
                string id = str.Substring(0, indexMinus - 1);
                string group = str.Substring(indexMinus + 5, indexClosedBracket - 8);
                string tittle = str.Substring(indexClosedBracket + 2, indexLastOpenBracket - indexClosedBracket - 3);
                string login = str.Substring(indexLastOpenBracket + 2, indexEqual - indexLastOpenBracket - 5);
                string password = str.Substring(indexEqual + 2);
                elementsArray[0] = id; elementsArray[1] = group; elementsArray[2] = tittle; elementsArray[3] = login; elementsArray[4] = password;
                return elementsArray;
            }
            return elementsArray;
        }

        private void PutElementsOnTextBox(string[] elementsArray)
        {
            groupComboBox.Text = elementsArray[1];
            tittleTextBox.Text = elementsArray[2];
            loginTextBox.Text = elementsArray[3];
            passwordTextBox.Text = elementsArray[4];
        }

        public List<string> GetGroups(List<string> passwordsList)
        {
            List<string> groupsList = new List<string>();
            foreach (string str in passwordsList)
            {
                int indexClosedBracket = str.IndexOf("]");
                string group = str.Substring(7, indexClosedBracket - 7);
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

        private void ReplaceLine(string toReplaceLine, string olderLineId)
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
                        string toReplaceLineId = toReplaceLine.Substring(0, toReplaceLine.IndexOf("["));
                        while ((actualLine = fileContent.ReadLine()) != null)
                        {
                            actualLine = Password_Manager.Database.DecodeData(actualLine);
                            string actualLineId = actualLine.Substring(0, actualLine.IndexOf("["));
                            if (actualLineId == olderLineId)
                            {
                                toReplaceLine = toReplaceLine.Replace(toReplaceLineId, olderLineId);                   
                                toReplaceLine = Password_Manager.Database.EncodeData(toReplaceLine);
                                tmpFile.WriteLine(toReplaceLine);
                                MessageBox.Show(actualLineId, olderLineId);
                            }
                            else
                            {
                                actualLine = Password_Manager.Database.EncodeData(actualLine);
                                tmpFile.WriteLine(actualLine);
                                MessageBox.Show($"Else: {actualLineId}, {olderLineId}");
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
                MessageBox.Show($"Unexpected error in ReplaceLine: {ex}");
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

        private string GenerateId()
        {
            int actualId = 0;
            if (passwordsList.Count > 0)
            {                
                foreach (string line in passwordsList)
                {
                    actualId = Convert.ToInt32(line.Substring(0, line.IndexOf('-')).Trim());
                }
                actualId += 1;
            }
            string finalString = $"{actualId} - ";
            return finalString;
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

        private string GenerateBuildedString(bool generateId)
        {
            string passwordId = generateId ? GenerateId() : "";
            string groupString = groupComboBox.Text.Length > 0 ? " [ " + groupComboBox.Text + " ] " : String.Empty;
            string buildedString = passwordId + groupString + tittleTextBox.Text + " [ " + loginTextBox.Text + " ] " + "= " + generatedPassword;
            return buildedString;
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
                        DialogResult dialogResult = MessageBox.Show("Do you really want to change this field?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Form3 frm3 = new Form3();
                            this.passwordsList = frm3.RemoveStringFromTextBox(passwordsList, toChangeIndex);
                            
                        }
                    }
                    else
                    {
                        AddLine(GenerateBuildedString(true));
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
