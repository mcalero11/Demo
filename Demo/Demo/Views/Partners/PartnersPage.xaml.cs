using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo.Models.Partners;

namespace Demo.Views.Partners
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PartnersPage : ContentPage
	{
		public PartnersPage ()
		{
			InitializeComponent ();
		}

        private void lvlORG_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as Demo.Models.Partners.Partners;
            CrossShare.Current.OpenBrowser(Item.Url);
        }
    }
}