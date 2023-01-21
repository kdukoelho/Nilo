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
    public partial class Form2 : Form
    {
        private Thread? nt;
        private static string? path;


        public Form2()
        {
            try
            {
                InitializeComponent();
            }            
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at Form2 Constructor: {ex}");
            }
        }

        // Functions.

        private void OpenLoginForm()
        {
            try
            {
                Application.Run(new Form1(String.Empty));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in OpenLoginForm: {ex}");
            }
        }

        private void OpenLoginForm(string filePath)
        {
            try
            {
                Application.Run(new Form1(filePath));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in OpenLoginForm(Overloaded): {ex}");
            }
        }

        private void GoToLoginScreen()
        {
            try
            {
                this.Close();
                nt = new Thread(OpenLoginForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in GoToLoginScreen: {ex}");
            }
        }

        private void GoToLoginScreen(string filePath)
        {
            try
            {
                this.Close();
                nt = new Thread(()=>OpenLoginForm(filePath));
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in GoToLoginScreen(Overloaded): {ex}");
            }
        }
        
        private void SaveDatabasePath()
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = folderBrowserDialog.SelectedPath;
                    path = folderBrowserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in SaveDatabasePath: {ex}");
            }
        }

        private void CreateDatabase()
        {
            try
            {
                string filePath = path + @"\" + fileName.Text + ".txt";
                string createDatabaseConfirmation = Password_Manager.Database.CreateDatabase(password.Text, filePath);
                if (createDatabaseConfirmation == "true")
                {
                    password.Text = String.Empty;
                    GoToLoginScreen(filePath);
                }
                else
                {
                    MessageBox.Show(createDatabaseConfirmation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in CreateDatabase: {ex}");
            }
        }

        // Events.

        private void saveDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDatabasePath();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in saveDatabaseButton_Click: {ex}");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        { 
            try
            {
                GoToLoginScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in cancelButton_Click: {ex}");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {           
                if (password.Text == String.Empty || Rpassword.Text == String.Empty)
                {
                    MessageBox.Show("Please fill all fields.");
                }
                else if (fileName.Text == String.Empty)
                {
                    MessageBox.Show("Choose a name to the database.");
                }
                else if (password.Text != Rpassword.Text) 
                { 
                    MessageBox.Show("Passwords doesnt match."); 
                }
                else
                {
                    if (path != null)
                    {
                        CreateDatabase();
                    }
                    else
                    {
                        MessageBox.Show("Error in registerButton_Click: No file selected.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in registerButton_Click: {ex}");
            }
        }      
    }
}
