﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;


namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class istatistikController : Controller
    {
        // GET: istatistik
        Context c = new Context();
        public ActionResult Index()
        {
            var deger1 = c.Carilers.Count().ToString();     //Toplam Müşteri Sayısı
            ViewBag.d1 = deger1;

            var deger2 = c.Uruns.Count().ToString();        //Toplam Ürün Sayısı
            ViewBag.d2 = deger2;

            var deger3 = c.Personels.Count().ToString();    //Toplam Personel Sayısı
            ViewBag.d3 = deger3;

            var deger4 = c.Kategoris.Count().ToString();    //Toplam Kategori Sayısı
            ViewBag.d4 = deger4;

            var deger5 = c.Uruns.Sum(x=>x.Stok).ToString();
            ViewBag.d5 = deger5;

            var deger6 = (from x in c.Uruns select x.Marka).Distinct().Count().ToString();
            ViewBag.d6 = deger6;

            var deger7 = c.Uruns.Count(x=>x.Stok <=20).ToString();
            ViewBag.d7 = deger7;

            var deger8 = (from x in c.Uruns orderby x.SatisFiyat descending select x.UrunAd).FirstOrDefault().ToString();
            ViewBag.d8 = deger8;

            var deger9 = (from x in c.Uruns orderby x.SatisFiyat ascending select x.UrunAd).FirstOrDefault().ToString();
            ViewBag.d9 = deger9;

            var deger10 = c.Uruns.Count(x => x.UrunAd == "Buzdolabı").ToString();
            ViewBag.d10 = deger10;

            var deger11 = c.Uruns.Count(x => x.UrunAd == "Laptop").ToString();
            ViewBag.d11 = deger11;



            return View();
        }
    }
}