using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BindableLayout.Model
{
    public class PlatformInfo : INotifyPropertyChanged
    {
        private bool _isChecked;
        private string _platformName;

        public bool IsChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; NotifyPropertyChanged(); }
        }
        public string PlatformName
        {
            get { return _platformName; }
            set { _platformName = value; NotifyPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
