using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Student.Models;

namespace Api_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase{

        private Conexion dbConexion;
        public AlumnosController(){

            dbConexion = Conectar.Create();
        }
        [HttpGet]
        public ActionResult Get(){
            return Ok(dbConexion.Alumnos.ToArray());
        }

        [HttpPost]

        public ActionResult Post([FromBody] Alumnos alumnos){
            if (ModelState.IsValid){
                dbConexion.Alumnos.Add(alumnos);
                dbConexion.SaveChanges();
                return Ok(alumnos);
            }
            else{
                return NotFound();
            }

        }

    }
}
