using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace AndroidLab4
{
    [Activity(NoHistory = true, Label = "MainHorizontal",/* ScreenOrientation = ScreenOrientation.SensorLandscape*/  ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class MainHorizontal : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Horizontal);
           
            // Create your application here
        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            if (newConfig.Orientation == Android.Content.Res.Orientation.Portrait)
            {
                StartActivity(typeof(MainActivity));
                //finish();
            }
            else if (newConfig.Orientation == Android.Content.Res.Orientation.Landscape)
            {
               
            }
        }
    }
}