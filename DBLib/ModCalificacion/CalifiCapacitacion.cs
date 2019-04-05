using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModCalificacion 
{
 public  class CalifiCapacitacion:Calificacion 
    {
        public  new bool crearCali()
        {
            bool res = false;
            return res;
        }
        //es un update que se deja en blanco
        public  bool eliminarComen(string comentario)
        {
            bool res = false;
            return res;
        }
        public new bool modificarCali(int califG, int califD1, int califD2)
        {
            bool res = false;
            return res;
        }
        public new bool modificarComen(string comentario)
        {
            bool res = false;
            return res;
        }
        public new Calificacion  consultar(string cliente, string proveedor, DateTime fechaInicio, int califiG, int califiD1, int califiD2, string comentario)
        {
            Calificacion  cali = null;
            return cali;
        }
        public  List<Calificacion> consulta(string cliente, string proveedor, DateTime fechaInicio, int califiG, int califiD1, int califiD2, string comentario)
        {
            return new List<Calificacion>();
        }
        public new bool notificarPendiente(string asunto, string mensaje)
        {
            bool res = false;
            return res;
        }
        public new bool notificarCalificado(string asunto, string mensaje)
        {
            bool res = false;
            return res;
        }
    }
}
