using System;
using System.Drawing;
using MonoTouch.CoreGraphics;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace KGStatusBar
{
	[BaseType (typeof (UIView), Name = "KGStatusBar")]
	interface StatusBar
	{
		[Static, Export ("showWithStatus:")]
		void ShowWithStatus (string status);

		[Static, Export ("showErrorWithStatus:")]
		void ShowErrorWithStatus (string status);

		[Static, Export ("showSuccessWithStatus:")]
		void ShowSuccessWithStatus (string status);

		[Static, Export ("dismiss")]
		void Dismiss ();
	}
}