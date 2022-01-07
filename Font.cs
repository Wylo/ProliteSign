using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDSign
{
    public class Font
    {
        public static List<FontModel> GetFonts()
        {
            List<FontModel> fonts = new List<FontModel>();
            fonts.Add(new FontModel { Description = "Normal", Code = "<SA>" });
            fonts.Add(new FontModel { Description = "Bold (Wide)", Code = "<SB>" });
            fonts.Add(new FontModel { Description = "Italic", Code = "<SC>" });
            fonts.Add(new FontModel { Description = "Bolt Italic (Wide)", Code = "<SD>" });
            fonts.Add(new FontModel { Description = "Flashing Normal", Code = "<SE>" });
            fonts.Add(new FontModel { Description = "Flashing Bolt (Wide)", Code = "<SF>" });
            fonts.Add(new FontModel { Description = "Flashing Italic", Code = "<SG>" });
            fonts.Add(new FontModel { Description = "Flashing Bolt Italic (Wide)", Code = "<SH>" });

            return fonts;

        }
    }

    public class FontModel
    {
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
