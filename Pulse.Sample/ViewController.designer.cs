// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Pulsing.Sample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIView RootView { get; set; }

		[Outlet]
		UIKit.UIImageView Warning { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Warning != null) {
				Warning.Dispose ();
				Warning = null;
			}

			if (RootView != null) {
				RootView.Dispose ();
				RootView = null;
			}
		}
	}
}
