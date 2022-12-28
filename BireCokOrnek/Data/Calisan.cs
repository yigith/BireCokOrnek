using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BireCokOrnek.Data
{
    public class Calisan
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }
    }
}
