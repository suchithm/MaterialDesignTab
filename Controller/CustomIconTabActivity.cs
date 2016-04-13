
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;

namespace TabbedApp
{
	[Activity (Label = "Icon Tab")]			
	public class IconTabActivity : AppCompatActivity
	{
		TabLayout tabLayout;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		//	SetContentView (Resource.Layout.CustomIconTabLayout);
			tabLayout=FindViewById<TabLayout>(Resource.Id.sliding_tabsIcon);  
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
			var viewPager = FindViewById<ViewPager>(Resource.Id.viewpagerIcon);
			//viewpager holding fragment array and tab title text
			viewPager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, fragments,titles);

			// Give the TabLayout the ViewPager 
			tabLayout.SetupWithViewPager(viewPager); 
			//tabLayout.SetTabTextColors(
			FnSetIcons();
		} 
		void FnSetIcons()
		{ 
			tabLayout.GetTabAt (0).SetIcon (Resource.Drawable.ic_edit);
			tabLayout.GetTabAt (1).SetIcon (Resource.Drawable.ic_messages);
			tabLayout.GetTabAt (2).SetIcon (Resource.Drawable.ic_messages); 
		}

	}
}

