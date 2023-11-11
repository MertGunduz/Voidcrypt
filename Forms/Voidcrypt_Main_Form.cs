using System;
using System.Drawing;
using System.Windows.Forms;

namespace Voidcrypt.Forms
{
    public partial class Voidcrypt_Main_Form : Form
    {
        public Voidcrypt_Main_Form()
        {
            InitializeComponent();
        }

        private void encryptor_button_Click(object sender, EventArgs e)
        {
            encryptor_button.BackColor = Color.FromArgb(45, 45, 48);
            decryptor_button.BackColor = Color.FromArgb(28, 28, 28);

            nav_panel.Top = encryptor_button.Top;

            encrypt_ucontrol1.BringToFront();
        }

        private void decryptor_button_Click(object sender, EventArgs e)
        {
            decryptor_button.BackColor = Color.FromArgb(45, 45, 48);
            encryptor_button.BackColor = Color.FromArgb(28, 28, 28);

            nav_panel.Top = decryptor_button.Top;

            decrypt_ucontrol1.BringToFront();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voidcrypt 1.0.0\n\nGNU General Public License v3.0", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
