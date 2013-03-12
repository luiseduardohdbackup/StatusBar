using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using KGStatusBar;

namespace Sample
{
	public partial class SampleViewController : UIViewController
	{
		public SampleViewController () : base ("SampleViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();

			Console.WriteLine ("Memory warning received!");
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			ShowButton.TouchUpInside += delegate(object sender, EventArgs e) {
				Console.WriteLine ("StatusBar.ShowWithStatus () called!");
				StatusBar.ShowWithStatus ("Loading...");
			};

			ShowErrorButton.TouchUpInside += delegate(object sender, EventArgs e) {
				Console.WriteLine ("StatusBar.ShowErrorWithStatus () called!");
				StatusBar.ShowErrorWithStatus ("Loading failed!");
			};

			ShowSuccessButton.TouchUpInside += delegate(object sender, EventArgs e) {
				Console.WriteLine ("StatusBar.ShowSuccessWithStatus () called!");
				StatusBar.ShowSuccessWithStatus ("Loading succeeded!");
			};

			DismissButton.TouchUpInside += delegate(object sender, EventArgs e) {
				Console.WriteLine ("StatusBar.Dismiss () called!");
				StatusBar.Dismiss ();
			};
		}
	}
}

