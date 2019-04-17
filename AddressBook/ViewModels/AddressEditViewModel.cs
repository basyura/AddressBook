using AddressBook.Models;
using Eleve;

namespace AddressBook.ViewModels
{
    public class AddressEditViewModel : ViewModelBase
    {
        /// <summary>
        /// 
        /// </summary>
        private string _Message;
        public string Message
        {
            get { return _Message; }
            set { SetProperty(ref _Message, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private Address _Address = new Address();
        public Address Address
        {
            get { return _Address; }
            set { SetProperty(ref _Address, value); }
        }
    }
}
