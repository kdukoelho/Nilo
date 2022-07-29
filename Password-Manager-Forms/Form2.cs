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
        private string path;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void goToLoginScreen()
        {
            this.Close();
            nt = new Thread(openLoginForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
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
                    textBox.Text = folderBrowserDialog.SelectedPath;
                    this.path = folderBrowserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
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
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {           
                if (username.Text == String.Empty || email.Text == String.Empty || keyword.Text == String.Empty || password.Text == String.Empty || Rpassword.Text == String.Empty)
                {
                    MessageBox.Show("Please fill all fields.");
                }
                else if (password.Text != Rpassword.Text) 
                { 
                    MessageBox.Show("Passwords doesnt match."); 
                }
                else if (!email.Text.Contains("@") || !email.Text.Contains(".com")) 
                {
                    MessageBox.Show("Please write a valid email.");
                }
                else
                {
                    if (Password_Manager.Database.CreateDatabase(username.Text, email.Text, keyword.Text, password.Text, path) == "true")
                    {
                        MessageBox.Show("Database created");
                        username.Text = String.Empty; email.Text = String.Empty; keyword.Text = String.Empty; password.Text = String.Empty; Rpassword.Text = String.Empty;
                        this.Close();
                        goToLoginScreen();
                    }
                    else
                    {
                        MessageBox.Show(Password_Manager.Database.CreateDatabase(username.Text, email.Text, keyword.Text, password.Text, path));
                    }
                }                           

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
        }

        
    }
}
