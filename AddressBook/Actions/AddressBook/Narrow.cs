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
            //if (ev.Key == Key.H && ModifierKeys & Key.DbeEnterDialogConversionMode
            //{
            //}
            if (((Keyboard.Modifiers & ModifierKeys.Control) != ModifierKeys.None) && ev.Key == Key.H)
            {
                //ViewModel.Text = ViewModel.Text.Substring(0, ViewModel.Text.Length - 1);
                //System.Windows.Forms.SendKeys.SendWait("{Delete}");
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