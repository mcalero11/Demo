using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo.ViewModels.Partners
{
    using Models.Partners;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public class PartnersPageViewModels
    {
        private List<Partners> Partner;

        #region Constructor

        public PartnersPageViewModels()
        {
            var P = new Partners();
            Partner = P.GetPartners();
        }
        #endregion

        #region Propiedades
        public List<Partners> ListPartners
        {
            get { return Partner; } 
        }
        #endregion
    }
}
