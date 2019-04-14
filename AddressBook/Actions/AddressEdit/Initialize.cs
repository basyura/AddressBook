using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleve;

namespace AddressBook.Actions.AddressEdit
{
    public class Initialize : AddressEditActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            return SuccessTask;
        }
    }
}
