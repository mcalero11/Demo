namespace Demo.ViewModels
{
    using Views.Agenda;
    using Views.Partners;
    using System.Windows.Input;
    using Xamarin.Forms;
    public class HomeViewModel
    {
        #region Methods
        private async void AgendaDays()
        {

            MainViewModel.GetInstance.AgendaDays = new AgendaDaysViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AgendaDaysPage());
        }




        private async void Partners()
        {

            MainViewModel.GetInstance.Partners = new Partners.PartnersPageViewModels();
            await Application.Current.MainPage.Navigation.PushAsync(new PartnersPage());
        } 
        #endregion


        public ICommand AgendaCommand
        {
            get
            {
                return new Command(() => {
                    AgendaDays();
                });
            }
        }

        public ICommand PartnersCommand
        {
            get
            {
                return new Command(() => {
                    Partners();
                });
            }
        }
    }
}
