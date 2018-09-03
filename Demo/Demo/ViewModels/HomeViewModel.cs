namespace Demo.ViewModels
{
    
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views.Agenda;
    using Views.Partners;
    using Views.EventInformation;
    using Views.Speakers;

    public class HomeViewModel
    {
        #region Methods
        private async void AgendaDays()
        {

            MainViewModel.GetInstance.AgendaDays = new Agenda.AgendaDaysViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AgendaDaysPage());
        }



        private async void EventInformation()
        {

            MainViewModel.GetInstance.Evento = new EventInformation.EventInformationViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new EventInformationPage());
        }

        private async void Partners()
        {

            MainViewModel.GetInstance.Partners = new Partners.PartnersPageViewModels();
            await Application.Current.MainPage.Navigation.PushAsync(new PartnersPage());
        }

        private async void Speakers()
        {

            MainViewModel.GetInstance.Speakers = new Speaker.SpeakerViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new SpeakersPage());
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

        public ICommand SpeakersCommand
        {
            get
            {
                return new Command(() =>
                {
                    Speakers();
                });
            }
        }
        #endregion
    }
}
