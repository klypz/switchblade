using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Klypz.Switchblade.Image
{
    /// <summary>
    /// Amplia as funcionalidades da classe [System.Drawing.Image]
    /// </summary>
    public static class ImageExtension
    {
        private static RotateFlipType GetOrientationToFlipType(int orientationValue)
        {
            RotateFlipType rotateFlipType = RotateFlipType.RotateNoneFlipNone;

            switch (orientationValue)
            {
                case 1:
                    rotateFlipType = RotateFlipType.RotateNoneFlipNone;
                    break;
                case 2:
                    rotateFlipType = RotateFlipType.RotateNoneFlipX;
                    break;
                case 3:
                    rotateFlipType = RotateFlipType.Rotate180FlipNone;
                    break;
                case 4:
                    rotateFlipType = RotateFlipType.Rotate180FlipX;
                    break;
                case 5:
                    rotateFlipType = RotateFlipType.Rotate90FlipX;
                    break;
                case 6:
                    rotateFlipType = RotateFlipType.Rotate90FlipNone;
                    break;
                case 7:
                    rotateFlipType = RotateFlipType.Rotate270FlipX;
                    break;
                case 8:
                    rotateFlipType = RotateFlipType.Rotate270FlipNone;
                    break;
                default:
                    rotateFlipType = RotateFlipType.RotateNoneFlipNone;
                    break;
            }

            return rotateFlipType;
        }

        /// <summary>
        /// <para>Conserta a rotação da imagem de acordo com a rotação original.</para>
        /// <para>Algumas imagens "importadas" tem a orientação diferente da definida no arquivo, este método conserta.</para>
        /// </summary>
        /// <param name="self">Stream de imagem</param>
        public static void FixToOriginalOrientation(this System.Drawing.Image self)
        {
            foreach (var prop in self.PropertyItems)
            {
                if (prop.Id == 0x0112)
                {
                    int orientationValue = self.GetPropertyItem(prop.Id).Value[0];
                    RotateFlipType rotateFlipType = GetOrientationToFlipType(orientationValue);
                    self.RotateFlip(rotateFlipType);
                    prop.Value[0] = 1;
                    self.SetPropertyItem(prop);
                    break;
                }
            }
        }

        /// <summary>
        /// Redimensiona a imagem proporcionalmente pela largura
        /// </summary>
        /// <param name="self">Imagem</param>
        /// <param name="newWidth">Nova dimensão da largura</param>
        /// <returns>Cópia da imagem original redimensionada</returns>
        [Obsolete("Método foi modificado para ResizeScalarByWidth")]
        public static System.Drawing.Image HorizontalScale(this System.Drawing.Image self, int newWidth)
        {
            System.Drawing.Image reself = (System.Drawing.Image)self.Clone();

            reself.FixToOriginalOrientation();

            int wSource = reself.Width;
            int hSource = reself.Height;



            int wResult = newWidth;
            int hResult = (hSource * newWidth) / wSource;

            //Criando Bitmap
            Bitmap result = new Bitmap(wResult, hResult, reself.PixelFormat);
            result.SetResolution(reself.HorizontalResolution, reself.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(reself, new Rectangle(0, 0, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            return result;
        }

        /// <summary>
        /// Redimensiona a imagem proporcionalmente pela altura
        /// </summary>
        /// <param name="self">Imagem</param>
        /// <param name="newHeight">Nova dimensão da altura</param>
        /// <returns>Cópia da imagem original redimensionada</returns>
        [Obsolete("Método foi modificado para ResizeScalarByHeight")]
        public static System.Drawing.Image VerticalScale(this System.Drawing.Image self, int newHeight)
        {
            System.Drawing.Image reself = (System.Drawing.Image)self.Clone();

            reself.FixToOriginalOrientation();

            int wSource = reself.Width;
            int hSource = reself.Height;

            int hResult = newHeight;
            int wResult = (wSource * newHeight) / hSource;

            //Criando Bitmap
            Bitmap result = new Bitmap(wResult, hResult, reself.PixelFormat);
            result.SetResolution(reself.HorizontalResolution, reself.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(reself, new Rectangle(0, 0, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            return result;
        }

        /// <summary>
        /// Redimensiona a imagem proporcionalmente pela largura
        /// </summary>
        /// <param name="self">Imagem</param>
        /// <param name="newWidth">Nova dimensão da largura</param>
        /// <returns>Cópia da imagem original redimensionada</returns>
        public static System.Drawing.Image ResizeScalarByWidth(this System.Drawing.Image self, int newWidth)
        {
            System.Drawing.Image reself = (System.Drawing.Image)self.Clone();
            reself.FixToOriginalOrientation();

            int wSource = reself.Width;
            int hSource = reself.Height;

            int wResult = newWidth;
            int hResult = (hSource * newWidth) / wSource;

            //Criando Bitmap
            Bitmap result = new Bitmap(wResult, hResult, reself.PixelFormat);
            result.SetResolution(reself.HorizontalResolution, reself.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(reself, new Rectangle(0, 0, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            return result;
        }

        /// <summary>
        /// Redimensiona a imagem proporcionalmente pela altura
        /// </summary>
        /// <param name="self">Imagem</param>
        /// <param name="newHeight">Nova dimensão da altura</param>
        /// <returns>Cópia da imagem original redimensionada</returns>
        public static System.Drawing.Image ResizeScalarByHeight(this System.Drawing.Image self, int newHeight)
        {
            System.Drawing.Image reself = (System.Drawing.Image)self.Clone();
            reself.FixToOriginalOrientation();

            int wSource = reself.Width;
            int hSource = reself.Height;

            int hResult = newHeight;
            int wResult = (wSource * newHeight) / hSource;

            //Criando Bitmap
            Bitmap result = new Bitmap(wResult, hResult, reself.PixelFormat);
            result.SetResolution(reself.HorizontalResolution, reself.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(reself, new Rectangle(0, 0, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            self = result;

            return result;
        }

        /// <summary>
        /// Redimensiona uma imagem tornando-a "quadrada" cortando as sobras em direção do centro
        /// </summary>
        /// <param name="self">Imagem a ser redimensionada</param>
        /// <param name="newSize">Tamanho dos lados da imagem</param>
        /// <returns>A imagem redimensionada</returns>
        public static System.Drawing.Image ToSquare(this System.Drawing.Image self, int newSize)
        {
            System.Drawing.Image reself = (System.Drawing.Image)self.Clone();
            reself.FixToOriginalOrientation();
            int wSource = reself.Width;
            int hSource = reself.Height;

            int wResult = 0;
            int hResult = 0;

            if (wSource <= hSource)
            {
                wResult = newSize;
                hResult = newSize * hSource / wSource;
            }
            else
            {
                hResult = newSize;
                wResult = newSize * wSource / hSource;
            }

            int xResult = (newSize - wResult) / 2;
            int yResult = (newSize - hResult) / 2;


            //Criando Bitmap
            Bitmap result = new Bitmap(newSize, newSize, self.PixelFormat);
            result.SetResolution(reself.HorizontalResolution, reself.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(reself, new Rectangle(xResult, yResult, wResult, hResult), new Rectangle(0, 0, wSource, hSource), GraphicsUnit.Pixel);
            }

            return result;
        }
    }
}