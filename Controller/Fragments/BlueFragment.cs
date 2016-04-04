using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace TabbedApp
{
	public class BlueFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// on create functionality goes here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment 
			View view =inflater.Inflate(Resource.Layout.BlueFragmentLayout, container, false); 
			return view;
		}
	}
}

