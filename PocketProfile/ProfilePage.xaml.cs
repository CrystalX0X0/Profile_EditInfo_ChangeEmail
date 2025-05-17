namespace PocketProfile;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void OnInviteTapped(object sender, EventArgs e)
    {
        
        await Navigation.PushModalAsync(new InviteBottomSheet());
    }

    private async void OnEditInfoTapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new EditInfoPage());
    }

    private async void OnChangeEmailTapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new VerifyPasswordPage());
    }


}