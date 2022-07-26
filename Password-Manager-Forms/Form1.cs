namespace Password_Manager_Forms
{
    public partial class Form1 : Form
    {
        private Thread? nt;
        public Form1() => InitializeComponent();

        private void openRegisterWindow()
        {
            Application.Run(new Form2());
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(openRegisterWindow);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }        
    }
}