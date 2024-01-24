using MonkeysMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysMVVM.ViewModels
{
    internal class MonkeyViewModels : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                OnPropertyChanged();
            }
        }
        private string location;
        public string Location
        {
            get { return this.location; }
            set
            {
                this.location = value;
                OnPropertyChanged();
            }
        }

        private string imageUrl;
        public string ImageUrl
        {
            get { return this.imageUrl; }
            set
            {
                this.imageUrl = value;
                OnPropertyChanged();
            }
        }

        public Command GetMonkeyCommand { get; set; }
        private string locationEntry;
        public string LocationEntry
        {
            get { return this.LocationEntry; }
        }
        private void GetMonkey()
        {
            List<Monkey> monkeys = new List<Monkey>();  

        }

        private int numbersOfMonkeysInLocation;
        public int NumberOfMonkeysInLocation
        {
            get { return this.NumberOfMonkeysInLocation; }
            set { this.numbersOfMonkeysInLocation = value; 
                  OnPropertyChanged(); }
    }
}
