using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoLienzo_talleres_.Droid
{
    [Activity(Label = "Splash_activity",Theme = "@style/splashTheme", MainLauncher =true, NoHistory =true, ConfigurationChanges =ConfigChanges.ScreenSize)]
    public class Splash_activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //StartActivity(typeof(MainActivity));
            // Create your application here
        }
    }
}