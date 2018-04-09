﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace deliveryApp.Droid
{
    [Activity(Label = "deliveryApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText emailEditText, passwordEditText;
        Button signInButton, registerButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            emailEditText = FindViewById<EditText>(Resource.Id.emailEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);
            signInButton = FindViewById<Button>(Resource.Id.signInButton);
            registerButton = FindViewById<Button>(Resource.Id.registerButton);

            signInButton.Click += SignInButton_Click;
            registerButton.Click += RegisterButton_Click;
        }

        void SignInButton_Click(object sender, System.EventArgs e)
        {
        }

        void RegisterButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(RegisterActivity));
            intent.PutExtra("email", emailEditText.Text);
            StartActivity(intent);
        }

    }
}

