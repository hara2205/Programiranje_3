using FIT.Data.ispit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Infrastructure.ispit
{
    public class dtoPrisustvo
    {
        DLWMSDbContext db = konekcija.db;
        public prisustvo Prisustvo { get; set; }
        public string Oznaka=>Prisustvo.Nastava.ToString();
        public string Student=>Prisustvo.Student.ToString();
    }
}
