using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Emlak
    {
       
        public string MulkTipi { get; set; }
        public string Adres { get; set; }
        public double Fiyat { get; set; }
        public int OdaSayisi { get; set; }
        public double Metrekare { get; set; }
        public int BulunduguKat { get; set; } 
        public int ToplamKatSayisi { get; set; } 
    }
}
