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
/*using System;

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
}*/

/*using System;

namespace ClassStructer
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Isim="merve";
            ogr1.Soyisim="akçakaya";
            ogr1.Sinif=4;
            ogr1.Ogrno=170202;
            ogr1.OgrenciBilgileriniGetir();
            ogr1.sinifAtlat();
            ogr1.OgrenciBilgileriniGetir();

        }
    }


    class Ogrenci{
        private string ısim;
        private string soyisim;
        private int ogrno;
        private int sinif;

        public string Isim { get => ısim; set => ısim = value; } //ismin yanindaki lamaya tikladim ve kapsulle dedim, otomatik olusturdu bunu.
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Ogrno { get => ogrno; set => ogrno = value; }
        public int Sinif { 
         get => sinif;
         set{
             if(value<1){
                 Console.WriteLine("sinif en az 1 olmali!");
                 sinif=1;
             }else{
                 sinif=value;
             }
         } 
         }//eger ben buradaki seti silersem yukarida sinif=4 dememe izin vermez hata verir.
         //get seti bu sekilde de tanimlayabilirim.

        public Ogrenci(){}

        public Ogrenci(string isim, string soyisim, int ogrno, int sinif){
            Isim=isim;
            Soyisim=soyisim;
            Ogrno=ogrno;
            Sinif=sinif;
        }

        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("isim: {0}",this.Isim);
            Console.WriteLine("soyisim: {0}",this.Soyisim);
            Console.WriteLine("ogrenci numarasi: {0}",this.Ogrno);
            Console.WriteLine("sinif: {0}",this.Sinif);

        }

        public void sinifAtlat(){
            this.Sinif+=1;
        }

        public void sinifDusur(){
            this.Sinif-=1;
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
            Console.WriteLine("calisan sayisi: {0}",Calisan.CalisanSayisi);
            Calisan calisan1= new Calisan("merve","akçakaya","BT");
            Console.WriteLine("calisan sayisi: {0}",Calisan.CalisanSayisi);
            Console.WriteLine("toplama işlemi: {0}",Islemler.Topla(2,5));
            Console.WriteLine("çıkarma işlemi: {0}",Islemler.Cikar(5,3));

        }
    }


    class Calisan{
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi=0;
        }

        public Calisan(string isim, string soyisim, string departman){
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayisi++;
        }
    }

    static class Islemler{
        public static long Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1, int sayi2){
            return sayi1-sayi2;
        }
    }
}
