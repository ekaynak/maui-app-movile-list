using System.Diagnostics;

namespace MAUI_APP_1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		
		ButtonLogin.Clicked += ButtonLoginClicked;
	}

	private void ButtonLoginClicked(object sender, EventArgs e)
	{
		if (EntryUsername.Text == "erkan" && entyPassword.Text == "Erkan80")
		{
            // DisplayAlert("Login Success", "You can continue to use this application.", "Ok");
			Navigation.PushModalAsync(new MoviesPage());
        }
		else
		{
			DisplayAlert("Login Failed", "Invalid username or password.", "Retry");
		}
	}
}