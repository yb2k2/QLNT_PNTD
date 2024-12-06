using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Global
{
    public partial class Data
    {
        public static string userName { get; set; }
        public static string chucvu { get; set; }
        public static string MaHoaMD5(string str)
        {
            Byte[] dauvao = ASCIIEncoding.Default.GetBytes(str);
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var daura = md5.ComputeHash(dauvao);
                return BitConverter.ToString(daura);
            }
        }

        public static byte[] ConvertImageToByte(Image img)
        {
            MemoryStream mem = new MemoryStream();
            img.Save(mem, System.Drawing.Imaging.ImageFormat.Bmp);
            return mem.ToArray();
        }
        public static Image SelectImageFromFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                return Image.FromFile(open.FileName);
            }
            return null;
        }

    }
    public enum TypeStatus
    {
        Success = 0,
        Error = 1,
        Warning = 2
    }

}
