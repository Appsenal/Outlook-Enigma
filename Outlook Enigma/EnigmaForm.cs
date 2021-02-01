using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Outlook_Enigma
{
    partial class EnigmaForm
    {
        #region Form Region Factory 

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
        [Microsoft.Office.Tools.Outlook.FormRegionName("Outlook Enigma.EnigmaForm")]
        public partial class EnigmaFormFactory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void EnigmaFormFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }

        #endregion

        // Occurs before the form region is displayed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void EnigmaForm_FormRegionShowing(object sender, System.EventArgs e)
        {
        }

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void EnigmaForm_FormRegionClosed(object sender, System.EventArgs e)
        {
        }

        private void DecipherBtn_Click(object sender, EventArgs e)
        {
            ResultTxt.Text = Outlook_Anonymizer.Cipher.Decrypt(MessageTxt.Text, KeyTxt.Text);
        }

        private void CipherBtn_Click(object sender, EventArgs e)
        {
            ResultTxt.Text = Outlook_Anonymizer.Cipher.Encrypt(MessageTxt.Text, KeyTxt.Text);
        }

        private void LoadMsgBtn_Click(object sender, EventArgs e)
        {
            Outlook.Application _Outlook = new Outlook.Application();
            Object selection = _Outlook.ActiveExplorer().Selection[1];
            Outlook.MailItem currentMail = (selection as Outlook.MailItem);
            MessageTxt.Text = currentMail.Body;
        }

        private void ComposeBtn_Click(object sender, EventArgs e)
        {
            Outlook.Application _Outlook = new Outlook.Application();
            Outlook.MailItem mailItem = (Outlook.MailItem)_Outlook.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "";
            mailItem.To = "";
            mailItem.Body = ResultTxt.Text;
            mailItem.Importance = Outlook.OlImportance.olImportanceLow;
            mailItem.Display(true);
        }
    }
}
