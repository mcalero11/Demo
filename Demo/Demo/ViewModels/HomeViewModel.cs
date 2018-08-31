namespace Demo.ViewModels
{
    using Views.Agenda;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Demo.Views.EventInformation;

    public class HomeViewModel
    { 
        private async void AgendaDays()
        {

            MainViewModel.GetInstance.AgendaDays = new AgendaDaysViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AgendaDaysPage());
        }
        public ICommand AgendaCommand
        {
            get
            {
                return new Command(() => {
                    AgendaDays();
                });
            }
        }

        private async void EventInformation()
        {

            //MainViewModel.GetInstance.AgendaDays = new AgendaDaysViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new EventInformationPage());
        }
        public ICommand EventInformationCommand
        {
            get
            {
                return new Command(() => {
                    EventInformation();
                });
            }
        }
    }
}
