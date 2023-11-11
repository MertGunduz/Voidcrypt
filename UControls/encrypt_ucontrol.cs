using System;
using System.Text;
using System.Windows.Forms;

namespace Voidcrypt.User_Controls
{
    public partial class encrypt_ucontrol : UserControl
    {
        string normal_text;
        string encrypted_text;

        public encrypt_ucontrol()
        {
            InitializeComponent();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            normal_text = regular_textbox.Text;

            byte[] encrypted_bits = ASCIIEncoding.ASCII.GetBytes(normal_text);

            encrypted_text = Convert.ToBase64String(encrypted_bits);

            encrypted_textbox.Text = encrypted_text;
        }
    }
}
