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
    public class GradosController : ControllerBase{
        private Conexion dbConexion;
        public GradosController()
        {

            dbConexion = Conectar.Create();
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(dbConexion.Grados.ToArray());
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id){
            var grados = dbConexion.Grados.SingleOrDefault(a => a.id_grado ==id);
            if (grados !=null){
                return Ok(grados);
            }else{
                return NotFound();
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] Grados grados){
            if(ModelState.IsValid){
                dbConexion.Grados.Add(grados);
                dbConexion.SaveChanges();
                return Ok (grados);
            }else{
                return NotFound();
            }
        }
        [HttpPut]

        public ActionResult Put([FromBody] Grados grados){

            var v_grados = dbConexion.Grados.SingleOrDefault(a => a.id_grado == grados.id_grado);
            if(v_grados != null && ModelState.IsValid){
                dbConexion.Entry(v_grados).CurrentValues.SetValues(grados);
                dbConexion.SaveChanges();
                return Ok();

            }else{
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id){

             var grados = dbConexion.Grados.SingleOrDefault(a => a.id_grado ==id);
          if(grados !=null){
              dbConexion.Grados.Remove(grados);
              dbConexion.SaveChanges();
              return Ok();
          }else{
              return NotFound();
          }
        }

    }
}
   
