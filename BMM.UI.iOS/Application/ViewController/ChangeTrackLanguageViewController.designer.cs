﻿// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BMM.UI.iOS
{
	[Register ("ChangeTrackLanguageViewController")]
	partial class ChangeTrackLanguageViewController
	{
		[Outlet]
		UIKit.UITableView ChangeTrackLanguageTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ChangeTrackLanguageTableView != null) {
				ChangeTrackLanguageTableView.Dispose ();
				ChangeTrackLanguageTableView = null;
			}
		}
	}
}
