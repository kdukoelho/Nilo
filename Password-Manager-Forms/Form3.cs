﻿using System;
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
            Form4 frm4 = new Form4(passwordsList);
            groupsList = frm4.GetGroups(passwordsList);
            PutGroupsOnComboBox(groupsList);
        }

        private void OpenPasswordGeneratorForm(int toChangeIndex=-1)
        {
            Application.Run(new Form4(passwordsList, toChangeIndex));
        }

        private void GoToPasswordGeneratorScreen(int toChangeIndex=-1)
        {
            try
            {
                nt = new Thread(()=>OpenPasswordGeneratorForm(toChangeIndex));
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in GoToLoginScreen: {ex.Message}");
            }
        }
        private void PutGroupsOnComboBox(List<string> list) 
        {
        try
            {
                foreach (string group in list)
                {
                    groupComboBox.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in PutGroupsOnComboBox {ex}");
            }
        }
        private void LoadListBox()
        {
            try
            {
                groupComboBox.Items.Add("All");
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
                        int indexFirstClosedBracket = str.IndexOf(']');
                        string strWithoutGroup = str.Substring(indexFirstClosedBracket + 2);
                        passwordsListBox.Items.Add(strWithoutGroup);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexepected error in LoadListBox: {ex.Message}");
            }
        }

        private void DeleteLine(string toExcludeLine)
        {
            try
            {
                int lastBackslashIndex = filePath.LastIndexOf(@"\"); 
                string path = filePath.Substring(0, lastBackslashIndex + 1);

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
                    tmpFile.Close();
                }
                passwordsList = ClearEmptyLines(passwordsList);
                File.Delete(filePath);
                File.Move(path + "tmpDF.txt", filePath);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in DeleteLine: {ex.Message}");
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

        private void textBox_DoubleClick(object sender, EventArgs e) // With a double click on any item in the list, that password will go to the clipboard.
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
                string? textBoxString = passwordsListBox.Items[selectedIndex].ToString();
                string[] groups = new string[passwordsList.Count];
                if (selectedIndex > -1)
                {
                    foreach (string password in passwordsList)
                    {
                        int indexClosedBracket = password.IndexOf("]");
                        string groupString = password.Substring(2, indexClosedBracket - 3);
                        string strWithoutGroup = password.Substring(indexClosedBracket + 2);
                        if (strWithoutGroup == textBoxString)
                        {
                            DeleteLine(password);
                            passwordsListBox.Items.Remove(strWithoutGroup);
                            passwordsList.Remove(password);
                            Form4 frm4 = new Form4(passwordsList);
                            groupsList = frm4.GetGroups(passwordsList);
                            if (!groupsList.Contains(groupString))
                            {
                                groupComboBox.Items.Remove(groupString);
                            }
                                
                        } 
                    }                    
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


        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = passwordsListBox.SelectedIndex;
                if (selectedIndex > -1)
                {
                    GoToPasswordGeneratorScreen(selectedIndex);                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in changeButton: {ex.Message}");
            }
        }

        private void groupComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {                
                passwordsListBox.Items.Clear();
                if (passwordsList.Count > 0)
                {
                    for (int i = 0; i < passwordsList.Count; i++)
                    {
                        string password = passwordsList[i];
                        int indexClosedBracket = password.IndexOf("]");                        
                        string groupString = password.Substring(2, indexClosedBracket - 3);
                        string strWithoutGroup = password.Substring(indexClosedBracket + 2);
                        if (groupComboBox.Text == groupString)
                        {                            
                            passwordsListBox.Items.Add(strWithoutGroup);
                        }
                        else if (groupComboBox.Text == "All") 
                        {
                            passwordsListBox.Items.Add(strWithoutGroup);
                        }
                    }
                    passwordsList = ClearEmptyLines(passwordsList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in groupComboBox_TextChanged: {ex.Message}");
            }
        }
    }
}
