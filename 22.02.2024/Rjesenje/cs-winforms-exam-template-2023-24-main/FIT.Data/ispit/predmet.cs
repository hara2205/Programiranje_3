using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.ispit
{
    [Table("Predmeti")]
    public class predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public semestar Semestar { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
