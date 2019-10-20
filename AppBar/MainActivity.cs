using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.BottomAppBar;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using static Android.Support.Design.BottomAppBar.BottomAppBar;

namespace AppBar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        BottomAppBar bottomAppBar;
        bool changeAlignment;
        DrawerLayout drawerLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.Main);
            drawerLayout = FindViewById<DrawerLayout>(Resource.Layout.Main);
            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            bottomAppBar = FindViewById<BottomAppBar>(Resource.Id.bottom_app_bar);
            bottomAppBar.NavigationClick += BottomAppBar_NavigationClick;
            bottomAppBar.MenuItemClick += BottomAppBar_MenuItemClick;
            if (fab != null)
                fab.Click += FabOnClick;
            SetSupportActionBar(bottomAppBar);
        }

        private void BottomAppBar_MenuItemClick(object sender, Android.Support.V7.Widget.Toolbar.MenuItemClickEventArgs e)
        {
            if (drawerLayout.IsDrawerOpen(drawerLayout))
                drawerLayout.CloseDrawer(drawerLayout, true);
            else
                drawerLayout.OpenDrawer(drawerLayout, true);
        }

        private void BottomAppBar_NavigationClick(object sender, Android.Support.V7.Widget.Toolbar.NavigationClickEventArgs e)
        {
            if (drawerLayout.IsDrawerOpen(drawerLayout))
                drawerLayout.CloseDrawer(drawerLayout, true);
            else
                drawerLayout.OpenDrawer(drawerLayout, true);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var inflater = MenuInflater;
            inflater.Inflate(Resource.Menu.menu_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            //item?.SetShowAsAction(ShowAsAction.IfRoom);
            return base.OnOptionsItemSelected(item);
        }


        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            changeAlignment = !changeAlignment;
            Toast toast = Toast.MakeText(this.ApplicationContext, "Hello Xamarin AppBottomBar", ToastLength.Long);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
            if (bottomAppBar != null)
                bottomAppBar.FabAlignmentMode = changeAlignment ? FabAlignmentModeCenter : FabAlignmentModeEnd;
            //Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
            // .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

