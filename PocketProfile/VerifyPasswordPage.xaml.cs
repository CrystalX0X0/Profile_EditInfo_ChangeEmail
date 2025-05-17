using Microsoft.Maui.Controls;

namespace PocketProfile
{
    public partial class VerifyPasswordPage : ContentPage
    {
        public VerifyPasswordPage()
        {
            InitializeComponent(); // MUST call this to load XAML elements properly
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            // PasswordEntry should NOT be null here if XAML and code-behind are linked correctly.
            if (PasswordEntry == null)
            {
                await DisplayAlert("Error", "Password input not found.", "OK");
                return;
            }

            // You can optionally get the entered password, but no validation required
            string enteredPassword = PasswordEntry.Text?.Trim();

            // Navigate to ChangeEmailPage (must be registered in AppShell)
            await Shell.Current.GoToAsync("ChangeEmailPage");
        }
    }
}
