using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Speakers
    {
        
        public long SpeakerId { get; set; }

        
        public long ConferenceId { get; set; }

        
        public string FullName { get; set; }

        
        public string ListName { get; set; }

        
        public string ListTitle { get; set; }

        
        public string PresenterName { get; set; }

       
        public bool HasAvatar { get; set; }

        
        public string AvatarLocation { get; set; }

        
        public bool HasPhoto { get; set; }

        
        public string PhotoLocation { get; set; }

       
        public string Bio { get; set; }

       
        public long ListOrder { get; set; }
    }
}
