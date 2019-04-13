using System;
using System.Collections.Generic;
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
            IEnumerable<Address> addresses = LoadAddresses();

            ViewModel.Sources = new List<Address>(addresses);
            ViewModel.Addresses = new ObservableCollection<Address>(ViewModel.Sources);

            ViewModel.FocusToNarrowText();


            return SuccessTask;
        }
        /// <summary>
        /// 
        /// </summary>
        private IEnumerable<Address> LoadAddresses()
        {
            List<Address> addresses = new List<Address>()
            {
                new Address { Email = "hoge@fuga.com", Name = "cat", Belongs="animal" },
                new Address { Email = "goga@hooo.com", Name = "dog", Belongs= "animal"},
            };

            return addresses;
        }
    }
}
