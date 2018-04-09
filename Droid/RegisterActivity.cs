
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace deliveryApp.Droid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText emailEditText, passwordEditTest, confirmPasswordEditText;
        Button registerUserButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);

            emailEditText = FindViewById<EditText>(Resource.Id.registerEmailEditText);
            passwordEditTest = FindViewById<EditText>(Resource.Id.registerPasswordEditText);
            confirmPasswordEditText = FindViewById<EditText>(Resource.Id.confirmPasswordEditText);
            registerUserButton = FindViewById<Button>(Resource.Id.registerUserButton);

            registerUserButton.Click += RegisterUserButton_Click;

            string email = Intent.GetStringExtra("email");
            emailEditText.Text = email;
        }

        void RegisterUserButton_Click(object sender, EventArgs e)
        {
        }

    }
}
