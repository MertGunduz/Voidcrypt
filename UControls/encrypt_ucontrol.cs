using System;
using System.Text;
using System.Windows.Forms;

namespace Voidcrypt.User_Controls
{
    public partial class encrypt_ucontrol : UserControl
    {
        // Text Data
        string normalText;
        string encryptedText;

        public encrypt_ucontrol()
        {
            InitializeComponent();
        }

        private void EncryptToVoidLangButton_Click(object sender, EventArgs e)
        {
            // Gets The Normal Text & Assigns It
            normalText = regular_textbox.Text;

            // Divides The String To Char & Converts It Into ASCII (8 Bits (0-255))
            byte[] encryptedBits = ASCIIEncoding.ASCII.GetBytes(normalText);

            // BASE64 Algorithm (Divides The Bits Into 6 (111111-000000))
            encryptedText = Convert.ToBase64String(encryptedBits);

            // Writes The Encrypted Data
            encrypted_textbox.Text = encryptedText;
        }
    }
}
