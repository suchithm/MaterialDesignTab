using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace TabbedApp
{
	[Activity (Label = "TabbedApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity, Android.Support.V7.App.ActionBar.ITabListener, IDialogInterfaceOnClickListener
 { 
		//suchith
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			InitActionBar ();
		}
		private void InitActionBar()
		{
			if (SupportActionBar == null)
				return;

			var actionBar = SupportActionBar;
			actionBar.NavigationMode = (int)ActionBarNavigationMode.Tabs;

			var tab1 = actionBar.NewTab();
			tab1.SetTabListener(this);
			tab1.SetText("Red");
			actionBar.AddTab(tab1);

			var tab2 = actionBar.NewTab();
			tab2.SetTabListener(this);
			tab2.SetText("Blue");
			actionBar.AddTab(tab2);

			var tab3 = actionBar.NewTab();
			tab3.SetTabListener(this);
			tab3.SetText("Yellow");
			actionBar.AddTab(tab3);

			if ((int)Build.VERSION.SdkInt >= 21)
			{
				var tab4 = actionBar.NewTab();
				tab4.SetTabListener(this);
				tab4.SetText("Green");
				actionBar.AddTab(tab4);
			}

		}
	
		public void OnTabReselected( Android.Support.V7.App.ActionBar.Tab tab, Android.Support.V4.App.FragmentTransaction ft)
		{
		}

		public void OnTabSelected(Android.Support.V7.App.ActionBar.Tab tab, Android.Support.V4.App.FragmentTransaction ft)
		{
			switch (tab.Text)
			{
			case "Red":
				ft.Replace(Android.Resource.Id.Content, new RedFragment());
				break;
			case "Blue":
				ft.Replace(Android.Resource.Id.Content, new BlueFragment());
				break;
			case "Yellow":
				ft.Replace(Android.Resource.Id.Content, new YellowFragment());
				break;
			case "Green":
				ft.Replace(Android.Resource.Id.Content, new GreenFragment());
				break;
			}
		}

		public void OnTabUnselected(Android.Support.V7.App.ActionBar.Tab tab, Android.Support.V4.App.FragmentTransaction ft)
		{

		}

//		public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
//		{
//			MenuInflater.Inflate(Resource.Menu.main, menu);
//			return base.OnCreateOptionsMenu(menu);
//		}

//		public override bool OnOptionsItemSelected( IMenuItem item)
//		{
//			if(item.ItemId == Resource.Id.about)
//			{
//				var text = (TextView)LayoutInflater.Inflate(Resource.Layout.about_view, null);
//				text.TextFormatted = (Html.FromHtml(GetString(Resource.String.about_body)));
//				new Android.Support.V7.App.AlertDialog.Builder(this)
//					.SetTitle(Resource.String.about)
//					.SetView(text)
//					.SetInverseBackgroundForced(true)
//					.SetPositiveButton(Android.Resource.String.Ok, this).Create().Show();
//			}
//			return base.OnOptionsItemSelected(item);
//		}

		public void OnClick(IDialogInterface dialog, int which)
		{
			dialog.Dismiss();
		}
	} 
}


