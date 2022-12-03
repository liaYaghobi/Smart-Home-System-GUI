using MauiApp1.Helpers;
using Syncfusion.Maui.Sliders;

namespace MauiApp1.BaseDisplay
{
    internal class buttons
    {

        public static Button delete()
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



        public static SfSlider slide()
        {
            SfSlider s = new SfSlider()
            {
                Minimum = 0,
                Maximum = 100,
                Value = 0,
            };

            return s;
        }

    }

}
        