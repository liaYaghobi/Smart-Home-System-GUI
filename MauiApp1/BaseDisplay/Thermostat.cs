using Syncfusion.Maui.Gauges;


namespace MauiApp1.BaseDisplay
{
    internal class ThermostatDisplay
    {

        public static SfRadialGauge therm()
        {
            SfRadialGauge therm = new SfRadialGauge();


            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowTicks = true;
            radialAxis.AxisLineStyle.Fill = new SolidColorBrush(Colors.LightGrey);
            radialAxis.AxisLineStyle.Thickness = 15;
            therm.Axes.Add(radialAxis);

            GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.Content = new Label
            {
                Text = "72",
                TextColor = Colors.Black,
                FontAttributes = FontAttributes.Bold,
                FontSize = 20
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

            ShapePointer markerPointer = new ShapePointer();
            ShapePointer markerPointer2 = new ShapePointer();
            markerPointer2.Value = 80;
            markerPointer.IsInteractive = true;
            markerPointer2.Fill = new SolidColorBrush(Colors.IndianRed);
            markerPointer.Value = 30;

            markerPointer.IsInteractive = true;
            markerPointer.Fill = new SolidColorBrush(Colors.CornflowerBlue);
            markerPointer.Offset = -30;
            markerPointer2.Offset = -30;
            markerPointer2.IsInteractive = true;
            radialAxis.Pointers.Add(markerPointer);
            radialAxis.Pointers.Add(markerPointer2);


            return therm;
        }
    }
}
