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
	[Activity (Label = "TabbedApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : FragmentActivity
	{ 
		TabLayout tabLayout;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState); 
			SetContentView (Resource.Layout.Main);
//			var ft = SupportFragmentManager.BeginTransaction ();
//			ft.AddToBackStack (null);
//			ft.Add (Resource.Id.HomeFrameLayout,new BlueFragment ());
//			ft.Commit ();

			// Init toolbar
			var toolbar = FindViewById<Toolbar>(Resource.Id.app_bar); 
			tabLayout=FindViewById<TabLayout>(Resource.Id.sliding_tabs);
//			SetSupportActionBar(toolbar);
//			SupportActionBar.SetTitle (Resource.String.app_name);
//			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
//			SupportActionBar.SetDisplayShowHomeEnabled(true);

			FnInitTabLayout ();
			FnClickEvents ();
		}
		void FnInitTabLayout()
		{
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
		void FnClickEvents()
		{
			//set tab text color
			tabLayout.SetTabTextColors(-1,-70);

//			tabLayout.TabSelected += (object sender, TabLayout.TabSelectedEventArgs e) => {   
//				switch (e.Tab.Text) {
//				//
//				case "Blue" :  
//					var ft = SupportFragmentManager.BeginTransaction ();
//					ft.AddToBackStack (null);
//					ft.Add (Resource.Id.HomeFrameLayout,new GreenFragment (),"blue_frag_tag");
//					//ft.Add (Resource.Id.HomeFrameLayout,new BlueFragment ());
//					ft.Commit ();    
//					break;
//				case "Green":
//					var ftGreen = SupportFragmentManager.BeginTransaction ();
//					ftGreen.AddToBackStack (null); 
//					ftGreen.Add (Resource.Id.HomeFrameLayout,new GreenFragment (),"green_frag_tag");
//					ftGreen.Commit ();  
//					break; 
//
//				case "Yellow":
//					var ftYellow = SupportFragmentManager.BeginTransaction ();
//					ftYellow.AddToBackStack (null);
//					ftYellow.Add (Resource.Id.HomeFrameLayout,new YellowFragment (),"yellow_frag_tag");
//					ftYellow.Commit ();    
//					break; 				 
//				}
//			};
		}
		public void OnClick(IDialogInterface dialog, int which)
		{
			dialog.Dismiss();
		}
	} 
}


