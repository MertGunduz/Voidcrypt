
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
            this.nav_panel = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.decryptor_button = new System.Windows.Forms.Button();
            this.encryptor_button = new System.Windows.Forms.Button();
            this.Voidcrypt_TopLogoPanel = new System.Windows.Forms.Panel();
            this.Logo_Label = new System.Windows.Forms.Label();
            this.Void_IDE_TopLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.encrypt_ucontrol1 = new Voidcrypt.User_Controls.encrypt_ucontrol();
            this.decrypt_ucontrol1 = new Voidcrypt.User_Controls.decrypt_ucontrol();
            this.Voidcrypt_LeftPanel.SuspendLayout();
            this.Voidcrypt_ExpandLeftPanel.SuspendLayout();
            this.Voidcrypt_TopLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Void_IDE_TopLogoPictureBox)).BeginInit();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Voidcrypt_LeftPanel
            // 
            this.Voidcrypt_LeftPanel.Controls.Add(this.Voidcrypt_ExpandLeftPanel);
            this.Voidcrypt_LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Voidcrypt_LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.Voidcrypt_LeftPanel.Name = "Voidcrypt_LeftPanel";
            this.Voidcrypt_LeftPanel.Size = new System.Drawing.Size(198, 617);
            this.Voidcrypt_LeftPanel.TabIndex = 6;
            // 
            // Voidcrypt_ExpandLeftPanel
            // 
            this.Voidcrypt_ExpandLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.nav_panel);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.settings_button);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.decryptor_button);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.encryptor_button);
            this.Voidcrypt_ExpandLeftPanel.Controls.Add(this.Voidcrypt_TopLogoPanel);
            this.Voidcrypt_ExpandLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Voidcrypt_ExpandLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.Voidcrypt_ExpandLeftPanel.Name = "Voidcrypt_ExpandLeftPanel";
            this.Voidcrypt_ExpandLeftPanel.Size = new System.Drawing.Size(198, 617);
            this.Voidcrypt_ExpandLeftPanel.TabIndex = 0;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.nav_panel.Location = new System.Drawing.Point(0, 169);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(3, 48);
            this.nav_panel.TabIndex = 3;
            // 
            // settings_button
            // 
            this.settings_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settings_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.settings_button.Image = global::Voidcrypt.Properties.Resources.Voidcrypt_StatisticsIcon;
            this.settings_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settings_button.Location = new System.Drawing.Point(0, 569);
            this.settings_button.Name = "settings_button";
            this.settings_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.settings_button.Size = new System.Drawing.Size(198, 48);
            this.settings_button.TabIndex = 5;
            this.settings_button.Text = "About";
            this.settings_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // decryptor_button
            // 
            this.decryptor_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.decryptor_button.FlatAppearance.BorderSize = 0;
            this.decryptor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decryptor_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.decryptor_button.Image = global::Voidcrypt.Properties.Resources.Voidcrypt_KeyIcon;
            this.decryptor_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decryptor_button.Location = new System.Drawing.Point(0, 217);
            this.decryptor_button.Name = "decryptor_button";
            this.decryptor_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.decryptor_button.Size = new System.Drawing.Size(198, 48);
            this.decryptor_button.TabIndex = 2;
            this.decryptor_button.Text = "Void Decryptor";
            this.decryptor_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptor_button.UseVisualStyleBackColor = true;
            this.decryptor_button.Click += new System.EventHandler(this.decryptor_button_Click);
            // 
            // encryptor_button
            // 
            this.encryptor_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.encryptor_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.encryptor_button.FlatAppearance.BorderSize = 0;
            this.encryptor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.encryptor_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.encryptor_button.Image = global::Voidcrypt.Properties.Resources.Voidcrypt_LockIcon;
            this.encryptor_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.encryptor_button.Location = new System.Drawing.Point(0, 169);
            this.encryptor_button.Name = "encryptor_button";
            this.encryptor_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.encryptor_button.Size = new System.Drawing.Size(198, 48);
            this.encryptor_button.TabIndex = 1;
            this.encryptor_button.Text = "Void Encryptor";
            this.encryptor_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptor_button.UseVisualStyleBackColor = false;
            this.encryptor_button.Click += new System.EventHandler(this.encryptor_button_Click);
            // 
            // Voidcrypt_TopLogoPanel
            // 
            this.Voidcrypt_TopLogoPanel.Controls.Add(this.Logo_Label);
            this.Voidcrypt_TopLogoPanel.Controls.Add(this.Void_IDE_TopLogoPictureBox);
            this.Voidcrypt_TopLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Voidcrypt_TopLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.Voidcrypt_TopLogoPanel.Name = "Voidcrypt_TopLogoPanel";
            this.Voidcrypt_TopLogoPanel.Size = new System.Drawing.Size(198, 169);
            this.Voidcrypt_TopLogoPanel.TabIndex = 0;
            // 
            // Logo_Label
            // 
            this.Logo_Label.AutoSize = true;
            this.Logo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logo_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.Logo_Label.Location = new System.Drawing.Point(57, 140);
            this.Logo_Label.Name = "Logo_Label";
            this.Logo_Label.Size = new System.Drawing.Size(84, 20);
            this.Logo_Label.TabIndex = 2;
            this.Logo_Label.Text = "Voidcrypt";
            // 
            // Void_IDE_TopLogoPictureBox
            // 
            this.Void_IDE_TopLogoPictureBox.Image = global::Voidcrypt.Properties.Resources.Voidcrypt_Logo;
            this.Void_IDE_TopLogoPictureBox.Location = new System.Drawing.Point(37, 12);
            this.Void_IDE_TopLogoPictureBox.Name = "Void_IDE_TopLogoPictureBox";
            this.Void_IDE_TopLogoPictureBox.Size = new System.Drawing.Size(125, 125);
            this.Void_IDE_TopLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Void_IDE_TopLogoPictureBox.TabIndex = 0;
            this.Void_IDE_TopLogoPictureBox.TabStop = false;
            // 
            // Top_Panel
            // 
            this.Top_Panel.Controls.Add(this.encrypt_ucontrol1);
            this.Top_Panel.Controls.Add(this.decrypt_ucontrol1);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_Panel.Location = new System.Drawing.Point(198, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(1045, 617);
            this.Top_Panel.TabIndex = 11;
            // 
            // encrypt_ucontrol1
            // 
            this.encrypt_ucontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.encrypt_ucontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encrypt_ucontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.encrypt_ucontrol1.Location = new System.Drawing.Point(0, 0);
            this.encrypt_ucontrol1.Name = "encrypt_ucontrol1";
            this.encrypt_ucontrol1.Size = new System.Drawing.Size(1045, 617);
            this.encrypt_ucontrol1.TabIndex = 1;
            // 
            // decrypt_ucontrol1
            // 
            this.decrypt_ucontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.decrypt_ucontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decrypt_ucontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decrypt_ucontrol1.Location = new System.Drawing.Point(0, 0);
            this.decrypt_ucontrol1.Name = "decrypt_ucontrol1";
            this.decrypt_ucontrol1.Size = new System.Drawing.Size(1045, 617);
            this.decrypt_ucontrol1.TabIndex = 0;
            // 
            // Voidcrypt_Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1243, 617);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Voidcrypt_LeftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Voidcrypt_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voidcrypt";
            this.Voidcrypt_LeftPanel.ResumeLayout(false);
            this.Voidcrypt_ExpandLeftPanel.ResumeLayout(false);
            this.Voidcrypt_TopLogoPanel.ResumeLayout(false);
            this.Voidcrypt_TopLogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Void_IDE_TopLogoPictureBox)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Voidcrypt_LeftPanel;
        private System.Windows.Forms.Panel Voidcrypt_ExpandLeftPanel;
        private System.Windows.Forms.Panel nav_panel;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button decryptor_button;
        private System.Windows.Forms.Button encryptor_button;
        private System.Windows.Forms.Panel Voidcrypt_TopLogoPanel;
        private System.Windows.Forms.Label Logo_Label;
        private System.Windows.Forms.PictureBox Void_IDE_TopLogoPictureBox;
        private System.Windows.Forms.Panel Top_Panel;
        private User_Controls.decrypt_ucontrol decrypt_ucontrol1;
        private User_Controls.encrypt_ucontrol encrypt_ucontrol1;
    }
}