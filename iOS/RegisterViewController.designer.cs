// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace deliveryApp.iOS
{
    [Register ("RegisterViewController")]
    partial class RegisterViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField confirmPwdTextfield { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField emailTextfield { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordTextfield { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton registerButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (confirmPwdTextfield != null) {
                confirmPwdTextfield.Dispose ();
                confirmPwdTextfield = null;
            }

            if (emailTextfield != null) {
                emailTextfield.Dispose ();
                emailTextfield = null;
            }

            if (passwordTextfield != null) {
                passwordTextfield.Dispose ();
                passwordTextfield = null;
            }

            if (registerButton != null) {
                registerButton.Dispose ();
                registerButton = null;
            }
        }
    }
}