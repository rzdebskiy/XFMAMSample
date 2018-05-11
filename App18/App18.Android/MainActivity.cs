using System;
using Android.Net;
using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.OS;
using Android.Util;
using Android.Content;
using Android.App.Assist;

namespace App18.Droid
{
    [Activity(Label = "App18", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //protected override void OnCreate(Bundle bundle)
        //{
        //    TabLayoutResource = Resource.Layout.Tabbar;
        //    ToolbarResource = Resource.Layout.Toolbar;

        //    base.OnCreate(bundle);

        //    global::Xamarin.Forms.Forms.Init(this, bundle);
        //    LoadApplication(new App());
        //}
        const string TAG = "MainActivity";

        protected override void OnMAMCreate(Bundle bundle)
        {
            Log.Info(TAG, "OnMAMCreate");
            base.OnMAMCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App18.App());
        }

        protected override void OnMAMActivityResult(int i, Result j, Intent intent)
        {
            Log.Info(TAG, "OnMAMActivityResult");
            base.OnMAMActivityResult(i, j, intent);
        }

        protected override void OnMAMDestroy()
        {
            Log.Info(TAG, "OnMAMDestroy");
            base.OnMAMDestroy();
        }

        protected override void OnMAMPause()
        {
            Log.Info(TAG, "OnMAMPause");
            base.OnMAMPause();
        }

        protected override void OnMAMResume()
        {
            Log.Info(TAG, "OnMAMResume");
            base.OnMAMResume();
        }

        protected override void OnMAMNewIntent(Intent intent)
        {
            Log.Info(TAG, "OnMAMNewIntent");
            base.OnMAMNewIntent(intent);
        }

        public override void OnMAMPostCreate(Bundle p0)
        {
            Log.Info(TAG, "OnMAMPostCreate");
            base.OnMAMPostCreate(p0);
        }

        public override void OnMAMPostResume()
        {
            Log.Info(TAG, "OnMAMPostResume");
            base.OnMAMPostResume();
        }

        public override void OnMAMProvideAssistContent(AssistContent p0)
        {
            Log.Info(TAG, "OnMAMProvideAssistContent");
            base.OnMAMProvideAssistContent(p0);
        }

        public override void OnMAMSaveInstanceState(Bundle p0)
        {
            Log.Info(TAG, "OnMAMSaveInstanceState");
            base.OnMAMSaveInstanceState(p0);
        }

        public override void OnMAMStateNotSaved()
        {
            Log.Info(TAG, "OnMAMStateNotSaved");
            base.OnMAMStateNotSaved();
        }

        public override bool OnMAMPrepareOptionsMenu(IMenu p0)
        {
            Log.Info(TAG, "OnMAMPrepareOptionsMenu");
            return base.OnMAMPrepareOptionsMenu(p0);
        }

        public override bool OnMAMSearchRequested(SearchEvent p0)
        {
            Log.Info(TAG, "OnMAMSearchRequested");
            return base.OnMAMSearchRequested(p0);
        }

        public override Android.Net.Uri OnMAMProvideReferrer()
        {
            Log.Info(TAG, "OnMAMProvideReferrer");
            return base.OnMAMProvideReferrer();
        }

    }
}

