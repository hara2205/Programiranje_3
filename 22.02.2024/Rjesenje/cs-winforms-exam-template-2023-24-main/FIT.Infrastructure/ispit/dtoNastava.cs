using FIT.Data.ispit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Infrastructure.ispit
{
    public class dtoNastava
    {
        public nastava  Nastava { get; set; }
        public virtual prostorija Prostorija => Nastava.Prostorija;
        public string Predmet=>Nastava.Predmet.ToString();
        public string Vrijeme => Nastava.Vrijeme;
        public string Dan => Nastava.Dan;
    }
}
