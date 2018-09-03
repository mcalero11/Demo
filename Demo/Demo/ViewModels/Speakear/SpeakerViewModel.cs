namespace Demo.ViewModels.Speaker
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class SpeakerViewModel : BaseViewModel
    {
        public SpeakerViewModel()
        {
            LoadSpeakers();
        }
        private ObservableCollection<SpeakerItemViewModel> speakers;

        public ObservableCollection<SpeakerItemViewModel> SpeakersList
        {
            get
            {
                return speakers;
            }
            set
            {
                SetValue(ref speakers, value);
            }
        }
        #region Methods
        private void LoadSpeakers()
        {
            IsBusy = true;
            var response = new List<Speakers>()
            {
                new Speakers(){
                    SpeakerId = 372,
                    ConferenceId = 12,
                    FullName = "Kristen Mahoney",
                    ListName = "Kristen Mahoney",
                    ListTitle = "Deputy Director for Policy \nBureau of Justice Assistance",
                    PresenterName = "Ms. Kristen Mahoney \n Deputy Director for Policy<br />Bureau of Justice Assistance",
                    HasAvatar = true,
                    AvatarLocation = "https://appservices.iir.com/Images/SpeakerAvatars/347",
                    HasPhoto = true,
                    PhotoLocation = "https://appservices.iir.com/Images/SpeakerBioPhotos/347",
                    Bio = "<p>In July 2012, Ms. Kristen Mahoney started in her position as the Deputy Director for Policy at the Bureau of Justice Assistance (BJA), located within the Office of Justice Programs (OJP) and United States Department of Justice (DOJ). In this role, Ms. Mahoney directs the creation of criminal justice policies that assist state, local, and tribal communities to prevent or reduce crime and violence. She also provides national leadership and outreach on criminal justice issues by identifying and supporting evidence-based programs, best practices, and innovative approaches to key issues. She provides oversight and guidance on criminal justice policy to grantees to ensure that government resources are used effectively and that programs, trainers, technical assistance, publications, and websites reflect BJA, OJP, DOJ, and the White House&rsquo;s goals, policies, and priorities and incorporate the latest scientific research.</p> <p>Prior to assuming the Deputy Director&rsquo;s role, Ms. Mahoney served as the Executive Director of the Governor&rsquo;s Office of Crime Control &amp; Prevention. Ms. Mahoney came to state government after serving as the Chief of Technical Services for the Baltimore Police Department. Prior to her promotion to Chief, she served as the Baltimore Police Department&rsquo;s Director of Grants and Government Relations. In January 2002, while maintaining her command position and responsibilities within the Baltimore Police Department, Ms. Mahoney was appointed to the position of Executive Director of the Mayor&rsquo;s Office of Criminal Justice. This dual role enabled her to directly support the Mayor and the Police Commissioner on public policy issues regarding crime and justice. Prior to joining the Baltimore Police Department, Ms. Mahoney served as a Senior Policy Advisor at DOJ&rsquo;s Office of Community Oriented Policing Services. Ms. Mahoney received her B.A. from Sweet Briar College and her J.D. from the University of Baltimore. She is a member of the Maryland Bar and has practiced law with the Legal Aid Bureau of Maryland, specializing in the representation of abused and neglected children.</p>",
                    ListOrder = 36
                },
                new Speakers(){
                    SpeakerId = 372,
                    ConferenceId = 12,
                    FullName = "Arif Alikhan",
                    ListName = "Arif Alikhan",
                    ListTitle = "Director, Office of Constitutional Policing and Policy Los Angeles, California, Police Department",
                    PresenterName = "Mr. Arif Alikhan \n Director, Office of Constitutional Policing and Policy \n Los Angeles, California, Police Department",
                    HasAvatar = true,
                    AvatarLocation = "https://appservices.iir.com/Images/SpeakerAvatars/348",
                    HasPhoto = true,
                    PhotoLocation = "https://appservices.iir.com/Images/SpeakerBioPhotos/348",
                    Bio = "In July 2012, Ms. Kristen Mahoney started in her position as the Deputy Director for Policy at the Bureau of Justice Assistance (BJA), located within the Office of Justice Programs (OJP) and United States Department of Justice (DOJ). In this role, Ms. Mahoney directs the creation of criminal justice policies that assist state, local, and tribal communities to prevent or reduce crime and violence. She also provides national leadership and outreach on criminal justice issues by identifying and supporting evidence-based programs, best practices, and innovative approaches to key issues. She provides oversight and guidance on criminal justice policy to grantees to ensure that government resources are used effectively and that programs, trainers, technical assistance, publications, and websites reflect BJA, OJP, DOJ, and the White House&rsquo;s goals, policies, and priorities and incorporate the latest scientific research.</p> <p>Prior to assuming the Deputy Director&rsquo;s role, Ms. Mahoney served as the Executive Director of the Governor&rsquo;s Office of Crime Control &amp; Prevention. Ms. Mahoney came to state government after serving as the Chief of Technical Services for the Baltimore Police Department. Prior to her promotion to Chief, she served as the Baltimore Police Department&rsquo;s Director of Grants and Government Relations. In January 2002, while maintaining her command position and responsibilities within the Baltimore Police Department, Ms. Mahoney was appointed to the position of Executive Director of the Mayor&rsquo;s Office of Criminal Justice. This dual role enabled her to directly support the Mayor and the Police Commissioner on public policy issues regarding crime and justice. Prior to joining the Baltimore Police Department, Ms. Mahoney served as a Senior Policy Advisor at DOJ&rsquo;s Office of Community Oriented Policing Services. Ms. Mahoney received her B.A. from Sweet Briar College and her J.D. from the University of Baltimore. She is a member of the Maryland Bar and has practiced law with the Legal Aid Bureau of Maryland, specializing in the representation of abused and neglected children.</p>",
                    ListOrder = 36
                },
                new Speakers(){
                    SpeakerId = 372,
                    ConferenceId = 12,
                    FullName = "Kristen Mahoney",
                    ListName = "Kristen Mahoney",
                    ListTitle = "Deputy Director for Policy \nBureau of Justice Assistance",
                    PresenterName = "Ms. Kristen Mahoney Deputy Director for Policy \n Bureau of Justice Assistance",
                    HasAvatar = true,
                    AvatarLocation = "https://appservices.iir.com/Images/SpeakerAvatars/347",
                    HasPhoto = true,
                    PhotoLocation = "https://appservices.iir.com/Images/SpeakerBioPhotos/347",
                    Bio = "<p>In July 2012, Ms. Kristen Mahoney started in her position as the Deputy Director for Policy at the Bureau of Justice Assistance (BJA), located within the Office of Justice Programs (OJP) and United States Department of Justice (DOJ). In this role, Ms. Mahoney directs the creation of criminal justice policies that assist state, local, and tribal communities to prevent or reduce crime and violence. She also provides national leadership and outreach on criminal justice issues by identifying and supporting evidence-based programs, best practices, and innovative approaches to key issues. She provides oversight and guidance on criminal justice policy to grantees to ensure that government resources are used effectively and that programs, trainers, technical assistance, publications, and websites reflect BJA, OJP, DOJ, and the White House&rsquo;s goals, policies, and priorities and incorporate the latest scientific research.</p> <p>Prior to assuming the Deputy Director&rsquo;s role, Ms. Mahoney served as the Executive Director of the Governor&rsquo;s Office of Crime Control &amp; Prevention. Ms. Mahoney came to state government after serving as the Chief of Technical Services for the Baltimore Police Department. Prior to her promotion to Chief, she served as the Baltimore Police Department&rsquo;s Director of Grants and Government Relations. In January 2002, while maintaining her command position and responsibilities within the Baltimore Police Department, Ms. Mahoney was appointed to the position of Executive Director of the Mayor&rsquo;s Office of Criminal Justice. This dual role enabled her to directly support the Mayor and the Police Commissioner on public policy issues regarding crime and justice. Prior to joining the Baltimore Police Department, Ms. Mahoney served as a Senior Policy Advisor at DOJ&rsquo;s Office of Community Oriented Policing Services. Ms. Mahoney received her B.A. from Sweet Briar College and her J.D. from the University of Baltimore. She is a member of the Maryland Bar and has practiced law with the Legal Aid Bureau of Maryland, specializing in the representation of abused and neglected children.</p>",
                    ListOrder = 36
                },
                new Speakers(){
                    SpeakerId = 372,
                    ConferenceId = 12,
                    FullName = "Kristen Mahoney",
                    ListName = "Kristen Mahoney",
                    ListTitle = "Deputy Director for Policy \nBureau of Justice Assistance",
                    PresenterName = "Ms. Kristen Mahoney Deputy Director for Policy \n Bureau of Justice Assistance",
                    HasAvatar = true,
                    AvatarLocation = "https://appservices.iir.com/Images/SpeakerAvatars/347",
                    HasPhoto = true,
                    PhotoLocation = "https://appservices.iir.com/Images/SpeakerBioPhotos/347",
                    Bio = "<p>In July 2012, Ms. Kristen Mahoney started in her position as the Deputy Director for Policy at the Bureau of Justice Assistance (BJA), located within the Office of Justice Programs (OJP) and United States Department of Justice (DOJ). In this role, Ms. Mahoney directs the creation of criminal justice policies that assist state, local, and tribal communities to prevent or reduce crime and violence. She also provides national leadership and outreach on criminal justice issues by identifying and supporting evidence-based programs, best practices, and innovative approaches to key issues. She provides oversight and guidance on criminal justice policy to grantees to ensure that government resources are used effectively and that programs, trainers, technical assistance, publications, and websites reflect BJA, OJP, DOJ, and the White House&rsquo;s goals, policies, and priorities and incorporate the latest scientific research.</p> <p>Prior to assuming the Deputy Director&rsquo;s role, Ms. Mahoney served as the Executive Director of the Governor&rsquo;s Office of Crime Control &amp; Prevention. Ms. Mahoney came to state government after serving as the Chief of Technical Services for the Baltimore Police Department. Prior to her promotion to Chief, she served as the Baltimore Police Department&rsquo;s Director of Grants and Government Relations. In January 2002, while maintaining her command position and responsibilities within the Baltimore Police Department, Ms. Mahoney was appointed to the position of Executive Director of the Mayor&rsquo;s Office of Criminal Justice. This dual role enabled her to directly support the Mayor and the Police Commissioner on public policy issues regarding crime and justice. Prior to joining the Baltimore Police Department, Ms. Mahoney served as a Senior Policy Advisor at DOJ&rsquo;s Office of Community Oriented Policing Services. Ms. Mahoney received her B.A. from Sweet Briar College and her J.D. from the University of Baltimore. She is a member of the Maryland Bar and has practiced law with the Legal Aid Bureau of Maryland, specializing in the representation of abused and neglected children.</p>",
                    ListOrder = 36
                }

            };


            MainViewModel.GetInstance.SpeakerList = response;
            this.SpeakersList = new ObservableCollection<SpeakerItemViewModel>(
                this.ToItemViewModel());
            IsBusy = false;
        }

        private IEnumerable<SpeakerItemViewModel> ToItemViewModel()
        {

            return MainViewModel.GetInstance.SpeakerList.Select(l => new SpeakerItemViewModel
            {
                FullName = l.FullName,
                ListName = l.ListName,
                ListTitle = l.ListTitle,
                PresenterName = l.PresenterName,
                HasAvatar = l.HasAvatar,
                AvatarLocation = l.AvatarLocation,
                HasPhoto = l.HasPhoto,
                PhotoLocation = l.PhotoLocation,
                Bio = l.Bio
            });
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(() => {
                    LoadSpeakers();
                });
            }
        }
        #endregion
    }
}
