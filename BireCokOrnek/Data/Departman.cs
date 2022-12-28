using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BireCokOrnek.Data
{
    public class Departman
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Ad { get; set; }

        public List<Calisan> Calisanlar { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
