using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.ispit
{
    [Table("Nastava")]
    public class nastava
    {
        public int Id { get; set; }
        public virtual prostorija Prostorija { get; set; }
        public virtual predmet Predmet { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }
        public override string ToString()
        {
            return Oznaka;
        }
    }
}
