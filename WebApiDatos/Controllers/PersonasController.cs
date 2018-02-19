using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using Entidades;


namespace WebApiDatos.Controllers
{
    public class PersonasController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public List<Persona>  GetPersonas()
        {
            DaoPersonas objPesonas = new DaoPersonas();
            return objPesonas.consultaPersona();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}