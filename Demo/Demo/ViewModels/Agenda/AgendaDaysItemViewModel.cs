namespace Demo.ViewModels.Agenda
{
    using Models;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views.Agenda;

    public class AgendaDaysItemViewModel : AgendaDays
    {
        #region Command 
        public ICommand SelectDayCommand
        {
            get
            {
                return new Command(() => {
                    SelectDay();
                });
            }
        }

        private async void SelectDay()
        {
            MainViewModel.GetInstance.AgendaTime = new AgendaTimeViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new AgendaTimePage());
            
        }
        #endregion
    }
}
