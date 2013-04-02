Success, errors, and everything in-between can easily be seen in this minimal status bar for iOS. The functionality has been featured in applications like Mailbox.app.

```csharp
using KGStatusBar;
...

// Shows the status bar with that status listed
// Note: You must dismiss ShowWithStatus with the Dismiss method.
StatusBar.ShowWithStatus ("Status message!");

// Dismisses the status bar; only has to be done with ShowWithStatus
StatusBar.Dismiss ();

// Shows the status bar with a success message; does not have to be dismissed
StatusBar.ShowSuccessWithStatus ("Success message!");

// Shows the status bar with an error message; does not have to be dismissed
StatusBar.ShowErrorWithStatus ("Error message!");
```

## Other Resources
* [Component Documentation](https://github.com/pierceboggan/StatusBar)
* [Source Code Repository](https://github.com/pierceboggan/StatusBar)

### Special Thanks
Kevin Gibbons of Attachments.me is responsible for writing the Objective-C version of StatusBar.