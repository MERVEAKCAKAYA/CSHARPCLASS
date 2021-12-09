/*using System;

namespace ClassStructer
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad="MERVE";
            calisan1.soyad="AKÇAKAYA";
            calisan1.numara=2549;
            calisan1.departman="IT";
            calisan1.CalisanBilgi();

            Calisan calisan2 = new Calisan();
            calisan2.ad="BAMBAM";
            calisan2.soyad="AKÇAKAYA";
            calisan2.numara=2547;
            calisan2.departman="MAMA YEME";
            calisan2.CalisanBilgi();



        }
    }


    class Calisan{
        public string ad;
        public string soyad;
        public int numara;
        public string departman;

        public void CalisanBilgi(){
            Console.WriteLine("Calisan adi: {0}",ad);
            Console.WriteLine("Calisan soyadi: {0}",soyad);
            Console.WriteLine("Calisan numarasi: {0}",numara);
            Console.WriteLine("Calisan departmani: {0}",departman);

        }
    }
}
*/
using System;

namespace ClassStructer
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 farkli sekilde tanimlama yapabiliriz.
            Calisan calisan1 = new Calisan("merve","akçakaya",2322,"IT");
            calisan1.CalisanBilgi();

            Calisan calisan2 = new Calisan();
            calisan2.Ad="BAMBAM";
            calisan2.Soyad="AKÇAKAYA";
            calisan2.Numara=2547;
            calisan2.Departman="MAMA YEME";
            calisan2.CalisanBilgi();

            //asagida iki string girisli bir metot tanimladik ve burada cagirdik.
            Calisan calisan3 = new Calisan("sakiz","akçakaya");
            calisan3.CalisanBilgi();



        }
    }


    class Calisan{
        public string Ad;
        public string Soyad;
        public int Numara;
        public string Departman;

        public Calisan(string ad, string soyad, int numara, string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.Numara=numara;
            this.Departman=departman;
        }

        public Calisan(){}

        public Calisan(string ad, string soyad){
            this.Ad=ad;
            this.Soyad=soyad;
        }

        public void CalisanBilgi(){
            Console.WriteLine("Calisan adi: {0}",Ad);
            Console.WriteLine("Calisan soyadi: {0}",Soyad);
            Console.WriteLine("Calisan numarasi: {0}",Numara);
            Console.WriteLine("Calisan departmani: {0}",Departman);

        }
    }
}
