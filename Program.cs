using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 0;
            string degisken = null;
            string Degisken = null;
            string degisken_veri = 0;


            string degisken1 = " ";
            byte b = 5; //0-255 //1 byte
            sbyte sb = 5; //-128 - 127 //1 byte
            short s = 1; //-2.768 - 2.768 //2 byte
            ushort a = 1; //0 - 65.365 //2 byte 
            Int16 i16 = 0; //2byte
            int i = 0; //2 byte 
            Int32 i32 = 9; //4 byte 
            Int64 i64 = 0; //8 byte
            uint u = 7; //4 byte
            long l = 5; //8 byte
            ulong ul = 7; //8 byte
            float f = 4; //4 byte
            double d = 5; //8 byte
            decimal de = 0; //16 byte
            char c = '2'; //2byte
            stri ng s = "Feyza"; //sınırsız
            bool b = true; //
            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);
            object o = "x";
            object o1 = 'y';
            object o2 = 4;
            object o3 = 4.3;

            //string ifadeler
            string str = string.Empty;
            str = "Feyza Tekin";
            string ad = "Feyza";
            stirng soyad = "Tekin";
            string TamIsim = ad + " " + soyad;

            //Integer tanımlama şekilleri 
            int integer1 = 1;
            int integer2 = 6;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10 > 2;

            //Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string YeniDeger = str20 + int20.ToString();
            System.Console.WriteLine(YeniDeger);
            //Çıktısı = 2020

            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21);
            //Çıktısı = 40

            int int22 = int20 + int.Parse(str20);
            //Çıktısı = 40

            //DateTime

            string dtm = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(dtm);

            string dtm2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(dtm2);

            string h = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
