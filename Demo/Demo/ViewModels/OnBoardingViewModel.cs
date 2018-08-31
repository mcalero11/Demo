
namespace Demo.ViewModels
{
    using Models;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class OnBoardingViewModel : BaseViewModel
    {
        private ObservableCollection<OnBoarding> slide;

        public ObservableCollection<OnBoarding> Slides
        {
            get
            {
                return slide;
            }
            set
            {
                SetValue(ref slide, value);
            }
        }

        public OnBoardingViewModel()
        {
            Slides = new ObservableCollection<OnBoarding>
            {
               new OnBoarding("landing01","Texto 1"),
               new OnBoarding("landing02","Texto 2"),
               new OnBoarding("landing03","Texto 3")

            };
        }

        private async void Skip()
        {
            MainViewModel.GetInstance.Home = new HomeViewModel();
           await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
            
        }
        public ICommand SkipCommand
        {
            get
            {
                return new Command(() => {
                    Skip();
                });
            }
        }
    }
}
