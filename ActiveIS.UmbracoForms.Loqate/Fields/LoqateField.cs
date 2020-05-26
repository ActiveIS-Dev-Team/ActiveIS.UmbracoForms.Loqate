using System;
using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Attributes;
using Umbraco.Forms.Core.Enums;

namespace ActiveIS.UmbracoForms.Loqate.Fields
{
    public class Loqate: FieldType
    {
        public Loqate()
        {
            Id = new Guid("538a430a-db9f-4b58-92fa-2fd2c024dae2");
            Name = "Loqate";
            Description = string.Empty;
            Icon = "icon-search";
            DataType = FieldDataType.String;
            SortOrder = 10;
            SupportsRegex = false;
        }

        [Setting("Countries", Description = "A comma separated list of ISO 2 or 3 character country codes to limit the search within.", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string Countries { get; set; }

        [Setting("Limit", Description = "The maximum number of results to return.", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string Limit { get; set; }

        [Setting("Language", Description = "The preferred language for results. This should be a 2 or 4 character language code e.g. (en, fr, en-gb, en-us etc).", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string Language { get; set; }

        [Setting("Origin", Description = "A starting location for the search. This can be the name or ISO 2 or 3 character code of a country, WGS84 coordinates (comma separated) or IP address to search from.", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string Origin { get; set; }

        [Setting("Address Line 1 Alias", Description = "The Umbraco forms alias for address line 1", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string AddressLine1Alias { get; set; }

        [Setting("Address Line 2 Alias", Description = "The Umbraco forms alias for address line 2", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string AddressLine2Alias { get; set; }        
        
        [Setting("Address Line 3 Alias", Description = "The Umbraco forms alias for address line 3", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string AddressLine3Alias { get; set; }

        [Setting("Town / City Alias", Description = "The Umbraco forms alias for town / city", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string TownCityAlias { get; set; }

        [Setting("County Alias", Description = "The Umbraco forms alias for county", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string CountyAlias { get; set; }

        [Setting("Post Code Alias", Description = "The Umbraco forms alias for post code", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string PostCodeAlias { get; set; }

        [Setting("Country Alias", Description = "The Umbraco forms alias for country", View = "~/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/textfield.html")]
        public string CountryAlias { get; set; }
    }
}
