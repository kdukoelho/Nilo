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
        List<List<string>> groupsList = new List<List<string>>();
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
                MessageBox.Show($"Unexpected error in goToLoginScreen: {ex.Message}");
            }
        }

        public void LoadListBox()
        {
            try
            {
                string[] linesArray = File.ReadAllLines(filePath);
                if (linesArray.Length > 0)
                {
                    for (int i = 1; i < linesArray.Length; i++)
                    {
                        string decodedPass = Password_Manager.Database.DecodeData(linesArray[i]);
                        //int indexSquareBracket = decodedPass.IndexOf("]");
                        //string group = decodedPass.Substring(1, indexSquareBracket - 1);
                        //decodedPass = decodedPass.Substring(indexSquareBracket + 1);
                        passwordsList.Add(decodedPass);
                    }
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
                    string toExcludeLine = passwordsList[index].ToString();

                    using (var fileContent = File.OpenText(filePath))
                    using (var tmpFile = new StreamWriter(path + "tmpDF.txt"))
                    {
                        string? actualLine;
                        while ((actualLine = fileContent.ReadLine()) != null)
                        {
                            actualLine = Password_Manager.Database.DecodeData(actualLine);
                            if (actualLine != toExcludeLine)
                            {
                                actualLine = Password_Manager.Database.EncodeData(actualLine);
                                tmpFile.WriteLine(actualLine);
                            }
                        }
                    }

                    File.Delete(filePath);
                    File.Move(path + "tmpDF.txt", filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in: {ex.Message}");
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            GoToPasswordGeneratorScreen();
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
