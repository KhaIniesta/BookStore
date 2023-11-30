using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public static class Utils
    {
        public static byte[] GenerateDataImageFromPath(String Path)
        {
            byte[] imageData = null;
            try
            {
                using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                    return imageData;
                }

            }
            catch
            {
                return null;
            }
        }

        public static Image GenerateImageFromData(byte[] ImageData)

        {
            MemoryStream ms = new MemoryStream(ImageData);
            Image result = Image.FromStream(ms);
            return result;
        }

    }
}
