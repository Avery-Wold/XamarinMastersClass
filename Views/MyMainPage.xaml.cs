using System;
using System.Collections.Generic;
using AverysXamarinProject.ViewModels;
using Xamarin.Forms;

namespace AverysXamarinProject.Views
{
    public partial class MyMainPage : ContentPage
    {
        public MyMainPage()
        {
            InitializeComponent();
            Title = "Avery's Fun App";
            BindingContext = new MyViewModel();
        }

        async void Button_ClickedAsync(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MySecondPage());
        }
    }
}
