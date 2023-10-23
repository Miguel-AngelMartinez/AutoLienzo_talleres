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
    public partial class welcome : ContentPage
    {
        public welcome()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

         async private void button_Clicked(object sender, EventArgs e)
        {
            await screenAsync();
        }

      
         
        
        public async Task screenAsync()
        {
            await Navigation.PushAsync(new loggin());
        }
    }
}