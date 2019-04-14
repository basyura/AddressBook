using System;
using System.Threading.Tasks;
using AddressBook.Models;
using AddressBook.Views;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Add : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            OpenDialogWindow<AddressEditView>(null, (type, o) =>
            {
                if (WindowCloseType.OK != type)
                {
                    return;
                }

                Address address = o as Address;

                ViewModel.Sources.Add(address);
                ViewModel.Addresses.Add(address);
            });


            return SuccessTask;
        }
    }
}
