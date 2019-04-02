using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AddressBook.Models;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Initialize : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs evnt, object parameter)
        {
            ViewModel.Sources.Add(new Address { Email = "hoge@fuga.com", Name = "cat" });
            ViewModel.Sources.Add(new Address { Email = "goga@hooo.com", Name = "dog" });

            ViewModel.Addresses = new ObservableCollection<Address>(ViewModel.Sources);


            return SuccessTask;
        }
    }
}
