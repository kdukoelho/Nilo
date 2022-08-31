namespace Password_Manager_Forms
{
    public partial class Form1 : Form
    {
        private Thread? nt;
        private string? path;
        private int loginAttempts = 0;
        public Form1() => InitializeComponent();

        public void GoToRegisterScreen()
        {
            this.Close();
            nt = new Thread(OpenRegisterWindow);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void OpenRegisterWindow()
        {
            Application.Run(new Form2());
        }

        public void GoToPasswordsScreen()
        {
            this.Close();
            nt = new Thread(OpenPasswordsWindow);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void OpenPasswordsWindow()
        {
            Application.Run(new Form3());
        }

        private string ReadPassword(string path)
        {
            try 
            {
                StreamReader streamReader = new StreamReader(path);
                
                string? line = streamReader.ReadLine();
                if (line != null) 
                {
                    //int indexPassBegin = line.IndexOf(@"\");
                    string? password = line.Substring(0);
                    return line;
                }
                return "Database not found.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in ReadPasswordLine: {ex.Message}");
                return String.Empty;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                GoToRegisterScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in registerButton_Click: {ex.Message}");
            }
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = openFileDialog.FileName;
                    this.path = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in searchBT_Click {ex.Message}");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.path != null)
                {
                    string passwordReader = ReadPassword(this.path);
                    if (passwordReader != "Database not found.")
                    {
                        string decodedPassword = Password_Manager.Database.DecodeData(passwordReader);
                        string userPassword = password.Text;
                        if (userPassword == decodedPassword)
                        {
                            GoToPasswordsScreen();
                        }
                        else if (userPassword != decodedPassword)
                        {
                            this.loginAttempts++;
                            if (this.loginAttempts > 3)
                            {
                                this.Close();
                            }
                            MessageBox.Show($"Wrong Password {this.loginAttempts}/3");
                        }
                    }                    
                    else
                    {
                        MessageBox.Show(passwordReader);
                    }
                }
                else
                {
                    MessageBox.Show("Select a file to continue.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in loginButton_Click {ex.Message}");
            }
        }
    }
}