using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public  class SliderThumbStyle : BindableObject
    {
       
        public static readonly BindableProperty FillProperty;
        public static readonly BindableProperty OverlapStrokeProperty;
        public static readonly BindableProperty RadiusProperty;
        public static readonly BindableProperty StrokeProperty;
        public static readonly BindableProperty StrokeThicknessProperty;
        public Brush Fill { get; set; }


    }
}
