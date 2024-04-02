using GUIHelper;
using System;
using System.Drawing;
using System.Drawing.Imaging;


using MarshellsSettings; 

using System.Threading.Tasks;
using System.Threading;


namespace InvoicePrinter
{
    public class Scanners
    {
        private GMessage GMessage = new GMessage();
        private string BarcodeType = MSetting.GetBarcodeType();
        public Scanners()
        {
            BarcodeType = MSetting.GetBarcodeType();
        }

        public Image GetBarcode(string Barcode)
        { 
            string BarcodeType = MSetting.GetBarcodeType();
            MessagingToolkit.Barcode.BarcodeEncoder Encode = new MessagingToolkit.Barcode.BarcodeEncoder(Barcode);
           
            Image img;
            try
            {
                MessagingToolkit.Barcode.BarcodeFormat Bformat;
                if (BarcodeType == "Code93")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code93;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Codabar")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Codabar;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code11")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code11;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code128")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code128;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code39")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code39;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code39Ext")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code39Extended;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code93")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code93;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "EAN13")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.EAN13;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "EAN8")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.EAN8;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "FIM")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.FIM;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "l2of5")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Industrial2of5;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Interleaved2of5")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Interleaved2of5;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "ISBN")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.ISBN;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "ITF14")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.ITF14;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "JAN13")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.JAN13;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "LOGMARS")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.LOGMARS;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MaxiCode")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MaxiCode;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "ModifiedPlessey")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.ModifiedPlessey;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MSI2Mod10")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MSI2Mod10;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MSIMod10")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MSIMod10;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MSIMod11Mod10")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MSIMod11Mod10;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "PDF417")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.PDF417;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "PostNet")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.PostNet;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "QRCode")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.QRCode;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "RSS14")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.RSS14;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "RSSExpanded")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.RSSExpanded;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "S2of5")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Standard2of5;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Telepen")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Telepen;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UCC12")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UCC12;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UCC13")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UCC13;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCA")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCA;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCE")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCE;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCEANExtension")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCEANExtension;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCSupplemental2Digit")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCSupplemental2Digit;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCSupplemental5Digit")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCSupplemental5Digit;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "USD8")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.USD8;
                    Encode.Encode(Bformat, Barcode);
                }
                else
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Unknown;
                    Encode.Encode(Bformat, Barcode);
                }
                Encode.Height = 300;
                Encode.Width = 500;
                Encode.ImageFormat = ImageFormat.Png;
                Encode.Alignment = MessagingToolkit.Barcode.AlignmentPositions.Center;
                Encode.LabelPosition = MessagingToolkit.Barcode.LabelPositions.BottomCenter;
                Encode.IncludeLabel = true;
                img = Encode.EncodedImage;
                return img;
            }
#if DEBUG            
            catch (Exception ex)
            {
                GMessage.Show(ex.Message);
                return null;
            }
#else
            catch (Exception)
            { 
                return null;
            }
#endif  
        }
        public Image GetBarcode(string Barcode, string BarcodeType)
        {
            MessagingToolkit.Barcode.BarcodeEncoder Encode = new MessagingToolkit.Barcode.BarcodeEncoder();
            Image img;
            try
            {
                MessagingToolkit.Barcode.BarcodeFormat Bformat;
                if (BarcodeType == "Code93")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code93;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Codabar")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Codabar;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code11")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code11;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code128")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code128;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code39")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code39;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code39Ext")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code39Extended;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Code93")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Code93;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "EAN13")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.EAN13;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "EAN8")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.EAN8;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "FIM")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.FIM;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "l2of5")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Industrial2of5;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Interleaved2of5")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Interleaved2of5;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "ISBN")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.ISBN;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "ITF14")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.ITF14;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "JAN13")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.JAN13;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "LOGMARS")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.LOGMARS;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MaxiCode")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MaxiCode;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "ModifiedPlessey")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.ModifiedPlessey;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MSI2Mod10")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MSI2Mod10;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MSIMod10")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MSIMod10;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "MSIMod11Mod10")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.MSIMod11Mod10;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "PDF417")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.PDF417;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "PostNet")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.PostNet;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "QRCode")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.QRCode;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "RSS14")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.RSS14;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "RSSExpanded")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.RSSExpanded;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "S2of5")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Standard2of5;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "Telepen")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Telepen;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UCC12")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UCC12;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UCC13")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UCC13;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCA")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCA;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCE")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCE;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCEANExtension")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCEANExtension;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCSupplemental2Digit")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCSupplemental2Digit;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "UPCSupplemental5Digit")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.UPCSupplemental5Digit;
                    Encode.Encode(Bformat, Barcode);
                }
                else if (BarcodeType == "USD8")
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.USD8;
                    Encode.Encode(Bformat, Barcode);
                }
                else
                {
                    Bformat = MessagingToolkit.Barcode.BarcodeFormat.Unknown;
                    Encode.Encode(Bformat, Barcode);
                }
                Encode.Height = 300;
                Encode.Width = 500;
                Encode.ImageFormat = ImageFormat.Png;
                Encode.Alignment = MessagingToolkit.Barcode.AlignmentPositions.Center;
                Encode.LabelPosition = MessagingToolkit.Barcode.LabelPositions.BottomCenter;
                Encode.IncludeLabel = true;
                img = Encode.EncodedImage;
                return img;
            }
#if DEBUG            
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
                return null;
            }
#else
            catch (Exception)
            { 
                return null;
            }
#endif 
        }
        public string DecodeToText(Image img)
        {
            MessagingToolkit.Barcode.BarcodeDecoder decoder = new MessagingToolkit.Barcode.BarcodeDecoder();
            MessagingToolkit.Barcode.Result result = decoder.Decode(new Bitmap(img));
            if (result != null)
                return result.Text;
            else
            {
                result = decoder.Decode(new Bitmap(img));
                return result.Text;
            }
        }
    }
}
