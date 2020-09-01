using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;

namespace LanguageFeatures.Controllers

{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var products = new[] 
            {
                 //object intializer syntax
                 new { Name = "Kayak", Price = 275M },
                 new { Name = "Lifejacket", Price = 48.95M },
                 new { Name = "Soccer ball", Price = 19.50M },
                 new { Name = "Corner flag", Price = 34.95M }
            };
            return View(products.Select(p => p.GetType().Name));
        }

    //an expression bodied method is a REAL method, just  a different syntax
    //1 Lambdas allow you to pass functions as arguments to methods
    //2 Lambdas allow you to create anoymous methods
    //3 Lambdas inline code





    ////Not an Action Method 
    //bool FilterByPrice(Product p)
    //{
    //    return (p?.Price ?? 0) >= 20;
    //}
    ////Action Method







    //public ViewResult Index()
    //{
    //    Product[] productArray = {
    //        new Product {Name = "Kayak", Price = 275M},
    //        new Product {Name = "Lifejacket", Price = 48.95M},
    //        new Product {Name = "Soccer ball", Price = 19.50M},
    //        new Product {Name = "Corner flag", Price = 34.95M}
    //        };
    //    Func<Product, bool> nameFilter = delegate (Product prod)
    //    {
    //        return prod?.Name?[0] == 'S';
    //    };
    //    decimal priceFilterTotal = productArray
    //        .Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
    //    decimal nameFilterTotal = productArray
    //        .Filter(p => p?.Name?[0] == 'S').TotalPrices();
    //    return View("Index", new string[] {
    //        $"Price Total: {priceFilterTotal:C2}",
    //        $"Name Total: {nameFilterTotal:C2}" });
    //}
}
}