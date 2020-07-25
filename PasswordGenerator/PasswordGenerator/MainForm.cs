using System;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Version: 1.0B Fixes and Changes:
 * - Uses a more flexible and functional password generation method
 * 
 * Version: 1.0A Fixes and Changes:
 * - The password result was changed from a TextBox to a Label
 * - The window's title shows more info (status and number of characters)
 *
*/

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        // Variables
        private int passwordLength = 31;
        private string passwordText = "", appName = "PasswordGenerator", appVersion = "1.0B";

        // Constructor
        public MainForm()
        {
            InitializeComponent();
            Text = appName + " " + appVersion;
            trackBarLength.Value = passwordLength;
            labelLength.Text = "Length: " + passwordLength.ToString();
            labelPassword.Text = PasswordGenerator.Generate(passwordLength, (passwordLength / 2), true, true, true, true);
            //labelPassword.Text = GeneratePassword(passwordLength);
        }

        // Scroll on main trackBar
        private void trackBarLength_Scroll(object sender, EventArgs e)
        {
            passwordLength = trackBarLength.Value;
            labelLength.Text = "Length: " + passwordLength.ToString();
            passwordText = PasswordGenerator.Generate(passwordLength, (passwordLength / 2), true, true, true, true);
            //passwordText = GeneratePassword(passwordLength);
            labelPassword.Text = passwordText;
            buttonCopyPassword.Enabled = true;
            Text = appName + " " + appVersion + " - Generated a Password (" + passwordLength + " characters)";
            //await Task.Delay(5000);
            //Text = appName + " " + appVersion;
        }

        // Click on "Generate Password" button
        private async void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            passwordText = PasswordGenerator.Generate(passwordLength, (passwordLength / 2), true, true, true, true);
            // passwordText = GeneratePassword(passwordLength);
            labelPassword.Text = passwordText;
            buttonCopyPassword.Enabled = true;
            buttonGeneratePassword.Text = "Generated";
            Text = appName + " " + appVersion + " - Generated a Password (" + passwordLength + " characters)";
            await Task.Delay(5000);
            buttonGeneratePassword.Text = "&Generate";
            //Text = appName + " " + appVersion;
        }

        // Click on "Copy Password" button
        private async void buttonCopyPassword_Click(object sender, EventArgs e)
        {
            CopyToWindowsClipboard(passwordText);
            buttonCopyPassword.Text = "Copied";
            Text = appName + " " + appVersion + " - Copied the Password (" + passwordLength + " characters)";
            await Task.Delay(5000);
            buttonCopyPassword.Text = "&Copy";
            //Text = appName + " " + appVersion;

        }

        // Generates a password
        /*private static string GeneratePassword(int length = 12)
        {
            // Creates a string of characters, numbers, special characters that are allowed in the password
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            Random random = new Random();
            // RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

            // Selects one random character at a time from the string
            // and creates an array of chars
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }*/

        // Copies a generated password to the Windows Clipboard
        private void CopyToWindowsClipboard(string password)
        {
            Clipboard.SetText(password);
        }
    }
}