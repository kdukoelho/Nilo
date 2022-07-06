namespace Password_Manager_Forms
{
    internal static class Program
    {       
        [STAThread]
        static void Main()
        {      
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}