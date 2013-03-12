```csharp
using KGStatusBar;
...
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
```

## Other Resources

* [Component Documentation](https://github.com/pierceboggan/StatusBar)
* [Source Code Repository](https://github.com/pierceboggan/StatusBar)
