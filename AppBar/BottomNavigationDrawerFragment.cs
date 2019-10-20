using System;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using static Android.App.Notification.MessagingStyle;
using static Android.Support.Design.Widget.BottomNavigationView;

namespace AppBar
{
    public class BottomNavigationDrawerFragment : BottomSheetDialogFragment, IOnNavigationItemSelectedListener
    {
        public BottomNavigationDrawerFragment()
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_bottomsheet, container, false);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {

            if(item.ItemId != null)
            {
                var nav1 = this.Activity.FindViewById(Resource.Id.nav1);
                var nav2 = this.Activity.FindViewById(Resource.Id.nav2);
                var nav3 = this.Activity.FindViewById(Resource.Id.nav3);

            }
            //if(item.ItemId) {
            //    R.id.nav1->context!!.toast(getString(R.string.nav1_clicked))
            //    R.id.nav2->context!!.toast(getString(R.string.nav2_clicked))
            //    R.id.nav3->context!!.toast(getString(R.string.nav3_clicked))
            //}
            return true;
        }
    }
}
