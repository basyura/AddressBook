using System;
using System.Threading.Tasks;
using AddressBook.Models;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Delete : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            Address item = ViewModel.SelectedItem;

            ViewModel.Sources.Remove(item);
            ViewModel.Addresses.Remove(item);

            ViewModel.Save();

            return SuccessTask;
        }
    }
}
