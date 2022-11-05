using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using static System.Net.Mime.MediaTypeNames;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	
    void OnSliderValueChanged(object sender, EventArgs args)
    {
        double value = sliderVal.Value;

        if(value == 100)
        {

            lightOff.IsVisible = false;
            lightDim1.IsVisible = true;

        }

    }

    void OnGarageButtonClicked(object sender, EventArgs args)  /* code for new window*/
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

