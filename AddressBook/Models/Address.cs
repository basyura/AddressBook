using Eleve;

namespace AddressBook.Models
{
    public class Address : NotificationObject
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Belongs { get; set; }
    }
}
