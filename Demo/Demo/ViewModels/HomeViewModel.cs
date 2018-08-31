namespace Demo.ViewModels
{
    using Views.Agenda;
    using System.Windows.Input;
    using Xamarin.Forms;
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
    }
}
