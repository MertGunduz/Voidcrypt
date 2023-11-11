
namespace Voidcrypt.User_Controls
{
    partial class encrypt_ucontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MidExpandPanel = new System.Windows.Forms.Panel();
            this.MidSmallPanel = new System.Windows.Forms.Panel();
            this.MidSmallPanelExpand = new System.Windows.Forms.Panel();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightPanelBottomExpand = new System.Windows.Forms.Panel();
            this.encrypted_textbox = new System.Windows.Forms.RichTextBox();
            this.EncryptedTextLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftPanelBottomExpand = new System.Windows.Forms.Panel();
            this.regular_textbox = new System.Windows.Forms.RichTextBox();
            this.NormalTextLabel = new System.Windows.Forms.Label();
            this.MidExpandPanel.SuspendLayout();
            this.MidSmallPanel.SuspendLayout();
            this.MidSmallPanelExpand.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.RightPanelBottomExpand.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelBottomExpand.SuspendLayout();
            this.SuspendLayout();
            // 
            // MidExpandPanel
            // 
            this.MidExpandPanel.Controls.Add(this.MidSmallPanel);
            this.MidExpandPanel.Controls.Add(this.RightPanel);
            this.MidExpandPanel.Controls.Add(this.LeftPanel);
            this.MidExpandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidExpandPanel.Location = new System.Drawing.Point(0, 0);
            this.MidExpandPanel.Name = "MidExpandPanel";
            this.MidExpandPanel.Size = new System.Drawing.Size(1045, 617);
            this.MidExpandPanel.TabIndex = 1;
            // 
            // MidSmallPanel
            // 
            this.MidSmallPanel.Controls.Add(this.MidSmallPanelExpand);
            this.MidSmallPanel.Location = new System.Drawing.Point(411, 13);
            this.MidSmallPanel.Name = "MidSmallPanel";
            this.MidSmallPanel.Size = new System.Drawing.Size(224, 591);
            this.MidSmallPanel.TabIndex = 2;
            // 
            // MidSmallPanelExpand
            // 
            this.MidSmallPanelExpand.Controls.Add(this.encrypt_button);
            this.MidSmallPanelExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidSmallPanelExpand.Location = new System.Drawing.Point(0, 0);
            this.MidSmallPanelExpand.Name = "MidSmallPanelExpand";
            this.MidSmallPanelExpand.Size = new System.Drawing.Size(224, 591);
            this.MidSmallPanelExpand.TabIndex = 0;
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.encrypt_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encrypt_button.FlatAppearance.BorderSize = 0;
            this.encrypt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.encrypt_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.encrypt_button.Location = new System.Drawing.Point(0, 0);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(224, 591);
            this.encrypt_button.TabIndex = 5;
            this.encrypt_button.Text = "ENCRYPT\r\n\r\n(BASE64)";
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.EncryptToVoidLangButton_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.RightPanel.Controls.Add(this.RightPanelBottomExpand);
            this.RightPanel.Location = new System.Drawing.Point(641, 13);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(392, 591);
            this.RightPanel.TabIndex = 1;
            // 
            // RightPanelBottomExpand
            // 
            this.RightPanelBottomExpand.Controls.Add(this.encrypted_textbox);
            this.RightPanelBottomExpand.Controls.Add(this.EncryptedTextLabel);
            this.RightPanelBottomExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelBottomExpand.Location = new System.Drawing.Point(0, 0);
            this.RightPanelBottomExpand.Name = "RightPanelBottomExpand";
            this.RightPanelBottomExpand.Size = new System.Drawing.Size(392, 591);
            this.RightPanelBottomExpand.TabIndex = 2;
            // 
            // encrypted_textbox
            // 
            this.encrypted_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.encrypted_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encrypted_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.encrypted_textbox.Location = new System.Drawing.Point(16, 55);
            this.encrypted_textbox.Name = "encrypted_textbox";
            this.encrypted_textbox.Size = new System.Drawing.Size(360, 522);
            this.encrypted_textbox.TabIndex = 1;
            this.encrypted_textbox.Text = "ENCRYPTED TEXT";
            // 
            // EncryptedTextLabel
            // 
            this.EncryptedTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncryptedTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EncryptedTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.EncryptedTextLabel.Location = new System.Drawing.Point(0, 0);
            this.EncryptedTextLabel.Name = "EncryptedTextLabel";
            this.EncryptedTextLabel.Size = new System.Drawing.Size(392, 39);
            this.EncryptedTextLabel.TabIndex = 1;
            this.EncryptedTextLabel.Text = "Encrypted Text";
            this.EncryptedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LeftPanel.Controls.Add(this.LeftPanelBottomExpand);
            this.LeftPanel.Location = new System.Drawing.Point(12, 13);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(392, 591);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftPanelBottomExpand
            // 
            this.LeftPanelBottomExpand.Controls.Add(this.regular_textbox);
            this.LeftPanelBottomExpand.Controls.Add(this.NormalTextLabel);
            this.LeftPanelBottomExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanelBottomExpand.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelBottomExpand.Name = "LeftPanelBottomExpand";
            this.LeftPanelBottomExpand.Size = new System.Drawing.Size(392, 591);
            this.LeftPanelBottomExpand.TabIndex = 1;
            // 
            // regular_textbox
            // 
            this.regular_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.regular_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regular_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.regular_textbox.Location = new System.Drawing.Point(16, 55);
            this.regular_textbox.Name = "regular_textbox";
            this.regular_textbox.Size = new System.Drawing.Size(360, 522);
            this.regular_textbox.TabIndex = 2;
            this.regular_textbox.Text = "NORMAL TEXT";
            // 
            // NormalTextLabel
            // 
            this.NormalTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NormalTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NormalTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.NormalTextLabel.Location = new System.Drawing.Point(0, 0);
            this.NormalTextLabel.Name = "NormalTextLabel";
            this.NormalTextLabel.Size = new System.Drawing.Size(392, 39);
            this.NormalTextLabel.TabIndex = 0;
            this.NormalTextLabel.Text = "Normal Text";
            this.NormalTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VoidEncryptor_UserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.MidExpandPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "VoidEncryptor_UserControl";
            this.Size = new System.Drawing.Size(1045, 617);
            this.MidExpandPanel.ResumeLayout(false);
            this.MidSmallPanel.ResumeLayout(false);
            this.MidSmallPanelExpand.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.RightPanelBottomExpand.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanelBottomExpand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MidExpandPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label NormalTextLabel;
        private System.Windows.Forms.Label EncryptedTextLabel;
        private System.Windows.Forms.Panel RightPanelBottomExpand;
        private System.Windows.Forms.Panel LeftPanelBottomExpand;
        private System.Windows.Forms.RichTextBox encrypted_textbox;
        private System.Windows.Forms.RichTextBox regular_textbox;
        private System.Windows.Forms.Panel MidSmallPanel;
        private System.Windows.Forms.Panel MidSmallPanelExpand;
        private System.Windows.Forms.Button encrypt_button;
    }
}
