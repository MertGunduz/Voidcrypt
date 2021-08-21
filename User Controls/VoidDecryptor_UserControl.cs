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
    public partial class VoidDecryptor_UserControl : UserControl
    {
        // Text Data
        string encryptedText;
        string decryptedText;


        public VoidDecryptor_UserControl()
        {
            InitializeComponent();
        }

        private void EncryptedTextRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (EncryptedTextRichTextBox.Text == "***********************************************************\nEncrypted Text\n***********************************************************")
            {
                EncryptedTextRichTextBox.Clear();
            }
        }

        private void NormalTextEncryptedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (NormalTextRichTextBox.Text == "***********************************************************\nNormal Text\n***********************************************************")
            {
                NormalTextRichTextBox.Clear();
            }
        }

        private void DecryptToNormalLangButton_Click(object sender, EventArgs e)
        {
            encryptedText = EncryptedTextRichTextBox.Text;

            byte[] decryptedBits = Convert.FromBase64String(encryptedText);

            decryptedText = ASCIIEncoding.ASCII.GetString(decryptedBits);

            NormalTextRichTextBox.Text = decryptedText;
        }
    }
}
