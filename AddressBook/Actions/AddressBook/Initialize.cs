using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Initialize : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs evnt, object parameter)
        {
            return SuccessTask;
        }
    }
}
