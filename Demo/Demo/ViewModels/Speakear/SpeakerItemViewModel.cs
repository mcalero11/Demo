namespace Demo.ViewModels.Speaker
{
    using Models;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views.Speakers;

    public class SpeakerItemViewModel : Speakers
    {
        #region Command 
        public ICommand SelectSpeakerCommand
        {
            get
            {
                return new Command(() => {
                    SelectSpeaker();
                });
            }
        }
        public int MyProperty { get; set; }
        private async void SelectSpeaker()
        {
            MainViewModel.GetInstance.SpeakersDetail = new SpeakerDetailViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new DetailPage());
            
        }
        #endregion
    }
}
