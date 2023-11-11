using System;
using System.Text;
using System.Windows.Forms;

namespace Voidcrypt.User_Controls
{
    public partial class decrypt_ucontrol : UserControl
    {
        string encrypted_text;
        string decrypted_text;


        public decrypt_ucontrol()
        {
            InitializeComponent();
        }

        private void decrypt_textbox_Click(object sender, EventArgs e)
        {
            encrypted_text = encrypted_textbox.Text;

            byte[] decrypted_bits = Convert.FromBase64String(encrypted_text);

            decrypted_text = ASCIIEncoding.ASCII.GetString(decrypted_bits);

            normal_textbox.Text = decrypted_text;
        }
    }
}
