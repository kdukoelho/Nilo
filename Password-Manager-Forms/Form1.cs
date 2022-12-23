namespace Password_Manager_Forms
{
    public partial class Form1 : Form
    {
        private Thread? nt;
        private static string? path;
        private int loginAttempts = 0;
        public Form1(string filePath)
        {            
            try
            {
                InitializeComponent();
                if (filePath != String.Empty)
                {
                    pathTextBox.Text = filePath;
                    path = filePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in Form1 constructor: {ex.Message}");
            }
        }

        private void GoToRegisterScreen()
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

        private void GoToPasswordsScreen()
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
                StreamReader textFile = new StreamReader(path);
                string? line = textFile.ReadLine();                
                textFile.Close();
                if (line != null)
                {
                    int backslashIndex = line.IndexOf(@"\");
                    string password = backslashIndex <= 0 ? line : line.Substring(0, backslashIndex);
                    return password;
                }
                else
                {
                    return "Database not found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in ReadPasswordLine: {ex.Message}");
                return String.Empty;
            }
        }

        private void LoginAction()
        {
            try
            {
                if (path != null)
                {
                    string passwordReader = ReadPassword(path);
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
                MessageBox.Show($"Unexpected error in LoginAction: {ex.Message}");
            }
        }
        public static string GetPath
        {
            get
            {
                if (path != null) { return path; }
                else
                {
                    throw new ArgumentNullException("Path is null.");
                }
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
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = openFileDialog.FileName;
                    path = openFileDialog.FileName;
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
                LoginAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in loginButton_Click {ex.Message}");
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginAction();
            }
        }
    }
}