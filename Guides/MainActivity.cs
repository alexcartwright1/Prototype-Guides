using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Guides {
    // Author: N8638934, Alex Cartwright
    
    // Name: Alex Cartwright
    // Student Number: N8638934
    // Screen: Guides page
    // Functionality: Six pressable buttons to direct user to new screen containing relevant guide information.
    // Testing features (prototype only): Variable text box to show functioning button presses.
    // Testing device: Nexus 5.

    [Activity(Label = "Guides", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        //int count = 1;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Retrieve buttons from layout resource,
            Button accidentButton = FindViewById<Button>(Resource.Id.button0);
            Button documentButton = FindViewById<Button>(Resource.Id.button1);
            Button claimButton = FindViewById<Button>(Resource.Id.button2);
            Button recoveryButton = FindViewById<Button>(Resource.Id.button3);
            Button disasterButton = FindViewById<Button>(Resource.Id.button4);
            Button faqButton = FindViewById<Button>(Resource.Id.button5);

            // Retrieve text box from layout resource,
            EditText testBox = FindViewById<EditText>(Resource.Id.text1);
            
            // Testing events for each button press. Pages not yet implemented, events will be replaced with page change event.
            // Button names are from the strings associated with each button, as defined in Strings.xml.
            accidentButton.Click += delegate {
                testBox.Text = string.Format("Accident Button Pressed: Screen Change Not Implemented");
            };
            documentButton.Click += delegate {
                testBox.Text = string.Format("Document Button Pressed: Screen Change Not Implemented");
            };
            claimButton.Click += delegate {
                testBox.Text = string.Format("Claim Button Pressed: Screen Change Not Implemented");
            };
            recoveryButton.Click += delegate {
                testBox.Text = string.Format("Recovery Button Pressed: Screen Change Not Implemented");
            };
            disasterButton.Click += delegate {
                testBox.Text = string.Format("Disaster Button Pressed: Screen Change Not Implemented");
            };
            faqButton.Click += delegate {
                testBox.Text = string.Format("FAQ Button Pressed: Screen Change Not Implemented");
            };

            // To Do List:
            // 1. Find a way to alter banner from dark green with "Guides" to Suncorp logo banner.
            // 2. Find a way to place icons at the sides of buttons.
            // 3. Find background image to replace ghastly colour scheme.
            // 4. Add borders to buttons to distinguish them better.
            // 5. Decide on design style (group-wide): vertical buttons or grid-style.
            // 6. Find emulator that actually works.

        }
    }
}

