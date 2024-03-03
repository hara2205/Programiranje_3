using FIT.Data.ispit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Infrastructure.ispit
{
    public class dtoProstorije
    {
        DLWMSDbContext db = konekcija.db;
        public prostorija  Prostorija { get; set; }
        public string Naziv => Prostorija.Naziv;
        public byte[] Logo => Prostorija.Logo;
        public string Oznaka => Prostorija.Oznaka;
        public string Kapacitet=>Prostorija.Kapacitet.ToString();
        public string BrojPredmeta => IzracunajBrojPredmeta();

        private string IzracunajBrojPredmeta()
        {
            DLWMSDbContext db = konekcija.db;
            int broj = 0;
            var lista=db.Nastava.ToList();
            foreach ( var item in lista )
            {
                if (item.Prostorija.Id == Prostorija.Id)
                {
                    broj++;
                }
            }
            return broj.ToString();
        }
    }
}
