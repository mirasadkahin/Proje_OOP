using Proje_OOP.Entity;
using System.Diagnostics;

namespace Proje_OOP.Ornekler
{

    //Sınıfların içindeki öğelere erişim sağlamak için
    //sınıftan bir nesne türetilir
    //SınıfAdı nesneadı=new SınıfAdı();
    public class Class
    {
     public void Topla()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc = sayi1 + sayi2;
        }
       public void Carp()
        {
            int s1 = 10;
            int s2 = 20;
            int sonuc = s1*s2;
        }
    }
}
//ProductClass --> Sınıf class
//productClass --> Nesne object