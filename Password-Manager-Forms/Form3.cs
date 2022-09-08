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
        public Form3()
        {
            InitializeComponent();
            LoadListBox();
        }

        private void OpenPasswordGeneratorForm()
        {
            Application.Run(new Form4());
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
                List<string> passwordsList = new List<string>();
                string[] linesArray = File.ReadAllLines(Form1.GetPath);
                if (linesArray.Length > 0)
                {
                    for (int i = 1; i < linesArray.Length; i++)
                    {
                        string decodedPass = Password_Manager.Database.DecodeData(linesArray[i]);
                        passwordsList.Add(decodedPass);
                    }
                    passwordsListBox.DataSource = passwordsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexepected error in LoadListBox: {ex.Message}");
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoToPasswordGeneratorScreen();
        }
    }
}
