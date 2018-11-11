using System;
using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.OS;
using Droid.Implementation;

namespace GlobalTouch.Droid
{
    [Activity(Label = "GlobalTouch", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Xamarin.Forms.DependencyService.Register<GlobalTouchImplementation>();

            LoadApplication(new App());
        }

        public EventHandler globalTouchHandler;
        public override bool DispatchTouchEvent(MotionEvent ev)
        {
            if (ev.Action == MotionEventActions.Up)
            {
                globalTouchHandler?.Invoke(null, null);
            }
            return base.DispatchTouchEvent(ev);
        }
    }
}

