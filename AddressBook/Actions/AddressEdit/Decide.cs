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
            if (!CanDecide(out string message))
            {
                ViewModel.Message = message;
                return SuccessTask;
            }

            Address address = new Address()
            {
                Name = ViewModel.Name,
                Email = ViewModel.Email,
                Belongs = ViewModel.Belongs,
            };

            CloseWindow(WindowCloseType.OK, address);

            return SuccessTask;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private bool CanDecide(out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(ViewModel.Name))
            {
                message = "You must input Name.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(ViewModel.Email))
            {
                message = "You must input Email.";
                return false;
            }


            return true;
        }
    }
}
