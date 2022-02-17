using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Api_Student.Models
{
    public class Alumnos
    {
        [Key]

        public int id_alumnos { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string fecha_nacimiento { get; set; }
        public int id_grado { get; set; }

    }
}
