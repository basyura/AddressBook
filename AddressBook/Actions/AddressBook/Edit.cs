using System;
using System.Linq;
using System.Threading.Tasks;
using AddressBook.Models;
using AddressBook.Views;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Edit : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {

            Address address =  ViewModel.SelectedItem;

            OpenDialogWindow<AddressEditView>(address, (type, o) =>
            {
                Address result = o as Address;

                if (result == null)
                {
                    return;
                }

                Address source = ViewModel.Sources.FirstOrDefault(v => v.Email == result.Email);
                if (source == null)
                {
                    ViewModel.Sources.Add(result);
                    ViewModel.Addresses.Add(result);
                }
                else
                {
                    source.Name = result.Name;
                    source.Belongs = result.Belongs;
                }
            });

            return SuccessTask;
        }
    }
}
