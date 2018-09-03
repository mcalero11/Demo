using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.Share;
using Demo.Models.EventInformation;

namespace Demo.ViewModels.EventInformation
{
    public class EventInformationViewModel : BaseViewModel
    {
        public EventInformationViewModel()
        {

        }


        public ICommand EnlaceLocalDinning1 {

            get
            {
                return new Command(() => {primerenlace(); });
            }

        }
        private void primerenlace()
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }

        



    }
}
