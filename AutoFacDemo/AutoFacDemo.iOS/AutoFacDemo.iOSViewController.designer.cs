// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace AutoFacDemo.iOS
{
	[Register ("AutoFacDemo_iOSViewController")]
	partial class AutoFacDemo_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel containerLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel passwordLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel platformLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel userNameLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (containerLabel != null) {
				containerLabel.Dispose ();
				containerLabel = null;
			}
			if (passwordLabel != null) {
				passwordLabel.Dispose ();
				passwordLabel = null;
			}
			if (platformLabel != null) {
				platformLabel.Dispose ();
				platformLabel = null;
			}
			if (userNameLabel != null) {
				userNameLabel.Dispose ();
				userNameLabel = null;
			}
		}
	}
}
