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
                MessageBox.Show($"Unexpected error at Form1 constructor: {ex.Message}");
            }
        }

        // Getters.

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

        // Functions.

        private void OpenRegisterWindow()
        {
            try
            {
                Application.Run(new Form2());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at OpenRegisterWindow: {ex}");
            }
        }

        private void OpenPasswordsWindow()
        {
            try
            {
                Application.Run(new Form3());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at OpenPasswordsWindow: {ex}");
            }
        }

        private void GoToPasswordsScreen()
        {
            try
            {
                this.Close();
                nt = new Thread(OpenPasswordsWindow);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at GoToPasswordsScreen: {ex}");
            }
        }

        private void GoToRegisterScreen()
        {
            try
            {
                this.Close();
                nt = new Thread(OpenRegisterWindow);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error at GoToRegisterScreen: {ex}");
            }
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
                MessageBox.Show($"Unexpected error at ReadPassword: {ex}"); return String.Empty;
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
                MessageBox.Show($"Unexpected error in LoginAction: {ex}");
            }
        }
        
        private void OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = openFileDialog.FileName;
                path = openFileDialog.FileName;
            }
        }

        // Events.

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                GoToRegisterScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in registerButton_Click: {ex}");
            }
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in searchBT_Click {ex}");
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
                MessageBox.Show($"Unexpected error in loginButton_Click {ex}");
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    LoginAction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in passwords_KeyDown{ex}");
            }
        }
    }
}