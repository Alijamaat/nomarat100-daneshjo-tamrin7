using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film
{
    public class Student
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public double pishrafte1 { get; set; }
        public double pishraftre2 { get; set; }
        public double sheygerayi { get; set; }
        public double algoritm { get; set; }
        public double system { get; set; }
        public double riazi { get; set; }
        public double kargah { get; set; }
        public double tafsir { get; set; }
        public double zaban { get; set; }
        public double tarbiat { get; set; }

        //معدل کل
        public string MoadelKol()
        {
            return $"\n=>Name:{Name} , {Lastname} ,  MoadelKol: {Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3) + (algoritm * 2) + (system * 2) + (riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 18, 2)}";
        }
        //اسامی
        public string Asami()
        {
            return $"\n=>Name:{Name},{Lastname}";
        }
        //معدل کل بدون اسم
        public double MoadelKolBedonName()
        {
            return Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3) + (algoritm * 2) + (system * 2) + (riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 18, 2);
        }
        //معدل دروس ***
        public string Moadel3Satare()
        {
            return $"Name:{Name}, {Lastname} ,  Moadel***:{Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3)) / 9, 2)}";
        }

        //معدل دروس *** بدون اسم
        public string Moadel3SatareBedonName()
        {
            return $" Moadel***:{Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3)) / 9, 2)}";
        }

        //معدل دروس **
        public string Moadel2Setare()
        {
            return $"Name:{Name} , {Lastname} , Moadel**: {((algoritm * 2) + (system * 2)) / 4}";
        }

        //معدل دروس ** بدون اسم
        public string Moadel2SetareBedonName()
        {
            return $" Moadel**: {((algoritm * 2) + (system * 2)) / 4}";
        }

        //معدل دروس *
        public string Moadel1Setare()
        {
            return $"Name:{Name} , {Lastname} ,  Moadel*: {Math.Round(((riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 5, 2)}";
        }

        //معدل دروس * بدون اسم
        public string Moadel1SetareBedonName()
        {
            return $"Moadel*: {Math.Round(((riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 5, 2)}";
        }
    }

}
