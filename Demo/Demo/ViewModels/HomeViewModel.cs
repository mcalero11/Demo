namespace Demo.ViewModels
{
    using Views.Agenda;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views.Partners;
    using Views.EventInformation;

    public class HomeViewModel
    {
        #region Methods
        private async void AgendaDays()
        {

            MainViewModel.GetInstance.AgendaDays = new AgendaDaysViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AgendaDaysPage());
        }



        private async void EventInformation()
        {

            //MainViewModel.GetInstance.AgendaDays = new AgendaDaysViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new EventInformationPage());
        }

        private async void Partners()
        {

            MainViewModel.GetInstance.Partners = new ViewModels.Partners.PartnersPageViewModels();
            await Application.Current.MainPage.Navigation.PushAsync(new PartnersPage());
        }
        #endregion


        #region Commands
        public ICommand EventInformationCommand
        {
            get
            {
                return new Command(() =>
                {
                    EventInformation();
                });
            }
        }

        public ICommand AgendaCommand
        {
            get
            {
                return new Command(() =>
                {
                    AgendaDays();
                });
            }
        }

        public ICommand PartnersCommand
        {
            get
            {
                return new Command(() =>
                {
                    Partners();
                });
            }
        }
        #endregion
    }
}
