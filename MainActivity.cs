using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace AndroidLab4
{
    [Activity(NoHistory = true, Label = "AndroidLab4", MainLauncher = true, Icon = "@drawable/icon", /*ScreenOrientation = ScreenOrientation.Portrait,*/ ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            //var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;
            //if (surfaceOrientation == SurfaceOrientation.Rotation90 || surfaceOrientation == SurfaceOrientation.Rotation270)
            //{
            //    StartActivity(typeof(MainHorizontal));
            //}
        }
        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            if (newConfig.Orientation == Android.Content.Res.Orientation.Portrait)
            {

            }
            else if (newConfig.Orientation == Android.Content.Res.Orientation.Landscape)
            {
                StartActivity(typeof(MainHorizontal));
            }
        }
    }
}

