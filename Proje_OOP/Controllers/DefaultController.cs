using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        //{
        //   Class c = new Class();
        //    c.Topla();
        //}

        void mesajlar()
        {
            ViewBag.m1 = "Merhabalar bu bir core projesi";
            ViewBag.m2 = "Merhabalar proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar hi hello bonjour";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int cevre = 2*(kisa + uzun);
            return cevre;
        }
        int faktoriyel()
        {
            int sayi = 5;
            int f = 1;
            for (int i =1 ; i <= sayi ; i++)
            {
                f = f * i;
            }
            return f;
        }

        string cumle()
        {
            string c = "Küçük hanımlar Küçük Beyler Sizler Hepiniz Geleceğin Birer Gülü,Parlayan," +
                "Işık Saçan Yıldızı Olacaksınız";
             return c;
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }
        void Kullanıcı(string kullaniciadi)
        {
            ViewBag.v = kullaniciadi;
        }

        int Topla(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        int Faktoriyel(int p)
        {
            int f = 1;
            for (int i = 1; i <= p; i++)
            {
                f = f * i;
            }
            return f;
        }

        public IActionResult Index()
        {
            mesajlar();
            MesajListesi("Parametre ismi");
            Kullanıcı("üye123");
            ViewBag.tp = Topla(20,35);
            return View();
        }



        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            ViewBag.f = faktoriyel();
            Kullanıcı("member000");
            ViewBag.faktor = Faktoriyel(6);
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.d=cumle();
            Kullanıcı("admin004");
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            Bayrak bayrak = new Bayrak();



            sehirler.Ad = "Kiew";
            sehirler.ID= 1;
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";


            ViewBag.v1 = sehirler.ID;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.Ad;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;

            sehirler.ID = 2;
            sehirler.Ad = "Üsküp";
            sehirler.Ulke = "Makedonya";
            sehirler.Nufus = 500000;
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";


            ViewBag.z1 = sehirler.ID;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;


            return View();
        }
    }
}
