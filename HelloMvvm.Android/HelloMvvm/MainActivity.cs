using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using HelloMvvm.ViewModel;

namespace HelloMvvm
{
    [Activity(Label = "HelloMvvm", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Binding> _bindings = new List<Binding>();
        private Button _button;

        public MainViewModel Vm
        {
            get
            {
                return App.Locator.Main;
            }
        }
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            _button = FindViewById<Button>(Resource.Id.MyButton);

            _bindings.Add(
                this.SetBinding(
                    () => Vm.Title,
                    () => _button.Text));

            _button.SetCommand(Vm.UpdateCommand);
        }
    }
}

