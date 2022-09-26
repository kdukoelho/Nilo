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
    public partial class Form3 : Form
    {
        Thread? nt;
        string filePath = Form1.GetPath;
        List<string> passwordsList = new List<string>();
        List<string> groupsList = new List<string>();
        public Form3()
        {
            InitializeComponent();
            LoadListBox();
        }

        private void OpenPasswordGeneratorForm()
        {
            Application.Run(new Form4(passwordsList));
        }

        private void GoToPasswordGeneratorScreen()
        {
            try
            {
                nt = new Thread(OpenPasswordGeneratorForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in GoToLoginScreen: {ex.Message}");
            }
        }

        private void LoadListBox()
        {
            try
            {
                string[] linesArray = File.ReadAllLines(filePath);
                if (linesArray.Length > 0)
                {
                    for (int i = 1; i < linesArray.Length; i++)
                    {
                        string decodedString = Password_Manager.Database.DecodeData(linesArray[i]);                                               
                        passwordsList.Add(decodedString);
                    }
                    passwordsList = ClearEmptyLines(passwordsList);
                    foreach (string str in passwordsList)
                    {
                        passwordsListBox.Items.Add(str);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexepected error in LoadListBox: {ex.Message}");
            }
        }

        private void DeleteLine(int index)
        {
            try
            {
                int lastBackslashIndex = filePath.LastIndexOf(@"\"); 
                string path = filePath.Substring(0, lastBackslashIndex + 1);

                if (index != -1)
                {
                    string? toExcludeLine = passwordsListBox.Items[index].ToString();    

                    using (var fileContent = File.OpenText(filePath))
                    using (var tmpFile = new StreamWriter(path + "tmpDF.txt"))
                    {
                        string? actualLine;
                        while ((actualLine = fileContent.ReadLine()) != null)
                        {
                            actualLine = Password_Manager.Database.DecodeData(actualLine);
                            if (actualLine != toExcludeLine && actualLine != "")
                            {
                                actualLine = Password_Manager.Database.EncodeData(actualLine);
                                tmpFile.WriteLine(actualLine);
                            }                            
                        }
                    }

                    passwordsList = ClearEmptyLines(passwordsList);
                    File.Delete(filePath);
                    File.Move(path + "tmpDF.txt", filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in: {ex.Message}");
            }
        }
        
        private static List<string> ClearEmptyLines(List<string> list)
        {
                List<string> tmpList = new List<string>();                
                if (list != null)
                {                    
                    foreach (string line in list)
                    {
                        if (line != "")
                        {
                            tmpList.Add(line);
                        }
                    }                    
                }
                return tmpList;
        }

        private void addPasswordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                GoToPasswordGeneratorScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected erro in addPasswordsButton_Click: {ex.Message}");
            }
        }

        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = passwordsListBox.SelectedIndex;
                if (index > -1)
                {
                    string? password = passwordsListBox.Items[index].ToString();
                    if (password != null)
                    {
                        int indexEqualOperator = password.LastIndexOf("=") + 1;
                        password = password.Substring(indexEqualOperator);
                        Clipboard.SetText(password);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in doubleClickTextBox: {ex.Message}");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = passwordsListBox.SelectedIndex;
                if (selectedIndex > -1)
                {
                    DeleteLine(selectedIndex);
                    passwordsListBox.Items.RemoveAt(selectedIndex);
                    passwordsList.RemoveAt(selectedIndex);                                        
                }
                else
                {
                    MessageBox.Show("Select a item.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in removeButton_Click: {ex.Message}");
            }
        }
    }
}
