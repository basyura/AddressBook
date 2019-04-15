using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows.Controls;
using AddressBook.Models;
using Eleve;
using Newtonsoft.Json;

namespace AddressBook.ViewModels
{
    public class AddressBookViewModel : ViewModelBase
    {
        /// <summary></summary>
        private string JsonPath { get { return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "address.json"); } }

        /// <summary></summary>
        private string _Text;
        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }

        /// <summary></summary>
        public List<Address> Sources { get; set; } = new List<Address>();

        /// <summary></summary>
        private ObservableCollection<Address> _Addresses = new ObservableCollection<Address>();
        public ObservableCollection<Address> Addresses
        {
            get { return _Addresses; }
            set { SetProperty(ref _Addresses, value); }
        }

        /// <summary></summary>
        public Address _SelectedItem;
        public Address SelectedItem
        {
            get { return _SelectedItem; }
            set { SetProperty(ref _SelectedItem, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public void FocusToNarrowText()
        {
            GetElement<TextBox>("NarrowTextBox").Focus();
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Load()
        {
            if (!File.Exists(JsonPath))
            {
                return false;
            }

            using (StreamReader reader = new StreamReader(JsonPath))
            {
                string json = reader.ReadToEnd();
                List<Address> sourecs = JsonConvert.DeserializeObject<List<Address>>(json);
                Sources = sourecs;
                Addresses = new ObservableCollection<Address>(sourecs);
            }

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            string json = JsonConvert.SerializeObject(Sources, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter(JsonPath, false))
            {
                writer.Write(json);
            }
        }
    }
}
