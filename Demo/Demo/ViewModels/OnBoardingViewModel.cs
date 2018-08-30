﻿
namespace Demo.ViewModels
{
    using Models;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class OnBoardingViewModel : BaseViewModel
    {
        private ObservableCollection<Slide> slide;

        public ObservableCollection<Slide> Slides
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
            Slides = new ObservableCollection<Slide>(new[]
            {
                new Slide("landing01.png","Some description for slide one."),
                new Slide("landing02.png", "Some description for slide two."),
                new Slide("landing03.png","Some description for slide three.")
            });
        }

        private async void Skip()
        {
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
