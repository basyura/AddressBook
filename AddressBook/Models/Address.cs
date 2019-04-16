using Eleve;

namespace AddressBook.Models
{
    public class Address : NotificationObject
    {
        /// <summary>
        /// 
        /// </summary>
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _Belongs;
        public string Belongs
        {
            get { return _Belongs; }
            set { SetProperty(ref _Belongs, value); }
        }
    }
}
