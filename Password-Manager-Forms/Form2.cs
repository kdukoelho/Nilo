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
        private string? path;


        public Form2()
        {
            InitializeComponent();
        }

        private void goToLoginScreen()
        {
            try
            {
                this.Close();
                nt = new Thread(openLoginForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in goToLoginScreen: {ex.Message}");
            }
        }

        private void openLoginForm()
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
                    if (fileName.Text == null) { fileName.Text = "Safes";  }
                    textBox.Text = folderBrowserDialog.SelectedPath;
                    this.path = folderBrowserDialog.SelectedPath + @"\" + fileName.Text + ".txt";
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
                goToLoginScreen();
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
                else if (password.Text != Rpassword.Text) 
                { 
                    MessageBox.Show("Passwords doesnt match."); 
                }
                else
                {
                    if (path != null)
                    {
                        string createDb = Password_Manager.Database.CreateDatabase(password.Text, path);
                        if (createDb == "true")
                        {
                            password.Text = String.Empty;
                            this.Close();
                            goToLoginScreen();
                        }
                        else
                        {
                            MessageBox.Show(createDb);
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
