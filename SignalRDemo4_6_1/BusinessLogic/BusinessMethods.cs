using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo4_6_1.BusinessLogic
{
    public class BusinessMethods
    {

        public static string WriteImage(string fileName)
        {
            var filePath = HttpRuntime.AppDomainAppPath + @"Images\" + fileName;
            var b = ResizeBitmap(filePath, new Size {Width = 200, Height = 200});
            var bytes = ToByteArray(b, GetImageFormat(GetFileExtension(filePath)));
            return StringFromBytes(filePath, bytes);
        }

        private static string StringFromBytes(string filePath, byte[] byteData)
        {
            string base64String = Convert.ToBase64String(byteData, 0, byteData.Length);
            var mimeType = GetMimeType(filePath);
            return String.Format("data:{0};base64,{1}", mimeType, base64String);
        }

        private static byte[] ToByteArray(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        private static Bitmap ResizeBitmap(string filePath, Size nzMax)
        {
            var b = Image.FromFile(filePath);

            var size = adaptProportionalSize(nzMax, b.Size);
            var result = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(
                    b,
                    new Rectangle(Point.Empty, result.Size),
                    new Rectangle(Point.Empty, b.Size),
                    GraphicsUnit.Pixel);
            }

            return result;
        }

        private static Size adaptProportionalSize(Size szMax, Size szReal)
        {
            int nWidth;
            int nHeight;
            double sMaxRatio;
            double sRealRatio;

            if (szMax.Width < 1 || szMax.Height < 1 || szReal.Width < 1 || szReal.Height < 1)
                return Size.Empty;

            sMaxRatio = (double) szMax.Width/(double) szMax.Height;
            sRealRatio = (double) szReal.Width/(double) szReal.Height;

            if (sMaxRatio < sRealRatio)
            {
                nWidth = Math.Min(szMax.Width, szReal.Width);
                nHeight = (int) Math.Round(nWidth/sRealRatio);
            }
            else
            {
                nHeight = Math.Min(szMax.Height, szReal.Height);
                nWidth = (int) Math.Round(nHeight*sRealRatio);
            }

            return new Size(nWidth, nHeight);
        }

        private static string GetMimeType(string name)
        {
            var dictionary = new Dictionary<string, string>
            {
                {".JPEG", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".JPG", "image/jpeg"},
                {".jpg", "image/jpeg"},
                {".PNG", "image/png"},
                {".png", "image/png"},
                {".GIF", "image/gif"},
                {".gif", "image/gif"}
            };
            var extension = GetFileExtension(name);
            return dictionary[extension];
        }

        private static string GetFileExtension(string fileName)
        {
            return fileName.Substring(fileName.LastIndexOf('.'));
        }

        private static ImageFormat GetImageFormat(string extension)
        {
            switch (extension)
            {
                case ".JPEG":
                case ".jpeg":
                case ".JPG":
                case ".jpg":
                {
                    return ImageFormat.Jpeg;
                }
                case ".GIF":
                case ".gif":
                {
                    return ImageFormat.Gif;
                }
                case ".PNG":
                case ".png":
                {
                    return ImageFormat.Png;
                }

            }
            return ImageFormat.Bmp;
        }

    }
}
