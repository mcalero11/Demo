namespace Demo.Models
{
    public class OnBoarding
    {
        public string Image { get; set; }
        public string Description { get; set; }

        public OnBoarding(string image,string descrip)
        {
            Image = image;
            Description = descrip;
        }
    }
}
