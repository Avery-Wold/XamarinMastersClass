using System;
using System.Collections.Generic;
using AverysXamarinProject.ViewModels;
using Xamarin.Forms;

namespace AverysXamarinProject.Views
{
    public partial class MySecondPage : ContentPage
    {
        public MySecondPage()
        {
            InitializeComponent();
            Title = "The Second page";
            BindingContext = new MyViewModel();
        }

        async void Button_ClickedAsync(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MyModalPage());
        }
    }
}
