using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.ispit
{
    [Table("Prostorije")]
    public class prostorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public byte[] Logo { get; set; }
        public int Kapacitet { get; set; }
        public override string ToString()
        {
            return $"{Naziv} - {Oznaka}";
        }
    }
}
