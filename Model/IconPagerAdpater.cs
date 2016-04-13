using System;
using Android.Support.V4.App;
using Java.Lang;

namespace TabbedApp
{
	public class IconPagerAdpater :FragmentPagerAdapter
	{
		private readonly Fragment[] fragments;
 

		public IconPagerAdpater(FragmentManager fm, Fragment[] fragments) : base(fm)
		{
			this.fragments = fragments; 
		}
		public override int Count
		{
			get
			{
				return fragments.Length;
			}
		}

		public override Fragment GetItem(int position)
		{
			return fragments[position];
		}

		public override ICharSequence GetPageTitleFormatted(int position)
		{ 
			return null;
		}
	}
}

