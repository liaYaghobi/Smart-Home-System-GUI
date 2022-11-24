
using System.ComponentModel;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using MauiApp1.Helpers;
using Syncfusion.Maui.Sliders;
//using Microsoft.UI.Xaml.Controls;
using Button = Microsoft.Maui.Controls.Button;
using Slider = Microsoft.Maui.Controls.Slider;

namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
 

    public NewPage1()
	{
		InitializeComponent();
	}

    public void LivingRoomLight(object sender, EventArgs e)
    {

        if (!Label1.IsVisible)
        {
            Label1.IsVisible = true;
        }

        var btn = new Button
        {   HeightRequest = 80,
            WidthRequest = 100,
            CornerRadius = 20,
            FontSize = 30,
            FontFamily = "MaterialDesignIcons",
            Text = MaterialDesignIconFonts.LightbulbOnOutline,
            BackgroundColor = Colors.CadetBlue,
            HorizontalOptions = LayoutOptions.Center
        };
        var del = new Button
        {
            HeightRequest = 40,
            WidthRequest = 40,
            CornerRadius = 10,
            FontSize = 15,
            FontFamily = "MaterialDesignIcons",
            Text = MaterialDesignIconFonts.Close,
            BackgroundColor = Colors.IndianRed,
            HorizontalOptions = LayoutOptions.Start
        };


        SfSlider s = new SfSlider()
        {
            Minimum = 0,
            Maximum = 100,
            Value = 0,
        };


        del.Clicked += OnClick;
        s.ValueChanged += OnValueChanged;


        V.Add(del);
        V.Add(btn);
        V.Add(s);

       
        void OnValueChanged(object sender, SliderValueChangedEventArgs e)
        {
            double value = e.NewValue;

            if (value == 100)
            {

                btn.Text = MaterialDesignIconFonts.LightbulbOn40;

            }
        }

        void OnClick(object sender, EventArgs e)
        {
            V.Remove(btn);
            btn = null;
            V.Remove(s);
            s = null;
            V.Remove(del);
            del = null;
        }

    }



    private void LivingRoomSpeaker(object sender, EventArgs e)
    {
        

        if (!Label1.IsVisible)
        {
            Label1.IsVisible = true;
        }
        
        var btn = new Button
        {
            HeightRequest = 80,
            WidthRequest = 100,
            CornerRadius = 20,
            FontSize = 30,
            FontFamily = "MaterialDesignIcons",
            Text = MaterialDesignIconFonts.VolumeLow,
            BackgroundColor = Colors.CadetBlue,
            HorizontalOptions = LayoutOptions.Center
        };



        Slider s = new Slider
        {
            Minimum = 0,
            Maximum = 100,
           


        };

       V.Add(btn);
       V.Add(s);


 
       
     
    }

    
}

