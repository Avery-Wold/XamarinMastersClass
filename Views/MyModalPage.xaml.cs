using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AverysXamarinProject.ViewModels;

using Xamarin.Forms;

namespace AverysXamarinProject.Views
{
    public partial class MyModalPage : ContentPage
    {
        public MyModalPage()
        {
            InitializeComponent();
            Title = "My Modal Fun";
            BindingContext = new MyViewModel();
        }

        void Button_Clicked(Object sender, System.EventArgs e)
        {
            if (BindingContext is MyViewModel vm)
            {
                NameLabel.Text = vm.Name;
                AgeLabel.Text = vm.Age;
            }
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            Name.Text = "";
            Age.Text = "";
            NameLabel.Text = "";
            AgeLabel.Text = "";
        }
    }
}
