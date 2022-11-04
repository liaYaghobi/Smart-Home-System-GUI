namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}


	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}