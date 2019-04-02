using System;
using System.Threading.Tasks;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Hello : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs e, object obj)
        {
            ViewModel.Message = "World";

            return SuccessTask;
        }
    }
}