
using MauiApp1.Helpers;
using Syncfusion.Maui.Sliders;
using Button = Microsoft.Maui.Controls.Button;


namespace MauiApp1;

public partial class NewPage1 : ContentPage
{

    int bulbIndex = 1;

    public NewPage1()
	{
		InitializeComponent();
	}

    public void displayLabel(Label r)      /* TO DISPLAY THE ROOM LABELS*/
    {
        if (!r.IsVisible)
        {
            r.IsVisible = true;
        }
    }

    public Label createLightBulb()      /*CREATES AND RETURNS LIGHTBULB ICON*/
    {
        var bulb = new Label
        {
            FontSize = 30,
            FontFamily = "MaterialDesignIcons",
            Text = MaterialDesignIconFonts.LightbulbOnOutline,
            HorizontalOptions = LayoutOptions.Center
        };

        return bulb;

    }

    public Label displayDeviceName()
    {
        
        var l = new Label
        {
            Text = $"Light Bulb {bulbIndex}",
            HorizontalOptions = LayoutOptions.Center,

        };

        bulbIndex++;
        return l;
    }

    public Button delete()
    {
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
        return del;
    }
    public SfSlider slide()
    {
        SfSlider s = new SfSlider()
        {
            Minimum = 0,
            Maximum = 100,
            Value = 0,
        };

        return s;
    }

    public void toggleLight(double value, Label bulb)
    {
        if (value == 0)
        {
            bulb.Text = MaterialDesignIconFonts.LightbulbOnOutline;
        }
        if (value > 0 && value < 40)
        {
            bulb.Text = MaterialDesignIconFonts.LightbulbOn40;
        }
        if (value > 40 && value < 60)
        {
            bulb.Text = MaterialDesignIconFonts.LightbulbOn60;
        }
        if (value > 60 && value < 80)
        {
            bulb.Text = MaterialDesignIconFonts.LightbulbOn80;
        }
        if (value == 100)
        {
            bulb.Text = MaterialDesignIconFonts.LightbulbOn;
        }

    }
    public void LivingRoomLight(object sender, EventArgs e)
    {

        displayLabel(Label1);            /*  room title */
        var l = displayDeviceName();     /*  device title */
        var bulb = createLightBulb();   /*  lightbulb   */
        var del = delete();             /*  delete   */
        var s = slide();                /*  toggle   */

        del.Clicked += OnClick;               /* register event handlers*/
        s.ValueChanged += OnValueChanged;

        V.Add(del);                        /* push onto display stack   */
        V.Add(l);
        V.Add(bulb);
        V.Add(s);
       

        void OnValueChanged(object sender, SliderValueChangedEventArgs e)
        {
            double value = e.NewValue;
            toggleLight(value,bulb);
        }

        void OnClick(object sender, EventArgs e)
        {
            int i = V.IndexOf(del);
     
            V.RemoveAt(i+3);
            V.RemoveAt(i+2);
            V.RemoveAt(i+1);
            V.RemoveAt(i);


        }

    }

    
}




