using System;
using System.Web.Configuration;

namespace ActiveIS.UmbracoForms.Loqate
{
    public class AppSettingsManager
    {
        public static string GetLoqateKey()
        {
            if (WebConfigurationManager.AppSettings["LoqateKey"] != null &&
                !string.IsNullOrEmpty(WebConfigurationManager.AppSettings["LoqateKey"]))
                return WebConfigurationManager.AppSettings["LoqateKey"];

            throw new Exception("'LoqateKey' is missing or empty in AppSettings");
        }
    }
}
