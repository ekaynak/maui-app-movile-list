using System.Diagnostics;

namespace MAUI_APP_1;

public partial class MainPage : ContentPage
{
	public const double MyFontSize = 28;
	string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
	public MainPage()
	{
		InitializeComponent();

		BtnDelete.Clicked += OnDeleteClicked;
		BtnSave.Clicked += OnSaveClicked;
		BtnPage2.Clicked += OnBtnPage2Clicked;

		if (File.Exists(_fileName))
		{
			Editor.Text = File.ReadAllText(_fileName);
		}

	}

	public void OnDeleteClicked(object sender, EventArgs args)
	{
		Debug.WriteLine("DELETE");
	}

	public void OnSaveClicked(object sender, EventArgs args)
	{
		Debug.WriteLine("SAVE");
	}

	public async void OnBtnPage2Clicked(object sender, EventArgs args)
	{
		await Navigation.PushAsync(new MoviesPage());
	}

}