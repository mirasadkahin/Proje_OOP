﻿using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            if (p.CustomerName.Length >= 6 && p.CustomerCity != "" && p.CustomerCity.Length >= 3)
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "hatalı kullanım";
                return View();
            }
              
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.Customers.Where(x => x.CustomerID == p.CustomerID).FirstOrDefault();
            value.CustomerCity = p.CustomerCity;
            value.CustomerName = p.CustomerName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
