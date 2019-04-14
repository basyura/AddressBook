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
                new Address { Email = "cat@fuga.com", Name = "cat", Belongs="animal" },
                new Address { Email = "dog@hooo.com", Name = "dog", Belongs= "animal"},
                new Address { Email = "hoge@hooo.com", Name = "ほげ", Belongs= "hoge"},
                new Address { Email = "fuga@hooo.com", Name = "ふが", Belongs= "fuga"},
                new Address { Email = "aiueo@hooo.com", Name = "あいうえお", Belongs= "fuga"},
            };

            return addresses;
        }
    }
}
