using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using AddressBook.Models;
using Eleve;

namespace AddressBook.Actions.AddressBook
{
    public class Narrow : AddressBookActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs e, object obj)
        {
            KeyEventArgs ev = e as KeyEventArgs;

            if (((Keyboard.Modifiers & ModifierKeys.Control) != ModifierKeys.None) && ev.Key == Key.H)
            {
                System.Windows.Forms.SendKeys.SendWait("{BackSpace}");
                return SuccessTask;
            }

            if (string.IsNullOrEmpty(ViewModel.Text))
            {
                ViewModel.Addresses = new ObservableCollection<Address>(ViewModel.Sources);
            }
            else
            {
                IEnumerable<Address> targets = ViewModel.Sources.Where(v => v.Email.Contains(ViewModel.Text));
                ViewModel.Addresses = new ObservableCollection<Address>(targets);
            }

            return SuccessTask;
        }
    }
}