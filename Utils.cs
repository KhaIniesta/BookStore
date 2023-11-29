﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Utils
    {
        public static byte[] TaoDataImageTuLinkFile(String AvartarDirec)
        {
            byte[] imageData = null;
            try
            {
                using (FileStream fs = new FileStream(AvartarDirec, FileMode.Open, FileAccess.Read))
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


        public static Image ChuyenVeHinhAnh(byte[] hinh)

        {
            MemoryStream ms = new MemoryStream(hinh);
            Image result = Image.FromStream(ms);
            return result;
        }

    }
}
