using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace GroceryApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button itemBt = FindViewById<Button>(Resource.Id.itemBtn);
            Button addItemBt = FindViewById<Button>(Resource.Id.addItemBtn);
            Button aboutBt = FindViewById<Button>(Resource.Id.aboutBtn);

            // **********************method one to  action on click

           /* itemBt.Click += delegate
            {
                Toast.MakeText(this, "Hello from ", ToastLength.Short).Show();
                //  Intent itemIntent = new Intent(this, activity_itemlist);
            };*/

            //*************method 2 for action onclick
            itemBt.Click += (sender, e) => {
                //Toast.MakeText(this, "Hello from ", ToastLength.Short).Show();
                var intent = new Intent(this, typeof(LitstItemActivity));
                StartActivity(intent);
            };

            addItemBt.Click += (sender, e) => {
                var intent = new Intent(this, typeof(addItemActivity));
                StartActivity(intent);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}