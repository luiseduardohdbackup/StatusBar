// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Sample
{
	[Register ("SampleViewController")]
	partial class SampleViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton ShowSuccessButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ShowErrorButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ShowButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton DismissButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ShowSuccessButton != null) {
				ShowSuccessButton.Dispose ();
				ShowSuccessButton = null;
			}

			if (ShowErrorButton != null) {
				ShowErrorButton.Dispose ();
				ShowErrorButton = null;
			}

			if (ShowButton != null) {
				ShowButton.Dispose ();
				ShowButton = null;
			}

			if (DismissButton != null) {
				DismissButton.Dispose ();
				DismissButton = null;
			}
		}
	}
}
