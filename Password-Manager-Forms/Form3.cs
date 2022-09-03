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
        List<string> passwordsList = new List<string>();
        Thread? nt;
        public Form3()
        {
            InitializeComponent();
        }
        private void GoToPasswordGeneratorScreen()
        {
            try
            {
                this.Close();
                nt = new Thread(OpenPasswordGeneratorForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in goToLoginScreen: {ex.Message}");
            }
        }

        private void OpenPasswordGeneratorForm()
        {
            Application.Run(new Form4());
        }
        private void addComponentsInListBox()
        {

        }

        private void addComponentsInList(string element)
        {
            
        }

        private void extractStringCsv(string path= @"C:\Users\Cadu\Documents\Test")
        {
            //File.ReadLines(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoToPasswordGeneratorScreen();
        }
    }
}
