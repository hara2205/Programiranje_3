using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.ispit
{
    [Table("Prisustvo")]
    public class prisustvo
    {
        public int Id { get; set; }
        public virtual nastava Nastava { get; set; }
        public virtual Student Student { get; set; }
    }
}
