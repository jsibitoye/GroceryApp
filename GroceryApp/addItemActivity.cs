using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroceryApp
{
    [Activity(Label = "addItemActivity")]
    public class addItemActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.addItem);
            Button Cancel = FindViewById<Button>(Resource.Id.cancelAdd);
            Cancel.Click += (sender, e) => { Finish(); };

            // Create your application here
        }
    }
}