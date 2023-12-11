namespace JSComInfo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_InfosAuslesen = new System.Windows.Forms.Button();
            this.txb_WinSystem = new System.Windows.Forms.TextBox();
            this.txb_WinAccount = new System.Windows.Forms.TextBox();
            this.txb_ComName = new System.Windows.Forms.TextBox();
            this.lbl_ComName = new System.Windows.Forms.Label();
            this.lbl_WinSystem = new System.Windows.Forms.Label();
            this.lbl_WinAccount = new System.Windows.Forms.Label();
            this.pbx_ComName_Copy = new System.Windows.Forms.PictureBox();
            this.pbx_AccountName_Copy = new System.Windows.Forms.PictureBox();
            this.pbx_WinSystem_Copy = new System.Windows.Forms.PictureBox();
            this.pbx_Domain_Copy = new System.Windows.Forms.PictureBox();
            this.txb_Domain = new System.Windows.Forms.TextBox();
            this.lbl_Domain = new System.Windows.Forms.Label();
            this.ddl_Language = new System.Windows.Forms.ComboBox();
            this.pbx_CopyAll = new System.Windows.Forms.PictureBox();
            this.ttp_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.pbx_Info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ComName_Copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_AccountName_Copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_WinSystem_Copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Domain_Copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_InfosAuslesen
            // 
            this.btn_InfosAuslesen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_InfosAuslesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfosAuslesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfosAuslesen.Location = new System.Drawing.Point(393, 124);
            this.btn_InfosAuslesen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_InfosAuslesen.Name = "btn_InfosAuslesen";
            this.btn_InfosAuslesen.Size = new System.Drawing.Size(75, 23);
            this.btn_InfosAuslesen.TabIndex = 2;
            this.btn_InfosAuslesen.Text = "erneuern...";
            this.ttp_ToolTips.SetToolTip(this.btn_InfosAuslesen, "Refresh Data!");
            this.btn_InfosAuslesen.UseVisualStyleBackColor = false;
            this.btn_InfosAuslesen.Click += new System.EventHandler(this.btn_InfosAuslesen_Click);
            // 
            // txb_WinSystem
            // 
            this.txb_WinSystem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_WinSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_WinSystem.Location = new System.Drawing.Point(143, 62);
            this.txb_WinSystem.Margin = new System.Windows.Forms.Padding(2);
            this.txb_WinSystem.Name = "txb_WinSystem";
            this.txb_WinSystem.Size = new System.Drawing.Size(245, 20);
            this.txb_WinSystem.TabIndex = 11;
            // 
            // txb_WinAccount
            // 
            this.txb_WinAccount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_WinAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_WinAccount.Location = new System.Drawing.Point(143, 36);
            this.txb_WinAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txb_WinAccount.Name = "txb_WinAccount";
            this.txb_WinAccount.Size = new System.Drawing.Size(245, 20);
            this.txb_WinAccount.TabIndex = 9;
            // 
            // txb_ComName
            // 
            this.txb_ComName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_ComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ComName.Location = new System.Drawing.Point(143, 10);
            this.txb_ComName.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ComName.Name = "txb_ComName";
            this.txb_ComName.Size = new System.Drawing.Size(245, 20);
            this.txb_ComName.TabIndex = 6;
            // 
            // lbl_ComName
            // 
            this.lbl_ComName.AutoSize = true;
            this.lbl_ComName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ComName.Location = new System.Drawing.Point(12, 13);
            this.lbl_ComName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ComName.Name = "lbl_ComName";
            this.lbl_ComName.Size = new System.Drawing.Size(94, 13);
            this.lbl_ComName.TabIndex = 10;
            this.lbl_ComName.Text = "Computername:";
            // 
            // lbl_WinSystem
            // 
            this.lbl_WinSystem.AutoSize = true;
            this.lbl_WinSystem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WinSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WinSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_WinSystem.Location = new System.Drawing.Point(11, 66);
            this.lbl_WinSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WinSystem.Name = "lbl_WinSystem";
            this.lbl_WinSystem.Size = new System.Drawing.Size(95, 13);
            this.lbl_WinSystem.TabIndex = 8;
            this.lbl_WinSystem.Text = "Betriebssystem:";
            // 
            // lbl_WinAccount
            // 
            this.lbl_WinAccount.AutoSize = true;
            this.lbl_WinAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WinAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WinAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_WinAccount.Location = new System.Drawing.Point(11, 40);
            this.lbl_WinAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WinAccount.Name = "lbl_WinAccount";
            this.lbl_WinAccount.Size = new System.Drawing.Size(61, 13);
            this.lbl_WinAccount.TabIndex = 4;
            this.lbl_WinAccount.Text = "Benutzer:";
            // 
            // pbx_ComName_Copy
            // 
            this.pbx_ComName_Copy.BackColor = System.Drawing.Color.Transparent;
            this.pbx_ComName_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_ComName_Copy.Image = global::JSComInfo.Properties.Resources.copy;
            this.pbx_ComName_Copy.Location = new System.Drawing.Point(393, 12);
            this.pbx_ComName_Copy.Name = "pbx_ComName_Copy";
            this.pbx_ComName_Copy.Size = new System.Drawing.Size(20, 20);
            this.pbx_ComName_Copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_ComName_Copy.TabIndex = 17;
            this.pbx_ComName_Copy.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_ComName_Copy, "Copy Hostname!");
            this.pbx_ComName_Copy.Click += new System.EventHandler(this.pxb_ComName_Click);
            // 
            // pbx_AccountName_Copy
            // 
            this.pbx_AccountName_Copy.BackColor = System.Drawing.Color.Transparent;
            this.pbx_AccountName_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_AccountName_Copy.Image = global::JSComInfo.Properties.Resources.copy;
            this.pbx_AccountName_Copy.Location = new System.Drawing.Point(393, 38);
            this.pbx_AccountName_Copy.Name = "pbx_AccountName_Copy";
            this.pbx_AccountName_Copy.Size = new System.Drawing.Size(20, 20);
            this.pbx_AccountName_Copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_AccountName_Copy.TabIndex = 18;
            this.pbx_AccountName_Copy.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_AccountName_Copy, "Copy User!");
            this.pbx_AccountName_Copy.Click += new System.EventHandler(this.pxb_WinAccount_Click);
            // 
            // pbx_WinSystem_Copy
            // 
            this.pbx_WinSystem_Copy.BackColor = System.Drawing.Color.Transparent;
            this.pbx_WinSystem_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_WinSystem_Copy.Image = global::JSComInfo.Properties.Resources.copy;
            this.pbx_WinSystem_Copy.Location = new System.Drawing.Point(393, 64);
            this.pbx_WinSystem_Copy.Name = "pbx_WinSystem_Copy";
            this.pbx_WinSystem_Copy.Size = new System.Drawing.Size(20, 20);
            this.pbx_WinSystem_Copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_WinSystem_Copy.TabIndex = 19;
            this.pbx_WinSystem_Copy.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_WinSystem_Copy, "Copy Operating System!");
            this.pbx_WinSystem_Copy.Click += new System.EventHandler(this.pxb_WinSystem_Click);
            // 
            // pbx_Domain_Copy
            // 
            this.pbx_Domain_Copy.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Domain_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Domain_Copy.Image = global::JSComInfo.Properties.Resources.copy;
            this.pbx_Domain_Copy.Location = new System.Drawing.Point(393, 90);
            this.pbx_Domain_Copy.Name = "pbx_Domain_Copy";
            this.pbx_Domain_Copy.Size = new System.Drawing.Size(20, 20);
            this.pbx_Domain_Copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Domain_Copy.TabIndex = 22;
            this.pbx_Domain_Copy.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_Domain_Copy, "Copy Domain!");
            this.pbx_Domain_Copy.Click += new System.EventHandler(this.pbx_Domain_Copy_Click);
            // 
            // txb_Domain
            // 
            this.txb_Domain.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_Domain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Domain.Location = new System.Drawing.Point(143, 88);
            this.txb_Domain.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Domain.Name = "txb_Domain";
            this.txb_Domain.Size = new System.Drawing.Size(245, 20);
            this.txb_Domain.TabIndex = 21;
            // 
            // lbl_Domain
            // 
            this.lbl_Domain.AutoSize = true;
            this.lbl_Domain.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Domain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Domain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Domain.Location = new System.Drawing.Point(11, 92);
            this.lbl_Domain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Domain.Name = "lbl_Domain";
            this.lbl_Domain.Size = new System.Drawing.Size(57, 13);
            this.lbl_Domain.TabIndex = 20;
            this.lbl_Domain.Text = "Domäne:";
            // 
            // ddl_Language
            // 
            this.ddl_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddl_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Language.FormattingEnabled = true;
            this.ddl_Language.Items.AddRange(new object[] {
            "Deutsch",
            "English"});
            this.ddl_Language.Location = new System.Drawing.Point(12, 122);
            this.ddl_Language.Name = "ddl_Language";
            this.ddl_Language.Size = new System.Drawing.Size(121, 21);
            this.ddl_Language.TabIndex = 23;
            this.ttp_ToolTips.SetToolTip(this.ddl_Language, "Select Language!");
            this.ddl_Language.SelectedIndexChanged += new System.EventHandler(this.ddl_Language_Changed);
            // 
            // pbx_CopyAll
            // 
            this.pbx_CopyAll.BackColor = System.Drawing.Color.Transparent;
            this.pbx_CopyAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_CopyAll.Image = global::JSComInfo.Properties.Resources.copy;
            this.pbx_CopyAll.Location = new System.Drawing.Point(428, 40);
            this.pbx_CopyAll.Name = "pbx_CopyAll";
            this.pbx_CopyAll.Size = new System.Drawing.Size(45, 45);
            this.pbx_CopyAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_CopyAll.TabIndex = 24;
            this.pbx_CopyAll.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_CopyAll, "Copy all!");
            this.pbx_CopyAll.Click += new System.EventHandler(this.pbx_CopyAll_Click);
            // 
            // pbx_Info
            // 
            this.pbx_Info.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Info.Image = global::JSComInfo.Properties.Resources.information_icon_white;
            this.pbx_Info.Location = new System.Drawing.Point(143, 122);
            this.pbx_Info.Name = "pbx_Info";
            this.pbx_Info.Size = new System.Drawing.Size(21, 21);
            this.pbx_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Info.TabIndex = 44;
            this.pbx_Info.TabStop = false;
            this.pbx_Info.Click += new System.EventHandler(this.pbx_Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSComInfo.Properties.Resources.background_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.pbx_Info);
            this.Controls.Add(this.pbx_CopyAll);
            this.Controls.Add(this.ddl_Language);
            this.Controls.Add(this.pbx_Domain_Copy);
            this.Controls.Add(this.txb_Domain);
            this.Controls.Add(this.lbl_Domain);
            this.Controls.Add(this.pbx_WinSystem_Copy);
            this.Controls.Add(this.pbx_AccountName_Copy);
            this.Controls.Add(this.pbx_ComName_Copy);
            this.Controls.Add(this.txb_WinSystem);
            this.Controls.Add(this.lbl_ComName);
            this.Controls.Add(this.txb_WinAccount);
            this.Controls.Add(this.lbl_WinSystem);
            this.Controls.Add(this.txb_ComName);
            this.Controls.Add(this.lbl_WinAccount);
            this.Controls.Add(this.btn_InfosAuslesen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JSComInfo";
            this.Load += new System.EventHandler(this.ddl_Language_Changed);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ComName_Copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_AccountName_Copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_WinSystem_Copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Domain_Copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_InfosAuslesen;
        private System.Windows.Forms.TextBox txb_WinSystem;
        private System.Windows.Forms.TextBox txb_WinAccount;
        private System.Windows.Forms.TextBox txb_ComName;
        private System.Windows.Forms.Label lbl_ComName;
        private System.Windows.Forms.Label lbl_WinSystem;
        private System.Windows.Forms.Label lbl_WinAccount;
        private System.Windows.Forms.PictureBox pbx_ComName_Copy;
        private System.Windows.Forms.PictureBox pbx_AccountName_Copy;
        private System.Windows.Forms.PictureBox pbx_WinSystem_Copy;
        private System.Windows.Forms.PictureBox pbx_Domain_Copy;
        private System.Windows.Forms.TextBox txb_Domain;
        private System.Windows.Forms.Label lbl_Domain;
        private System.Windows.Forms.ComboBox ddl_Language;
        private System.Windows.Forms.PictureBox pbx_CopyAll;
        private System.Windows.Forms.ToolTip ttp_ToolTips;
        private System.Windows.Forms.PictureBox pbx_Info;
    }
}

