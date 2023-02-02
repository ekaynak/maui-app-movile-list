namespace MAUI_APP_1;
using MAUI_APP_1.Models;

public partial class MovieDetailPage : ContentPage
{
	public MovieDetailPage(Movie movie)
	{
		InitializeComponent();

		BindingContext= movie;
	}
}