using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDSign
{
    public class Colour
    {
        public static List<ColourModel> GetColours()
        {
            List<ColourModel> colors = new List<ColourModel>();
            colors.Add(new ColourModel { Description = "Dim Red", Code = "<CA>" });
            colors.Add(new ColourModel { Description = "Red", Code = "<CB>" });
            colors.Add(new ColourModel { Description = "Bright Red", Code = "<CC>" });
            colors.Add(new ColourModel { Description = "Orange", Code = "<CD>" });
            colors.Add(new ColourModel { Description = "Bright Orange", Code = "<CE>" });
            colors.Add(new ColourModel { Description = "Light Yellow", Code = "<CF>" });
            colors.Add(new ColourModel { Description = "Yellow", Code = "<CG>" });
            colors.Add(new ColourModel { Description = "Bright Yellow", Code = "<CH>" });
            colors.Add(new ColourModel { Description = "Lime", Code = "<CI>" });
            colors.Add(new ColourModel { Description = "Dim Lime", Code = "CJ>" });
            colors.Add(new ColourModel { Description = "Bright Lime", Code = "<CK>" });
            colors.Add(new ColourModel { Description = "Bright Green", Code = "<CL>" });
            colors.Add(new ColourModel { Description = "Green", Code = "<CM>" });
            colors.Add(new ColourModel { Description = "Dim Green", Code = "<CN>" });
            colors.Add(new ColourModel { Description = "Yellow/Green/Red", Code = "<CO>" });
            colors.Add(new ColourModel { Description = "Rainbow", Code = "<CP>" });
            colors.Add(new ColourModel { Description = "Red/Green 3D", Code = "<CQ>" });
            colors.Add(new ColourModel { Description = "Red/Yellow 3D", Code = "<CR>" });
            colors.Add(new ColourModel { Description = "Green/Red 3D", Code = "<CS>" });
            colors.Add(new ColourModel { Description = "Green/Yellow 3D", Code = "<CT>" });
            colors.Add(new ColourModel { Description = "Green on Red", Code = "<CU>" });
            colors.Add(new ColourModel { Description = "Red on Green", Code = "<CV>" });
            colors.Add(new ColourModel { Description = "Orange on Green 3D", Code = "<CW>" });
            colors.Add(new ColourModel { Description = "Lime on Red 3D", Code = "<CX>" });
            colors.Add(new ColourModel { Description = "Green on Red 3D", Code = "<CY>" });
            colors.Add(new ColourModel { Description = "Red on Green 3D", Code = "<CZ>" });
            
            return colors;
        }

    }

    public class ColourModel 
    { 
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
