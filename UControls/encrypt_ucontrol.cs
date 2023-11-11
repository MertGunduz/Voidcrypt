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
            normalText = regular_textbox.Text;

            byte[] encryptedBits = ASCIIEncoding.ASCII.GetBytes(normalText);

            encryptedText = Convert.ToBase64String(encryptedBits);

            encrypted_textbox.Text = encryptedText;
        }
    }
}
