using MyDVLD_BLL;
using MyDVLD_BLL.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.Validations
{
    public static class ValidationsPresentation
    {
      // check about empty field (Text Box )
        public static void TextBox_EmptyValidating(TextBox txtBox, CancelEventArgs e , ErrorProvider provider)
        {
            if (string.IsNullOrEmpty(txtBox.Text.Trim()))
            {
                provider.SetError(txtBox, "Mandatory Field");
                e.Cancel = true;
            }
            else
                provider.SetError(txtBox, "");
        }

        // specific Check about National no text box
        public static void NationalNo_Validating(TextBox txtBox, CancelEventArgs e, ErrorProvider provider)
        {
            string messageError = "";

            if (string.IsNullOrEmpty(txtBox.Text.Trim()))
            {
                messageError = "The Field Can't Be Empty";
            }
            else if (PersonValidator.IsPersonAlreadyExists(out messageError, null, txtBox.Text.Trim()))
            {
                messageError = "There's A person With this National No";
            }

            if (!string.IsNullOrEmpty(messageError))
            {
                provider.SetError(txtBox, messageError);
                e.Cancel = true;
            }
            else
                provider.SetError(txtBox, "");
        }





    }
}
