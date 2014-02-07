using System;
using System.Windows.Forms;
using LatchSDK;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace latch_plugin_pGina
{
    public partial class Configuration : Form
    {     
        public Configuration()
        {
            InitializeComponent();

            if (!ReferenceEquals(null, Main.Settings.ApplicationID) && !ReferenceEquals(null, Main.Settings.Secret))
            {
                tbApplicationID.Text = Util.GetSettingsString((string)Main.Settings.ApplicationID);
                tbSecret.Text = Util.GetSettingsString((string)Main.Settings.Secret); 
            }

            if (!ReferenceEquals(null, Main.Settings.AccountID))
            {
                tbAccountID.Text = Util.GetSettingsString((string)Main.Settings.AccountID);
            }
        }

        private void btnCheckLatchConf_Click(object sender, EventArgs e)
        {
            lblLog.Text = "";

            if (tbApplicationID.Text == null || tbSecret.Text == null)
            {
                lblLog.Text = "Application ID and Secret must be set";
                return;
            }

            // This is the simpliest way I found to check if the details are correct. Hope they add a Validate() method to the API
            Latch latch = new Latch(tbApplicationID.Text, tbSecret.Text);
            LatchResponse response = latch.Status("TestingUserDoNotHateMePalako");

            if (response.Error.Code == 202)
            {
                lblLog.Text = "Application ID and Secret are valid.";
            }
            else
                MessageBox.Show(response.Error.Message + " (" + response.Error.Code + ")");
        }

        private void btnPair_Click(object sender, EventArgs e)
        {
            Latch latch = new Latch(tbApplicationID.Text, tbSecret.Text);
            LatchResponse response = latch.Pair(tbToken.Text);

            if (response.Data != null)
            {
                if (response.Data["accountId"] != null)
                {
                    tbAccountID.Text = response.Data["accountId"].ToString();
                    lblLog.Text = "Pairing successful!";
                    StoreCredentials();
                }
            }
            else
            {
                MessageBox.Show(response.Error.Message + " (" + response.Error.Code + ")");
            }
        }

        private void StoreCredentials()
        {
            Main.Settings.ApplicationID = Util.SetSettingsString(tbApplicationID.Text);
            Main.Settings.Secret = Util.SetSettingsString(tbSecret.Text);
            Main.Settings.AccountID = Util.SetSettingsString(tbAccountID.Text);
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            Latch latch = new Latch(tbApplicationID.Text, tbSecret.Text);
            LatchResponse response = latch.Status(tbAccountID.Text);

            if (response.Data != null)
            {
                Dictionary<string, object> operations = ((Dictionary<string, object>)response.Data["operations"]);
                Dictionary<string, object> appSettings = ((Dictionary<string, object>)operations[(tbApplicationID.Text)]);
                string status = ((string)appSettings["status"]);

                lblLog.Text = "Latch account status is " + status;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StoreCredentials();
            this.Close();
        }

        private void cbTwoFactor_Click(object sender, EventArgs e)
        {
            lblLog.Text = "For version 2 :-)";
        }
    }
}
