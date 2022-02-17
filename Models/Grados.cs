using System.ComponentModel.DataAnnotations;

namespace Api_Student.Models{

    public class Grados{
        [Key]

        public int id_grado { get; set; }
        public string grado { get; set; }
    }
}
