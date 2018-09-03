namespace Demo.ViewModels.Agenda
{
    using Models;
    public class AgendaTimeViewModel
    {
        public AgendaDays Days { get; set; }
        public AgendaTimeViewModel(AgendaDays days)
        {
            Days = days;
        }
    }
}
