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
            Address address = obj as Address;
            if (obj != null)
            {
                ViewModel.Name = address.Name;
                ViewModel.Email = address.Email;
                ViewModel.Belongs = address.Belongs;
            }

            return SuccessTask;
        }
    }
}
