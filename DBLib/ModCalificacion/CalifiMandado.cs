using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModCalificacion 
{
  public  class CalifiMandado:Calificacion 
    {
        //Tipocalificacion  tipo = new Tipocalificacion ();
        //string descripcionGlobal;
        //string detalle1;
        //string detalle2;
        public new bool crearCali()
        {
            valores.Clear();
            string fechaMysql = FechaCali.Year + "-" + FechaCali.Month + "-" + FechaCali.Day;
            valores.AddRange(new string[] { Id_servicio.ToString(), Calificacion_global.ToString(), Calificacion_1.ToString(), Calificacion_2.ToString(), "'" + Comentario + "'", "'" + fechaMysql + "'" });
            return Bd.insertar("calificacion_mandado", campos, valores);
        }
        //es un update que se deja en blanco
        public new bool eliminarComen(int Id)
        {
            campos.Clear();
            valores.Clear();
            campos.Add("comentario");
            valores.Add("' '");
            return Bd.actualizar("calificacion_mandado", campos, valores, Id);
        }
        public new bool modificarCali(int califG, int califD1, int califD2)
        {
            valores.Clear();
            valores.AddRange(new string[] { "'" + Calificacion_global.ToString() + "'", "'" + Calificacion_1.ToString() + "'", "'" + Calificacion_2.ToString() + "'" });
            return Bd.actualizar("calificacion_mandado", campos, valores, Id);
        }
        public  bool modificarComen(int id)
        {
            campos.Clear();
            valores.Clear();
            campos.Add("comentario");
            valores.Add("'" + Comentario+ ",");
            return Bd.actualizar("calificacion_mandado", campos, valores, Id);
        }
        public new Calificacion  consultar(string cliente, string proveedor, DateTime fechaInicio, int califiG, int califiD1, int califiD2, string comentario)
        {
            Calificacion  cali = null;
            return cali;
        }
        public  List<Calificacion> consulta(string cliente, string proveedor, DateTime fechaInicio, int califiG, int califiD1, int califiD2, string comentario)
        {
            return new List<Calificacion >();
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
        public CalifiMandado()
        {
            this.campos.Clear();
            this.campos.AddRange(new string[] { "id_mandado", "calificacion_global ", "calificacion_1", "calificacion_2", "comentario","fechacalifi" });
        }
    }
}
