using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleve;
using AddressBook.Models;

namespace AddressBook.ViewModels
{
    public class AddressBookViewModel : ViewModelBase
    {
        /// <summary></summary>
        private string _Text;
        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }

        /// <summary></summary>
        public List<Address> Sources { get; set; } = new List<Address>();

        /// <summary></summary>
        private ObservableCollection<Address> _Addresses = new ObservableCollection<Address>();
        public ObservableCollection<Address> Addresses
        {
            get { return _Addresses; }
            set { SetProperty(ref _Addresses, value); }
        }
    }
}
