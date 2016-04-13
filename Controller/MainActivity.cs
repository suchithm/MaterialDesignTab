using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Runtime;
using Android.Support.V4.View; 
using Android.Support.Design.Widget;
using Android.Support.V4.App;

namespace TabbedApp
{
	[Activity (Label = "TabbedApp",Icon = "@mipmap/icon",MainLauncher=true)]
	public class MainActivity : FragmentActivity
	{ 
		TabLayout tabLayout;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState); 
			SetContentView (Resource.Layout.Main); 
 
			tabLayout=FindViewById<TabLayout>(Resource.Id.sliding_tabs); 
			FnInitTabLayout (); 
		}
		void FnInitTabLayout()
		{
			tabLayout.SetTabTextColors (Android.Graphics.Color.Aqua,Android.Graphics.Color.AntiqueWhite);
			//Fragment array
			var fragments = new Android.Support.V4.App.Fragment[]
			{ 
				new BlueFragment(),
				new GreenFragment(),
				new YellowFragment(), 
			}; 
			//Tab title array
			var titles = CharSequence.ArrayFromStringArray (new[] { 
				"Blue",
				"Green",
				"Yellow", 
			});

			var viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
			//viewpager holding fragment array and tab title text
			viewPager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, fragments, titles);

			// Give the TabLayout the ViewPager 
			tabLayout.SetupWithViewPager(viewPager); 
			//tabLayout.SetTabTextColors( 
		} 
	
		public void OnClick(IDialogInterface dialog, int which)
		{
			dialog.Dismiss();
		}

	} 
}