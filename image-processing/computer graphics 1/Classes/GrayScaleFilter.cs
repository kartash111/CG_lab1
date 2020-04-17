using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics_1
{
    class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(sourceColor.R * 0.299) + (int)(sourceColor.G * 0.587) + (int)(sourceColor.B * 0.114);
            Color resultColor = Color.FromArgb(intensity, intensity, intensity);
            return resultColor;
        }
    }
}
