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
        public Form2()
        {
            InitializeComponent();
        }

        private void openLoginForm()
        {
            Application.Run(new Form1());
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(openLoginForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}
