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
            InitializeComponent();
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
                MessageBox.Show($"Unexpected error in GoToLoginScreen: {ex.Message}");
            }
        }


        private void OpenLoginForm()
        {
            Application.Run(new Form1());
        }

        private void saveDatabaseButton_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Unexpected error in saveDatabaseButton_Click: {ex.Message}");
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
                MessageBox.Show($"Unexpected error in cancelButton_Click: {ex.Message}");
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
                        path = path + @"\" + fileName.Text + ".txt";
                        string createDatabaseConfirmation = Password_Manager.Database.CreateDatabase(password.Text, path);
                        if (createDatabaseConfirmation == "true")
                        {
                            password.Text = String.Empty;
                            this.Close();
                            GoToLoginScreen();
                        }
                        else
                        {
                            MessageBox.Show(createDatabaseConfirmation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error in registerButton_Click: No file selected.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in registerButton_Click: {ex.Message}");
            }
        }      
    }
}
