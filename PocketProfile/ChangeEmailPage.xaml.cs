using System;
using Microsoft.Maui.Controls;

namespace PocketProfile
{
    public partial class ChangeEmailPage : ContentPage
    {
        public ChangeEmailPage()
        {
            InitializeComponent();
        }

        private async void OnSaveEmailClicked(object sender, EventArgs e)
        {
            string newEmail = NewEmailEntry.Text;

            if (!string.IsNullOrEmpty(newEmail))
            {
                await DisplayAlert("Success", $"Email updated to: {newEmail}", "OK");
                await Navigation.PopToRootAsync(); // Go back to main profile
            }
            else
            {
                await DisplayAlert("Error", "Please enter a valid email.", "OK");
            }
        }
    }
}
