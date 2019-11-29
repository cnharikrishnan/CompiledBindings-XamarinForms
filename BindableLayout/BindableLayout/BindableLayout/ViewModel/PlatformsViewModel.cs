using BindableLayout.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BindableLayout.ViewModel
{
    public class PlatformsViewModel
    {
        public PlatformsViewModel()
        {
            this.GetContactsList();
        }

        public List<PlatformInfo> PlatformsList { get; set; }

        private void GetContactsList()
        {
            if (this.PlatformsList == null)
                this.PlatformsList = new List<PlatformInfo>();

            this.PlatformsList.Add(new PlatformInfo() { IsChecked = true, PlatformName = "Android" });
            this.PlatformsList.Add(new PlatformInfo() { IsChecked = true, PlatformName = "iOS" });
            this.PlatformsList.Add(new PlatformInfo() { IsChecked = false, PlatformName = "UWP" });
        }
    }
}
