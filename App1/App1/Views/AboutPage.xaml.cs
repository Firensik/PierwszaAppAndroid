using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            
        }
        int count = 0;
        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            count++;
            LabelCount.Text = $"You click{count} time(s)";
        }
        
    }
}