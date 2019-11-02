using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBachat2.Model
{
   public class CartModel
    {
        public string Barcode { get; set; }
        [DisplayName("Item Name")]
        public string Item_Name { get; set; }

        public string Price { get; set; }
        public int Quanity { get; set; }
        public string Brand { get; set; }
        public string imgPath { get; set; }
        public Image Picture
        {
            get
            {
                if (imgPath != "")
                {

                    if (File.Exists(imgPath))
                    {
                        Image imgTemp = Image.FromFile(imgPath);
                        Bitmap img = new Bitmap(imgTemp, 50, 50);


                        return img;
                    }
                }
                return null;
            }

        }
    }
}
