using static System.Net.Mime.MediaTypeNames;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	void OnButtonClicked(object sender, EventArgs args)
	{
		if (lightOff.IsVisible)
		{
            lightOff.IsVisible = false;
            lightDim1.IsVisible = true;
           
		}
		else
		{
			lightOff.IsVisible = true;
			lightDim1.IsVisible = false;
		}
	}
    void OnGarageButtonClicked(object sender, EventArgs args)
    {
        if (garageClosed.IsVisible)
        {
            garageClosed.IsVisible = false;
            garageOpen.IsVisible = true;

        }
        else
        {
            garageClosed.IsVisible = true;
            garageOpen.IsVisible = false;
        }
    }


}

