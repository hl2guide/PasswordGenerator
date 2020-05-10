using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        // Variables
        private int passwordLength = 31;
        private string passwordText = "";

        // Constructor
        public MainForm()
        {
            InitializeComponent();
            Text = "PasswordGenerator 1.0";
            trackBarLength.Value = passwordLength;
            labelLength.Text = "Length: " + passwordLength.ToString();
        }

        // Scroll on main trackBar
        private void trackBarLength_Scroll(object sender, EventArgs e)
        {
            passwordLength = trackBarLength.Value;
            labelLength.Text = "Length: " + passwordLength.ToString();
            passwordText = GeneratePassword(passwordLength);
            textBoxGeneratedPassword.Text = passwordText;
            buttonCopyPassword.Enabled = true;
        }

        // Click on "Generate Password" button
        private async void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            passwordText = GeneratePassword(passwordLength);
            textBoxGeneratedPassword.Text = passwordText;
            buttonCopyPassword.Enabled = true;
            buttonGeneratePassword.Text = "Generated";
            await Task.Delay(2000);
            buttonGeneratePassword.Text = "&Generate";
        }

        // Click on "Copy Password" button
        private async void buttonCopyPassword_Click(object sender, EventArgs e)
        {
            CopyToWindowsClipboard(passwordText);
            buttonCopyPassword.Text = "Copied";
            await Task.Delay(2000);
            buttonCopyPassword.Text = "&Copy";

        }

        // Generates a password
        private static string GeneratePassword(int length = 12)
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
        }

        // Copies a generated password to the Windows Clipboard
        private void CopyToWindowsClipboard(string password)
        {
            Clipboard.SetText(password);
        }

        private void textBoxGeneratedPassword_Enter(object sender, EventArgs e)
        {
            textBoxGeneratedPassword.SelectAll();
        }

        private void textBoxGeneratedPassword_Click(object sender, EventArgs e)
        {
            textBoxGeneratedPassword.SelectAll();
        }
    }
}