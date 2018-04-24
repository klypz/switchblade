using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Klypz.Switchblade.Image
{
    public static class ImageUtil
    {
        public static System.Drawing.Image HorizontalScale(this System.Drawing.Image self, int newHeight)
        {
            int wSource = self.Width;
            int hSource = self.Height;

            int hResult = newHeight;
            int wResult = (wSource * newHeight) / hSource;

            //Criando Bitmap
            Bitmap result = new Bitmap(wResult, hResult, self.PixelFormat);
            result.SetResolution(self.HorizontalResolution, self.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(self, new Rectangle(0, 0, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            return result;
        }

        public static System.Drawing.Image VerticalScale(this System.Drawing.Image self, int newWidth)
        {
            int wSource = self.Width;
            int hSource = self.Height;
            int wResult = newWidth;

            int hResult = (wSource * newWidth) / hSource;

            Bitmap result = new Bitmap(wResult, hResult, self.PixelFormat);
            result.SetResolution(self.HorizontalResolution, self.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(self, new Rectangle(0, 0, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            return result;
        }

        public static System.Drawing.Image ToSquare(this System.Drawing.Image self, int newSize)
        {
            int wSource = self.Width;
            int hSource = self.Height;

            int wResult = 0;
            int hResult = 0;

            if (wSource <= hSource)
            {
                wResult = newSize;
                hResult = (wSource * newSize) / hSource;
            }
            else
            {
                hResult = newSize;
                wResult = (wSource * newSize) / hSource;
            }

            int xResult = (newSize - wResult) / 2;
            int yResult = (newSize - hResult) / 2;


            //Criando Bitmap
            Bitmap result = new Bitmap(newSize, newSize, self.PixelFormat);
            result.SetResolution(self.HorizontalResolution, self.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(self, new Rectangle(xResult, yResult, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            return result;
        }
    }
}
