using Microsoft.AspNetCore.Mvc;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void Topla()
        {
            int sayi1;
            int sayi2;
            sayi1 = 1;
            sayi2 = 2;
            int toplam = sayi1 + sayi2;
        }
    }
}
