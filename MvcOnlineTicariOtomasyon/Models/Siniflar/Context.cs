﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }            //CODEFIRST YAPISI KULLANILDI.
        public DbSet<Faturalar> Faturalars { get; set; }          //Yeni tablo eklenınce CONTEXT te eklemek zorundasın.
        public DbSet<Gider> Giders { get; set; }            //Ama varolan tabloya(class'a) sutun eklersen (prop) context'e eklemeye gerek olmaz
        public DbSet<Kategori> Kategoris { get; set; }              
        public DbSet<Personel> Personels { get; set; }              
        public DbSet<SatisHareket> SatisHarekets { get; set; }      
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Detay> Detays { get; set; }
        public DbSet<Yapilacak> Yapilacaks { get; set; }        //Ekleme yapıldıktan sonra "update-database -Force" 
        public DbSet<KargoDetay> KargoDetays { get; set; }
        public DbSet<KargoTakip> KargoTakips { get; set; }
        public DbSet<mesajlar> Mesajlars { get; set; }
    }
}