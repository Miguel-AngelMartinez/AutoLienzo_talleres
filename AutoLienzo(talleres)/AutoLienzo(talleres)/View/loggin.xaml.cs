using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoLienzo_talleres.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class loggin : ContentPage
	{
		public loggin ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}
	}
}