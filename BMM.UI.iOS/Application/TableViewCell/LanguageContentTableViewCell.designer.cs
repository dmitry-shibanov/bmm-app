﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BMM.UI.iOS
{
    [Register ("LanguageContentTableViewCell")]
    partial class LanguageContentTableViewCell
    {
        [Outlet]
        UIKit.UILabel IndexLabel { get; set; }


        [Outlet]
        UIKit.UILabel TextLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (IndexLabel != null) {
                IndexLabel.Dispose ();
                IndexLabel = null;
            }

            if (TextLabel != null) {
                TextLabel.Dispose ();
                TextLabel = null;
            }
        }
    }
}