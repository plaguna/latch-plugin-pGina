using System;
using LatchSDK;
using pGina.Shared.Types;
using System.Windows.Forms;
using System.Collections.Generic;
using log4net;

namespace latch_plugin_pGina
{
    public class Main : pGina.Shared.Interfaces.IPluginAuthorization, pGina.Shared.Interfaces.IPluginConfiguration
    {
        private static readonly Guid plugin_uuid = new Guid("21077753-4FDF-42A0-A498-43CDCB842C79");
        private static dynamic m_settings;
        internal static dynamic Settings { get { return m_settings; } }
        private ILog m_logger;

        public Main()
        {
            m_logger = LogManager.GetLogger("pGina.Plugin.Latch");
            m_settings = new pGina.Shared.Settings.pGinaDynamicSettings(plugin_uuid);

            Main.Settings.SetDefault("ApplicationID", "");
            Main.Settings.SetDefault("Secret", "");
            Main.Settings.SetDefault("AccountID", "");
        }

        public BooleanResult AuthorizeUser(SessionProperties properties)
        {
            UserInformation userInfo = properties.GetTrackedSingle<UserInformation>();

            if (!ReferenceEquals(null, Settings.ApplicationID) && !ReferenceEquals(null, Settings.Secret))
            {
                string applicationID = Util.GetSettingsString((string)Settings.ApplicationID);
                string secret = Util.GetSettingsString((string)Settings.Secret);
                string accountID = Util.GetSettingsString((string)Settings.AccountID);

                //m_logger.InfoFormat("ApplicationID: {0}", applicationID);
                //m_logger.InfoFormat("Secret: {0}", secret);
                //m_logger.InfoFormat("AccountID: {0}", accountID);


                Latch latch = new Latch(applicationID, secret);
                LatchResponse response = latch.Status(accountID);

                // One of the ugliest lines of codes I ever wrote, but quickest way to access the object without using json serialization
                try
                {
                    Dictionary<string, object> operations = ((Dictionary<string, object>)response.Data["operations"]);
                    Dictionary<string, object> appSettings = ((Dictionary<string, object>)operations[(applicationID)]);
                    string status = ((string)appSettings["status"]);

                    m_logger.InfoFormat("Latch status is {0}", status);

                    if (status == "on")
                        return new BooleanResult() { Success = true, Message = "Ready to go!" };
                    else
                        return new BooleanResult() { Success = false, Message = "Latch is protecting this account!" };
                }
                catch (Exception)
                {
                    return new BooleanResult() { Success = true, Message = "Something went wrong, letting you in because I don't want to lock you out!" };
                }
            }
            else
            {
                return new BooleanResult() { Success = false, Message = "Latch is not correctly configured." };
            }
        }

        public string Description
        {
            get { return "Enables Latch on Windows logon process"; }
        }

        public string Name
        {
            get { return "Latch"; }
        }

        public void Starting()
        {
        }

        public void Stopping()
        {
        }

        public Guid Uuid
        {
            get { return plugin_uuid; }
        }

        public string Version
        {
            get 
            { 
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public void Configure()
        {
            Configuration c = new Configuration();
            c.Show();
        }
    }
}
