using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Api_Student.Models
{
    public class Conexion : DbContext {

        public Conexion(DbContextOptions<Conexion> options) : base(options) {}
       public DbSet<Grados> Grados { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }
    }
    class Conectar{
        private const string cadenaConexion = "server=localhost;port=3306;database=colegio;userid=db_colegio;pwd=db_colegio";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn = new Conexion(constructor.Options);
            return cn; 


        }
    }
    
}
