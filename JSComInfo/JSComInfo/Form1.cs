using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace JSComInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            this.ddl_Language.SelectedIndex = 0;
        }

        #region "erneuern..."-Button
        //Button "Info auslesen" -> Die Werte werden in die Textboxen geladen

        private void btn_InfosAuslesen_Click(object sender, EventArgs e)
        {
            txb_ComName.Text = null;
            txb_WinAccount.Text = null;
            txb_WinSystem.Text = null;
            txb_Domain.Text = null;

            txb_ComName.Text = GetComputerName();
            txb_WinAccount.Text = GetAccountName();
            txb_WinSystem.Text = GetOSInformation();
            txb_Domain.Text = GetDomainName();
        }
        #endregion

        #region AccountName
        // Der Benutzername wird ausgelesen

        public string GetAccountName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch { }
            }
            return "User Account Name: Unknown";
        }
        #endregion

        #region OSInformation
        // Das Betriebssystem wird ausgelesen

        public string GetOSInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return ((string)wmi["Caption"]).Trim() + " (" + (string)wmi["OSArchitecture"] + ")";
                }
                catch { }
            }
            return "BIOS Maker: Unknown";
        }
        #endregion

        #region ComputerName
        // Der Hostname des Rechners wird ausgelesen

        public String GetComputerName()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = (string)mo["Name"];
            }
            return info;
        }
        #endregion

        #region Domäne
        public string GetDomainName()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    return queryObj["Domain"].ToString();
                }
            }
            catch (Exception e)
            {
                throw new ManagementException("Error retrieving domain name.", e);
            }
            throw new ManagementException("Error retrieving domain name.");
        }
        #endregion

        #region Kopier-Buttons
        //Buttons "Kopieren" -> Textboxwert wird in den Zwischenspeicher kopiert

        private void pxb_ComName_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_ComName.Text, true);
        }

        private void pxb_WinAccount_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_WinAccount.Text, true);
        }

        private void pxb_WinSystem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_WinSystem.Text, true);
        }

        private void pbx_Domain_Copy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_Domain.Text, true);     
        }

        private void pbx_CopyAll_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_ComName.Text + "\r\n" + txb_WinAccount.Text + "\r\n" + txb_WinSystem.Text + "\r\n" + txb_Domain.Text, true);
        }
        #endregion

        #region Sprachauswahl
        // Umstellen der Sprache auf den zwei Flaggen-Buttons

        private void ddl_Language_Changed(object sender, EventArgs e)
        {

            if (ddl_Language.Text == "English")
            {
                lbl_ComName.Text = "Hostname:";
                lbl_WinAccount.Text = "User:";
                lbl_WinSystem.Text = "Operating System:";
                lbl_Domain.Text = "Domain:";
                btn_InfosAuslesen.Text = "refresh...";
            }
            else
            {
                lbl_ComName.Text = "Computername:";
                lbl_WinAccount.Text = "Benutzer:";
                lbl_WinSystem.Text = "Betriebssystem:";
                lbl_Domain.Text = "Domäne:";
                btn_InfosAuslesen.Text = "erneuern...";
            }
        }
        #endregion

        #region Info-Button
        // Ruft ein zweites Form mit Programminformationen auf

        private void pbx_Info_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.Focus();
            this.Visible = false;
        }
        #endregion
    }
}
