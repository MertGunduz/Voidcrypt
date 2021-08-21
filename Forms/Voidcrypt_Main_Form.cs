using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voidcrypt.Forms
{
    public partial class Voidcrypt_Main_Form : Form
    {
        public Voidcrypt_Main_Form()
        {
            InitializeComponent();
        }

        private void VoidEncryptorButtonGraphics()
        {
            MainHeaderLabel.Text = "Void Encryptor";
            SideNavigationPanel.Top = VoidEncryptorButton.Top;
            SideNavigationPanel.Height = VoidEncryptorButton.Height;
            VoidEncryptorButton.BackColor = Color.FromArgb(45, 45, 48);
            VoidDecryptorButton.BackColor = Color.FromArgb(28, 28, 28);
            MyStatisticsButton.BackColor = Color.FromArgb(28, 28, 28);
            SettingsButton.BackColor = Color.FromArgb(28, 28, 28);
            voidEncryptor_UserControl1.BringToFront();
        }

        private void VoidDecryptorButtonGraphics()
        {
            MainHeaderLabel.Text = "Void Decryptor";
            SideNavigationPanel.Top = VoidDecryptorButton.Top;
            SideNavigationPanel.Height = VoidDecryptorButton.Height;
            VoidEncryptorButton.BackColor = Color.FromArgb(28, 28, 28);
            VoidDecryptorButton.BackColor = Color.FromArgb(45, 45, 48);
            MyStatisticsButton.BackColor = Color.FromArgb(28, 28, 28);
            SettingsButton.BackColor = Color.FromArgb(28, 28, 28);
            voidDecryptor_UserControl1.BringToFront();
        }

        private void MyStatisticsButtonGraphics()
        {
            MainHeaderLabel.Text = "My Statistics";
            SideNavigationPanel.Top = MyStatisticsButton.Top;
            SideNavigationPanel.Height = MyStatisticsButton.Height;
            VoidEncryptorButton.BackColor = Color.FromArgb(28, 28, 28);
            VoidDecryptorButton.BackColor = Color.FromArgb(28, 28, 28);
            MyStatisticsButton.BackColor = Color.FromArgb(45, 45, 48);
            SettingsButton.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void SettingsButtonGraphics()
        {
            MainHeaderLabel.Text = "Settings";
            SideNavigationPanel.Top = SettingsButton.Top;
            SideNavigationPanel.Height = SettingsButton.Height;
            VoidEncryptorButton.BackColor = Color.FromArgb(28, 28, 28);
            VoidDecryptorButton.BackColor = Color.FromArgb(28, 28, 28);
            MyStatisticsButton.BackColor = Color.FromArgb(28, 28, 28);
            SettingsButton.BackColor = Color.FromArgb(45, 45, 48);
        }


        private void Voidcrypt_Main_Form_Load(object sender, EventArgs e)
        {
            VoidEncryptorButtonGraphics();
        }

        private void VoidEncryptorButton_Click(object sender, EventArgs e)
        {
            VoidEncryptorButtonGraphics();
        }

        private void VoidDecryptorButton_Click(object sender, EventArgs e)
        {
            VoidDecryptorButtonGraphics();
        }

        private void CommandLineButton_Click(object sender, EventArgs e)
        {
            MyStatisticsButtonGraphics();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsButtonGraphics();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
