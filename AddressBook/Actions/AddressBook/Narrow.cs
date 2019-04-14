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
                return SuccessTask;
            }

            IEnumerable<Address> targets = NarrowAddresses(ViewModel.Sources);
            ViewModel.Addresses = new ObservableCollection<Address>(targets);

            return SuccessTask;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sources"></param>
        /// <returns></returns>
        private IEnumerable<Address> NarrowAddresses(List<Address> sources)
        {
            return sources.Where(v => v.Name.Contains(ViewModel.Text));
        }
    }
}