using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.Partners
{
    public class Partners
    {
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public List<Partners> GetPartners()
        {
            return new List<Partners>
            {
                new Partners
                {
                    Photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/US-AlcoholTobaccoFirearmsAndExplosives-Seal.svg/2000px-US-AlcoholTobaccoFirearmsAndExplosives-Seal.svg.png",
                    Title = "Boreau of Alcohol, Tobacco, Firearms and Explosives (ATF)",
                    Url = ("https://www.atf.gov/")
           
                },
                new Partners
                {
                    Photo = "https://vignette.wikia.nocookie.net/blindspot/images/1/1b/DEA_logo.png/revision/latest?cb=20170519212558",
                    Title = "U.S. Departament of Justice, Drug Enforcement Administration (DEA)",
                    Url = ("https://www.dea.gov/")
                },
                new Partners
                {
                    Photo = "https://www.levinlaw.com/sites/default/files/images/doj.jpg",
                    Title = "Executive Office for Unitd States Attorneys (EOUSA)",
                    Url= ("https://www.justice.gov/usao/eousa")
                },
                new Partners
                {
                    Photo = "https://i.4pcdn.org/hr/1485210787746.png",
                    Title = "Federal Bureau of Investigation (FBI)",
                    Url= ("https://www.fbi.gov")
                },
                new Partners
                {
                    Photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Seal_of_the_United_States_Marshals_Service.svg/2000px-Seal_of_the_United_States_Marshals_Service.svg.png",
                    Title = "U.S. Marshals Service (USMS)",
                    Url= ("https://www.usmarshals.gov")
                },
                new Partners
                {
                    Photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/US-OfficeOfJusticePrograms-Seal.svg/1200px-US-OfficeOfJusticePrograms-Seal.svg.png",
                    Title = "Office of Justice Programs (OJP)",
                    Url= ("https://ojp.gov")
                },
                new Partners
                {
                    Photo = "https://upload.wikimedia.org/wikipedia/commons/7/75/Us_DOJ_COPS_logo.png",
                    Title = "The Office of Community Oriented Policing Services (COPS)",
                    Url= ("https://cops.usdoj.gov")
                },
                new Partners
                {
                    Photo = "https://sapac.umich.edu/files/sapac/field/image/OVW-home.png",
                    Title = "Office on Violence Against Women (OVW)",
                    Url= ("https://www.justice.gov/ovw")
                }
                
            };
        }
    }
}
