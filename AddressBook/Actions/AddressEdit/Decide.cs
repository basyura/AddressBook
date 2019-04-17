using System;
using System.Threading.Tasks;
using AddressBook.Models;
using Eleve;

namespace AddressBook.Actions.AddressEdit
{
    public class Decide : AddressEditActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            Address address = ViewModel.Address;
            if (!CanDecide(address, out string message))
            {
                ViewModel.Message = message;
                return SuccessTask;
            }

            CloseWindow(WindowCloseType.OK, address);

            return SuccessTask;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private bool CanDecide(Address address, out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(address.Name))
            {
                message = "You must input Name.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(address.Email))
            {
                message = "You must input Email.";
                return false;
            }

            return true;
        }
    }
}
