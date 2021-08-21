using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voidcrypt.User_Controls
{
    public partial class VoidEncryptor_UserControl : UserControl
    {
        // Text Data
        string normalText;
        string encryptedText;

        public VoidEncryptor_UserControl()
        {
            InitializeComponent();
        }

        private void NormalTextRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (NormalTextRichTextBox.Text == "***********************************************************\nNormal Text\n***********************************************************")
            {
                NormalTextRichTextBox.Clear();
            }
        }

        private void EncryptedTextRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (EncryptedTextRichTextBox.Text == "***********************************************************\nEncrypted Text\n***********************************************************")
            {
                EncryptedTextRichTextBox.Clear();
            }
        }

        private void EncryptToVoidLangButton_Click(object sender, EventArgs e)
        {
            // Gets The Normal Text & Assigns It
            normalText = NormalTextRichTextBox.Text;

            // Divides The String To Char & Converts It Into ASCII (8 Bits (0-255))
            byte[] encryptedBits = ASCIIEncoding.ASCII.GetBytes(normalText);

            // BASE64 Algorithm (Divides The Bits Into 6 (111111-000000))
            encryptedText = Convert.ToBase64String(encryptedBits);

            // Writes The Encrypted Data
            EncryptedTextRichTextBox.Text = encryptedText;
        }
    }
}
