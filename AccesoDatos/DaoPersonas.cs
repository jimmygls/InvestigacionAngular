using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class DaoPersonas
    {
        public List<Persona> consultaPersona()
        {
            AccesoDatos.MantenimientoEntities obdata = new MantenimientoEntities();
            List<Persona> objPersona = new List<Persona>();
            
             var per = (from a in obdata.PruebaPersona select a).ToList();
          
            foreach (var item in per)
            {
                Persona persona = new Persona();
                persona.Apellido = item.Apellido;
                persona.IdPersona = item.ID_Persona;
                persona.Nombre = item.Nombre;
                persona.Tel = item.Tel;
                objPersona.Add(persona);
            }
            return objPersona;
        }
    }
}
