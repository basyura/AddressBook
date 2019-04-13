using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using AddressBook.Models;
using Eleve;

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

        /// <summary></summary>
        public Address _SelectedItem;
        public Address SelectedItem
        {
            get { return _SelectedItem; }
            set { SetProperty(ref _SelectedItem, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public void FocusToNarrowText()
        {
            GetElement<TextBox>("NarrowTextBox").Focus();
        }
    }
}
