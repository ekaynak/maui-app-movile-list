using MAUI_APP_1.Models;
using System.Runtime.InteropServices;

namespace MAUI_APP_1;

public partial class MoviesPage : ContentPage
{
    public List<Movie> MovieList { get; set; }

	public MoviesPage()
	{
		InitializeComponent();
        MovieList = Movie.PopulateMovies();

        BindingContext = this;
	}

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var movie = (Movie)e.CurrentSelection[0];
        await Navigation.PushAsync(new MovieDetailPage(movie));
    }
}

