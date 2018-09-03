namespace Demo.ViewModels.Speaker
{
    using Models;
    public class SpeakerDetailViewModel
    {
        public Speakers Detail { get; set; }
        public SpeakerDetailViewModel(Speakers detail)
        {
            Detail = detail;
        }
    }
}
