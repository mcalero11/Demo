namespace Demo.ViewModels
{
    using Models;
    using ViewModels.Partners;
    using System.Collections.Generic;

    public class MainViewModel
    {
        #region Properties
        public List<OnBoarding> OnBoardingList
        {
            get;
            set;
        }
        public List<AgendaDays> AgendaDaysList
        {
            get;
            set;
        }
        #endregion

        #region ViewModels
        public OnBoardingViewModel OnBoarding { get; set; }
        public AgendaDaysViewModel AgendaDays { get; set; }
        public AgendaTimeViewModel AgendaTime { get; set; }
        public HomeViewModel Home { get; set; }
        public PartnersPageViewModels Partners { get; set; }
        public EventInformation.EventInformationViewModel Evento { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            OnBoarding = new OnBoardingViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance
        {
            get
            {
                if (instance==null)
                {
                    return new MainViewModel();
                }
                return instance;
            }
        }
        #endregion
    }
}
