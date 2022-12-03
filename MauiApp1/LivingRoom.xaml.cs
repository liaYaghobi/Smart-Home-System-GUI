using MauiApp1.BaseDisplay;
using Syncfusion.Maui.Sliders;
namespace MauiApp1;


public partial class LivingRoom : ContentPage
{

    int bulbIndex = 1;
    int speakerIndex = 1;
    public LivingRoom()
    {
        InitializeComponent();
    }
    public static void displayLabel(Label r)      /* TO DISPLAY THE ROOM LABELS*/
    {
        if (!r.IsVisible)
        {
            r.IsVisible = true;
        }
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
    public Label displaySpeakerName()
    {
        var name = new Label
        {
            Text = $"Speaker {speakerIndex}",
            HorizontalOptions = LayoutOptions.Center,

        };

        speakerIndex++;
        return name;
    }

    public void LivingRoomLight(object sender, EventArgs e)
    {

        displayLabel(Label1);            /*  room title */
        var l = displayDeviceName();           /*  device title */
        var bulb = LightBulbDisplay.createLightBulb();   /*  lightbulb   */
        var del = buttons.delete();             /*  delete   */
        var s = buttons.slide();                /*  toggle   */


        del.Clicked += OnClick;               /* register event handlers*/
        s.ValueChanged += OnValueChanged;

        V.Add(del);                             /* push onto display stack   */
        V.Add(l);
        V.Add(bulb);
        V.Add(s);


        void OnValueChanged(object sender, SliderValueChangedEventArgs e)   /* toggle light  */
        {
            double value = e.NewValue;
            LightBulbDisplay.toggleLight(value, bulb);
        }

        void OnClick(object sender, EventArgs e)      /* device deleted, pop off display stack */
        {
            int i = V.IndexOf(del);

            V.RemoveAt(i + 3);
            V.RemoveAt(i + 2);
            V.RemoveAt(i + 1);
            V.RemoveAt(i);


        }

    }

    private void LivingRoomSpeaker(object sender, EventArgs e)
    {

        displayLabel(Label1);            /*  room title */
        var l = displaySpeakerName();           /*  device title */
        var speaker = SpeakerDisplay.createSpeaker();   /*  lightbulb   */
        var del = buttons.delete();             /*  delete   */
        var s = buttons.slide();                /*  toggle   */

        del.Clicked += OnClick;               /* register event handlers*/
        s.ValueChanged += OnValueChanged;

        P.Add(del);                             /* push onto display stack   */
        P.Add(l);
        P.Add(speaker);
        P.Add(s);


        void OnValueChanged(object sender, SliderValueChangedEventArgs e)   /* toggle light  */
        {
            double value = e.NewValue;
            SpeakerDisplay.toggleSpeaker(value, speaker);
        }

        void OnClick(object sender, EventArgs e)      /* device deleted, pop off display stack */
        {
            int i = P.IndexOf(del);

            P.RemoveAt(i + 3);
            P.RemoveAt(i + 2);
            P.RemoveAt(i + 1);
            P.RemoveAt(i);


        }

    }

    private void LivingRoomThermostat(object sender, EventArgs e)
    {
        var thermostat = ThermostatDisplay.therm();

        T.Add(thermostat);

    }



}
