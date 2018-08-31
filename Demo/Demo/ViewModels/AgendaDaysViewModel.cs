namespace Demo.ViewModels
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

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
            List<AgendaDays> response = new List<AgendaDays>()
            {
                new AgendaDays(){
                    Day = 1,
                    Month = "Enero"

                },
                 new AgendaDays(){
                    Day = 2,
                    Month = "Marzo"

                },
                  new AgendaDays(){
                    Day = 1,
                    Month = "Febreo"

                }

            };
      
           
            MainViewModel.GetInstance.AgendaDaysList = response;
            this.Days = new ObservableCollection<AgendaDaysItemViewModel>(
                this.ToItemViewModel());
        }

        private IEnumerable<AgendaDaysItemViewModel> ToItemViewModel()
        {
            DateTime aDateTime = DateTime.Now;

            return MainViewModel.GetInstance.AgendaDaysList.Select(l => new AgendaDaysItemViewModel
            {
                Day = l.Day,
                Month = l.Month
            });
        }
        #endregion
    }
}
