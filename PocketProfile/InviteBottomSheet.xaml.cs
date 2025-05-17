namespace PocketProfile;

public partial class InviteBottomSheet : ContentPage
{
    public InviteBottomSheet()
    {
        InitializeComponent();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}