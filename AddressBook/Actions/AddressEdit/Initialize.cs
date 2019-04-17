using System;
using System.Threading.Tasks;
using AddressBook.Models;
using Eleve;

namespace AddressBook.Actions.AddressEdit
{
    public class Initialize : AddressEditActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            if (obj is Address address)
            {
                ViewModel.Address = address;
            }

            return SuccessTask;
        }
    }
}
