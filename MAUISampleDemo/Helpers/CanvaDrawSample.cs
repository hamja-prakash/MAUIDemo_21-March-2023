using Microsoft.Maui.Graphics.Platform;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.Helpers
{
    public class CanvaDrawSample : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            try
            {
                Microsoft.Maui.Graphics.IImage image;
                Assembly assembly = GetType().GetTypeInfo().Assembly;
                using (Stream stream = assembly.GetManifestResourceStream("MAUISampleDemo.Resources.Images.cat.jpeg"))
                {
                    image = PlatformImage.FromStream(stream);
                }

                /* Display Image */
                if (image != null)
                    canvas.DrawImage(image, 10, 15, 90, 90);

                /* Resize Image (Facing Issue)*/
                //if (image != null)
                //{
                //    Microsoft.Maui.Graphics.IImage newImage = image.Resize(100, 60, ResizeMode.Fit, true);
                //    canvas.DrawImage(newImage, 10, 10, newImage.Width, newImage.Height);
                //}

                /* Downsize Image */
                //if (image != null)
                //{
                //    Microsoft.Maui.Graphics.IImage newImage = image.Downsize(50, true);
                //    canvas.DrawImage(newImage, 10, 10, newImage.Width, newImage.Height);
                //}

                /* Save Image */
                //if (image != null)
                //{
                //    Microsoft.Maui.Graphics.IImage newImage = image.Downsize(150, true);
                //    using (MemoryStream memStream = new MemoryStream())
                //    {
                //        newImage.Save(memStream);
                //    }
                //    canvas.DrawImage(newImage, 10, 10, newImage.Width, newImage.Height);
                //}
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
        }
    }
}
