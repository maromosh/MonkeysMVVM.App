﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysMVVM
{
    internal class GetMonkeyByTheLocationModelVeiwClass1 : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
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

        private int overAllMonkeys;
        public int OverAllMonkeys
        {
            get { return this.overAllMonkeys; }
            set
            {
                this.overAllMonkeys = value;
                OnPropertyChanged();
            }
        }

        public Command GetMonkeyCommand { get; set; }
        public GetMonkeyByTheLocationModelVeiwClass1()
        {
            
        }

        

    }
}
