using AutoLienzo_talleres.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoLienzo_talleres_
{
    public partial class MainPage : ContentPage
    {
        public int segundero=0;
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            InitializeAsync();
        }
        private async void InitializeAsync()
        {
            await screenAsync();
        }
        public async Task screenAsync()
        {
            await Navigation.PushAsync(new welcome());
        }
       
    }
}
