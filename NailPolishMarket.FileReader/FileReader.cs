using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NailPolishMarket.Models;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

namespace NailPolishMarket.FileReader
{
    public class FileReader
    {
        private StreamReader file;

        public FileReader(string path)
        {
            this.file = new StreamReader(path);
        }

        public ICollection<NailPolish> GetNailPolishes()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
           
            List<NailPolish> NailPolishes = new List<NailPolish>();
            while (file.ReadLine() != null)
            {

                string name = file.ReadLine();
                string brand = file.ReadLine();
                string stringPrice = file.ReadLine();
                decimal price = decimal.Parse(stringPrice);

                var nailPolish = new NailPolish()
                {
                    Name = name,
                    Brand = brand,
                    Price = price
                };

                NailPolishes.Add(nailPolish);
            }
            this.file.Close();
            return NailPolishes;
        }

        public void CloseFile()
        {
            this.file.Close();
        }
    }
}
