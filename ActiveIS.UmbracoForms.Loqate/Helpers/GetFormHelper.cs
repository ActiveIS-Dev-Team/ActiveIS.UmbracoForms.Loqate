using System;
using System.Collections.Generic;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Forms.Core.Data.Storage;
using Umbraco.Forms.Core.Models;

namespace ActiveIS.UmbracoForms.Loqate.Helpers
{
    public static class FormHelper
    {
        public static Form GetForm(Guid id)
        {
            var formService = Current.Factory.GetInstance<IFormStorage>();
            var form = formService.GetForm(id);

            return form;
        }

        public static List<Field> GetAllFormFields(Guid id)
        {
            var formService = Current.Factory.GetInstance<IFormStorage>();
            var form = formService.GetForm(id);
            var allFormFields = form.AllFields;

            return allFormFields;
        }
    }
}
