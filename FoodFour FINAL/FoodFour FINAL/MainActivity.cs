using Android.App;
using Android.Widget;
using Android.OS;

namespace FoodFour_FINAL
{
    [Activity(Label="FoodFour",MainLauncher = true,Icon ="@drawable/logo_icon",ScreenOrientation =Android.Content.PM.ScreenOrientation.SensorLandscape)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);
        }
    }
}

