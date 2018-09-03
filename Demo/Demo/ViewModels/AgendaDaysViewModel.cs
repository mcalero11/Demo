namespace Demo.ViewModels
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class AgendaDaysViewModel : BaseViewModel
    {
        public AgendaDaysViewModel()
        {
            LoadDays();
        }
        private ObservableCollection<AgendaDaysItemViewModel> days;

        public ObservableCollection<AgendaDaysItemViewModel> Days
        {
            get
            {
                return days;
            }
            set
            {
                SetValue(ref days, value);
            }
        }
        #region Methods
        private void LoadDays()
        {
            IsBusy = true;
            List<AgendaDays> response = new List<AgendaDays>()
            {
                new AgendaDays(){
                    TopBarTitle = "Monday,Sept 11",
                    DayOfWeek = "Monday",
                    DateTitle = "September 11"

                },
                 new AgendaDays(){
                    TopBarTitle = "Tuesday,Sept 12",
                    DayOfWeek = "Tuesday",
                    DateTitle = "September 12"

                },
                  new AgendaDays(){
                   TopBarTitle = "Wednesday,Sept 13",
                   DayOfWeek = "Wednesday",
                    DateTitle = "September 13"

                }

            };


            MainViewModel.GetInstance.AgendaDaysList = response;
            this.Days = new ObservableCollection<AgendaDaysItemViewModel>(
                this.ToItemViewModel());
            IsBusy = false;
        }

        private IEnumerable<AgendaDaysItemViewModel> ToItemViewModel()
        {

            return MainViewModel.GetInstance.AgendaDaysList.Select(l => new AgendaDaysItemViewModel
            {
                DayOfWeek = l.DayOfWeek,
                DateTitle = l.DateTitle
            });
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(() => {
                    LoadDays();
                });
            }
        }
        #endregion
    }
}
