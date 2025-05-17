using System;
using Microsoft.Maui.Controls;

namespace PocketProfile
{
    public partial class EditInfoPage : ContentPage
    {
        public EditInfoPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            string firstName = FirstNameEntry.Text;
            string lastName = LastNameEntry.Text;

            await DisplayAlert("Saved", $"First Name: {firstName}\nLast Name: {lastName}", "OK");

            await Navigation.PopModalAsync();
        }
    }
}
