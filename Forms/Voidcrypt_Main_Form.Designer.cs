
namespace Voidcrypt.Forms
{
    partial class Voidcrypt_Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voidcrypt_Main_Form));
            this.Voidcrypt_LeftPanel = new System.Windows.Forms.Panel();
            this.Voidcrypt_ExpandLeftPanel = new System.Windows.Forms.Panel();
            this.SideNavigationPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MyStatisticsButton = new System.Windows.Forms.Button();
            this.VoidDecryptorButton = new System.Windows.Forms.Button();
            this.VoidEncryptorButton = new System.Windows.Forms.Button();
            this.Voidcrypt_TopLogoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Void_IDE_TopLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MainHeaderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.voidEncryptor_UserControl1 = new Voidcrypt.User_Controls.VoidEncryptor_UserControl();
            this.voidDecryptor_UserControl1 = new Voidcrypt.User_Controls.VoidDecryptor_UserControl();
            this.Voidcrypt_LeftPanel.SuspendLayout();
            this.Voidcrypt_ExpandLeftPanel.SuspendLayout();
            this.Voidcrypt_TopLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Void_IDE_TopLogoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Voidcrypt_LeftPanel
            // 
            this.Voidcrypt_LeftPanel.Controls.Add(this.Voidcrypt_ExpandLeftPanel);
            this.Voidcrypt_LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Voidcrypt_LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.Voidcrypt_LeftPanel.Name = "Voidcrypt_LeftPanel";
            this.Voidcrypt_LeftPanel.Size = new System.Drawing.Size(198, 688);
            this.Voidcrypt_LeftPanel.TabIndex = 6;
            // 
            // Voidcrypt_ExpandLeftPanel
            // 
            this.Voidcrypt_ExpandLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.SideNavigationPanel);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.SettingsButton);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.MyStatisticsButton);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.VoidDecryptorButton);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.VoidEncryptorButton);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.Voidcrypt_TopLogoPanel);
            this.Voidcrypt_ExpandLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Voidcrypt_ExpandLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.Voidcrypt_ExpandLeftPanel.Name = "Voidcrypt_ExpandLeftPanel";
            this.Voidcrypt_ExpandLeftPanel.Size = new System.Drawing.Size(198, 688);
            this.Voidcrypt_ExpandLeftPanel.TabIndex = 0;
            // 
            // SideNavigationPanel
            // 
            this.SideNavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.SideNavigationPanel.Location = new System.Drawing.Point(0, 169);
            this.SideNavigationPanel.Name = "SideNavigationPanel";
            this.SideNavigationPanel.Size = new System.Drawing.Size(3, 48);
            this.SideNavigationPanel.TabIndex = 3;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsButton.Location = new System.Drawing.Point(0, 640);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SettingsButton.Size = new System.Drawing.Size(198, 48);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MyStatisticsButton
            // 
            this.MyStatisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyStatisticsButton.FlatAppearance.BorderSize = 0;
            this.MyStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyStatisticsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MyStatisticsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.MyStatisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("MyStatisticsButton.Image")));
            this.MyStatisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyStatisticsButton.Location = new System.Drawing.Point(0, 265);
            this.MyStatisticsButton.Name = "MyStatisticsButton";
            this.MyStatisticsButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MyStatisticsButton.Size = new System.Drawing.Size(198, 48);
            this.MyStatisticsButton.TabIndex = 3;
            this.MyStatisticsButton.Text = "My Statistics";
            this.MyStatisticsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyStatisticsButton.UseVisualStyleBackColor = true;
            this.MyStatisticsButton.Click += new System.EventHandler(this.CommandLineButton_Click);
            // 
            // VoidDecryptorButton
            // 
            this.VoidDecryptorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VoidDecryptorButton.FlatAppearance.BorderSize = 0;
            this.VoidDecryptorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoidDecryptorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VoidDecryptorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.VoidDecryptorButton.Image = ((System.Drawing.Image)(resources.GetObject("VoidDecryptorButton.Image")));
            this.VoidDecryptorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VoidDecryptorButton.Location = new System.Drawing.Point(0, 217);
            this.VoidDecryptorButton.Name = "VoidDecryptorButton";
            this.VoidDecryptorButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.VoidDecryptorButton.Size = new System.Drawing.Size(198, 48);
            this.VoidDecryptorButton.TabIndex = 2;
            this.VoidDecryptorButton.Text = "Void Decryptor";
            this.VoidDecryptorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VoidDecryptorButton.UseVisualStyleBackColor = true;
            this.VoidDecryptorButton.Click += new System.EventHandler(this.VoidDecryptorButton_Click);
            // 
            // VoidEncryptorButton
            // 
            this.VoidEncryptorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VoidEncryptorButton.FlatAppearance.BorderSize = 0;
            this.VoidEncryptorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoidEncryptorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VoidEncryptorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.VoidEncryptorButton.Image = ((System.Drawing.Image)(resources.GetObject("VoidEncryptorButton.Image")));
            this.VoidEncryptorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VoidEncryptorButton.Location = new System.Drawing.Point(0, 169);
            this.VoidEncryptorButton.Name = "VoidEncryptorButton";
            this.VoidEncryptorButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.VoidEncryptorButton.Size = new System.Drawing.Size(198, 48);
            this.VoidEncryptorButton.TabIndex = 1;
            this.VoidEncryptorButton.Text = "Void Encryptor";
            this.VoidEncryptorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VoidEncryptorButton.UseVisualStyleBackColor = true;
            this.VoidEncryptorButton.Click += new System.EventHandler(this.VoidEncryptorButton_Click);
            // 
            // Voidcrypt_TopLogoPanel
            // 
            this.Voidcrypt_TopLogoPanel.Controls.Add(this.label1);
            this.Voidcrypt_TopLogoPanel.Controls.Add(this.Void_IDE_TopLogoPictureBox);
            this.Voidcrypt_TopLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Voidcrypt_TopLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.Voidcrypt_TopLogoPanel.Name = "Voidcrypt_TopLogoPanel";
            this.Voidcrypt_TopLogoPanel.Size = new System.Drawing.Size(198, 169);
            this.Voidcrypt_TopLogoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(57, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voidcrypt";
            // 
            // Void_IDE_TopLogoPictureBox
            // 
            this.Void_IDE_TopLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Void_IDE_TopLogoPictureBox.Image")));
            this.Void_IDE_TopLogoPictureBox.Location = new System.Drawing.Point(37, 12);
            this.Void_IDE_TopLogoPictureBox.Name = "Void_IDE_TopLogoPictureBox";
            this.Void_IDE_TopLogoPictureBox.Size = new System.Drawing.Size(125, 125);
            this.Void_IDE_TopLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Void_IDE_TopLogoPictureBox.TabIndex = 0;
            this.Void_IDE_TopLogoPictureBox.TabStop = false;
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.Image")));
            this.MaximizeButton.Location = new System.Drawing.Point(1014, 4);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(25, 23);
            this.MaximizeButton.TabIndex = 8;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(983, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 23);
            this.MinimizeButton.TabIndex = 7;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MainHeaderLabel
            // 
            this.MainHeaderLabel.AutoSize = true;
            this.MainHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.MainHeaderLabel.Location = new System.Drawing.Point(22, 19);
            this.MainHeaderLabel.Name = "MainHeaderLabel";
            this.MainHeaderLabel.Size = new System.Drawing.Size(207, 32);
            this.MainHeaderLabel.TabIndex = 3;
            this.MainHeaderLabel.Text = "Void Encryptor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MaximizeButton);
            this.panel1.Controls.Add(this.MainHeaderLabel);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 71);
            this.panel1.TabIndex = 11;
            // 
            // voidEncryptor_UserControl1
            // 
            this.voidEncryptor_UserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.voidEncryptor_UserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.voidEncryptor_UserControl1.Location = new System.Drawing.Point(198, 71);
            this.voidEncryptor_UserControl1.Name = "voidEncryptor_UserControl1";
            this.voidEncryptor_UserControl1.Size = new System.Drawing.Size(1045, 617);
            this.voidEncryptor_UserControl1.TabIndex = 10;
            // 
            // voidDecryptor_UserControl1
            // 
            this.voidDecryptor_UserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.voidDecryptor_UserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.voidDecryptor_UserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.voidDecryptor_UserControl1.Location = new System.Drawing.Point(198, 71);
            this.voidDecryptor_UserControl1.Name = "voidDecryptor_UserControl1";
            this.voidDecryptor_UserControl1.Size = new System.Drawing.Size(1045, 617);
            this.voidDecryptor_UserControl1.TabIndex = 9;
            // 
            // Voidcrypt_Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1243, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voidEncryptor_UserControl1);
            this.Controls.Add(this.voidDecryptor_UserControl1);
            this.Controls.Add(this.Voidcrypt_LeftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Voidcrypt_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voidcrypt";
            this.Load += new System.EventHandler(this.Voidcrypt_Main_Form_Load);
            this.Voidcrypt_LeftPanel.ResumeLayout(false);
            this.Voidcrypt_ExpandLeftPanel.ResumeLayout(false);
            this.Voidcrypt_TopLogoPanel.ResumeLayout(false);
            this.Voidcrypt_TopLogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Void_IDE_TopLogoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Voidcrypt_LeftPanel;
        private System.Windows.Forms.Panel Voidcrypt_ExpandLeftPanel;
        private System.Windows.Forms.Panel SideNavigationPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button MyStatisticsButton;
        private System.Windows.Forms.Button VoidDecryptorButton;
        private System.Windows.Forms.Button VoidEncryptorButton;
        private System.Windows.Forms.Panel Voidcrypt_TopLogoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Void_IDE_TopLogoPictureBox;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button MinimizeButton;
        private User_Controls.VoidDecryptor_UserControl voidDecryptor_UserControl1;
        private User_Controls.VoidEncryptor_UserControl voidEncryptor_UserControl1;
        private System.Windows.Forms.Label MainHeaderLabel;
        private System.Windows.Forms.Panel panel1;
    }
}