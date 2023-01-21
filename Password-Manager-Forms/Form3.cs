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
            try
            {
                InitializeComponent();
                LoadListBox();
                Form4 frm4 = new Form4(passwordsList);
                groupsList = frm4.GetGroups(passwordsList);
                PutGroupsOnComboBox(groupsList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at Form3 Constructor: {ex}");
            }
        }

        // Functions.

        private void OpenPasswordGeneratorForm(int toChangeIndex=-1)
        {
            try
            {
                Application.Run(new Form4(passwordsList, toChangeIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at OpenPasswordGeneratorForm: {ex}");
            }
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
                MessageBox.Show($"Unexpected error at GoToLoginScreen: {ex}");
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
                MessageBox.Show($"Unexpected error at PutGroupsOnComboBox {ex}");
            }
        }

        private void LoadListBox()
        {
            try
            {
                groupComboBox.Items.Add("All");
                groupComboBox.Text = "All";
                string[] linesArray = File.ReadAllLines(filePath);
                if (linesArray.Length > 0)
                {
                    for (int i = 1; i < linesArray.Length; i++)
                    {
                        string decodedString = Password_Manager.Database.DecodeData(linesArray[i]);                                               
                        passwordsList.Add(decodedString);
                    }
                    passwordsList.RemoveAll(string.IsNullOrEmpty);
                    foreach (string str in passwordsList)
                    {
                        Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(str);                        
                        passwordsListBox.Items.Add(strMpl.GetStringWithoutGroup());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexepected error at LoadListBox: {ex}");
            }
        }

        public void DeleteLine(string toExcludeLine)
        {
            try
            {
                int lastBackslashIndex = filePath.LastIndexOf(@"\"); 
                string path = filePath.Substring(0, lastBackslashIndex + 1);
                string tmpFilePath = path + "tmpNiloFile.txt";

                using (var fileContent = File.OpenText(filePath))
                using (var tmpFile = new StreamWriter(tmpFilePath))
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
                passwordsList.RemoveAll(string.IsNullOrEmpty);
                File.Delete(filePath);
                File.Move(tmpFilePath, filePath);                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at DeleteLine: {ex}");
            }
        }
        public void RemoveLine()
        {
            try
            {
                int selectedIndex = passwordsListBox.SelectedIndex;
                if (selectedIndex > -1)
                {
                    string? passwordListBoxString = passwordsListBox.Items[selectedIndex].ToString();
                    foreach (string line in passwordsList.ToList())
                    {
                        Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(line);
                        string groupString = strMpl.GetGroup();
                        string strWithoutGroup = strMpl.GetStringWithoutGroup();
                        if (strWithoutGroup == passwordListBoxString)
                        {
                            DeleteLine(line);
                            passwordsListBox.Items.Remove(strWithoutGroup); passwordsList.Remove(line);
                            Form4 frm4 = new Form4(passwordsList); groupsList = frm4.GetGroups(passwordsList);
                            if (!groupsList.Contains(groupString))
                            {
                                groupComboBox.Items.Remove(groupString);
                                groupComboBox.Text = "All";
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
                MessageBox.Show($"Unexpected error at RemoveLine: {ex}");
            }
        }

        public void RemoveLine(List<string> passwordsList, int selectedIndex)
        {
            try
            {
                if (selectedIndex > -1)
                {
                    string passwordListString = passwordsList[selectedIndex].ToString();
                    foreach (string line in passwordsList.ToList())
                    {
                        Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(line);
                        string groupString = strMpl.GetGroup();
                        if (line == passwordListString)
                        {
                            DeleteLine(line);
                            passwordsList.Remove(line);
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
            }catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at RemoveLine(Overloaded): {ex}");
            }
        }

        private void FilterByGroup()
        {
            try
            {
                passwordsListBox.Items.Clear();
                if (passwordsList.Count > 0)
                {
                    foreach (string line in passwordsList)
                    {
                        Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(line);
                        string groupString = strMpl.GetGroup();
                        string strWithoutGroup = strMpl.GetStringWithoutGroup();
                        if (groupComboBox.Text == groupString)
                        {
                            passwordsListBox.Items.Add(strWithoutGroup);
                        }
                        else if (groupComboBox.Text == "All")
                        {
                            passwordsListBox.Items.Add(strWithoutGroup);
                        }
                    }
                    passwordsList.RemoveAll(string.IsNullOrEmpty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at FilterByGroup: {ex}");
            }
        }
        
        private void CopyPasswordToClipboard()
        {
            try
            {
                int index = passwordsListBox.SelectedIndex;
                if (index > -1)
                {
                    string? line = passwordsListBox.Items[index].ToString();
                    if (line != null)
                    {
                        Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(line);
                        Clipboard.SetText(strMpl.GetPassword());
                        copyInstructionLabel.Text = "Password copied to clipboard";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at CopyPasswordToClipboard: {ex}");
            }
        }

        // Events.

        private void addPasswordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                GoToPasswordGeneratorScreen(-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at addPasswordsButton_Click: {ex.Message}");
            }
        }

        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CopyPasswordToClipboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at textBox_DoubleClick: {ex}");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at removeButton_Click: {ex}");
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
                MessageBox.Show($"Unexpected error at changeButton_Click: {ex}");
            }
        }

        private void groupComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterByGroup();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at groupComboBox_TextChanged: {ex.Message}");
            }
        }

        private void passwordsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (copyInstructionLabel.Text == "Password copied to clipboard") { copyInstructionLabel.Text = "Double click to copy password"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in passwordsListBox_MouseClick: {ex.Message}");
            }
        }

        private void copyInstructionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
