StatusBar is a minimal status bar for iOS. It has been seen in some apps like Mailbox.app. 

### Requirements
The only requirement for using StatusBar (besides being limited to iOS) is the minimum iOS version must be iOS 4.3 or higher.

### Setup
Prior to use, add a using directive at the top of the class you are wishing to use StatusBar in.

```csharp
using KGStatusBar;
```

Common Pitfall: The using directive for StatusBar is KGStatusBar, **not** StatusBar. This is in-part to give credit to the original author of StatusBar.

### Usage
```csharp
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