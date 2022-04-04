using System.Diagnostics;
using System.Drawing.Imaging;

namespace FamilyTreeViewer
{
    internal static class FileManager
    {

        internal static void SaveImageToFile(string path, Image bitmap)
        {
            var ext = path.Substring(path.Length - 4, 4);

            ImageCodecInfo _imageCodecInfo = GetEncoderInfo("image/bmp");
            switch (ext)
            {
                case ".jpg":
                    _imageCodecInfo = GetEncoderInfo("image/jpeg");
                    break;
                case ".png":
                    _imageCodecInfo = GetEncoderInfo("image/png");
                    break;
            }

            Encoder _encoder = Encoder.Quality;

            EncoderParameters _encoderParameters = new EncoderParameters(1);
            _encoderParameters.Param[0] = new EncoderParameter(_encoder, 100L);
            
            bitmap.Save(path, _imageCodecInfo, _encoderParameters);
        }


        internal static void SaveToXML(string path, Tree tree)
        {
            FileStream file = File.Create(path);

            System.Xml.Serialization.XmlSerializer writer = new(typeof(Tree));
            writer.Serialize(file, tree);

            Console.WriteLine("Zapisano ");
            file.Close();

            //w zasadzie to ja tylko nodes pewnie muszę zserializować i connections
        }


        //internal static bool LoadFromFile()
        //{
        //    string fileLocation = Path + @"\Saves\" + player.Name + @".sv";
        //    FileStream file = File.Create(fileLocation);

        //    System.Xml.Serialization.XmlSerializer writer = new(typeof(Knight));
        //    writer.Serialize(file, player);

        //    Console.WriteLine("Zapisano " + player.Name);
        //    file.Close();

        //    return false;
        //}

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < encoders.Length; i++)
            {
                if (encoders[i].MimeType == mimeType)
                    return encoders[i];
            }
            return null;
        }

    }
}
