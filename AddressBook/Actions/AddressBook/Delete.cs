using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleve;
using AddressBook.Models;

namespace AddressBook.Actions.AddressBook
{
    public class Delete : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {

            Address item = ViewModel.SelectedItem;

            ViewModel.Sources.Remove(item);
            ViewModel.Addresses.Remove(item);

            return SuccessTask;
        }
    }
}
