using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Copy : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs e, object obj)
        {
            try
            {
                Clipboard.SetText(ViewModel.SelectedItem.Email);
            }
            catch
            {

            }
            return SuccessTask;
        }
    }
}
