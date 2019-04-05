using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModCalificacion 
{
    public class CalifiServicio:Calificacion 
    {
        Tipocalificacion  tipo = new Tipocalificacion ();
        string descripcionGlobal;
        string detalle1;
        string detalle2;
        public CalifiServicio()
        {
            campos[0] += "Servicio";
        }
        public new bool crearCali()
        {
            valores.Clear();
            string fechaMysql = FechaCali.Year + "-" + FechaCali.Month + "-" + FechaCali.Day;
            valores.AddRange(new string[] {Id_servicio.ToString(),Calificacion_global.ToString(),Calificacion_1.ToString(),Calificacion_2.ToString(),"'"+Comentario+"'","'"+fechaMysql+"'" });
            return Bd.insertar("calificacion_servicio", campos,valores);
        }
        //es un update que se deja en blanco
        public  new bool eliminarComen(int Id)
        {
            campos.Clear();
            valores.Clear();
            campos.Add("comentario");
            valores.Add("' '");
            return Bd.actualizar("calificacion_servicio", campos,valores,Id);
        }
        public new bool modificarCali(int califG, int califD1, int califD2)
        {
            valores.Clear();
            valores.AddRange(new string[] { "'" + Calificacion_global.ToString() + "'", "'" + Calificacion_1.ToString() + "'", "'" + Calificacion_2.ToString() + "'" });
            return Bd.actualizar("calificacion_servicio", campos, valores, Id);
        }
        public  bool modificarComen(int id)
        {
            campos.Clear();
            valores.Clear();
            campos.Add("comentario");
            valores.Add("'"+Comentario+",");
            return Bd.actualizar("calificacion_servicio", campos, valores, Id);
        }
        public new Calificacion  consultar(string cliente, string proveedor, DateTime fechaInicio, int califiG, int califiD1, int califiD2, string comentario)
        {
            Calificacion  cali = null;
            return cali;
        }
        public  new List<Calificacion > consulta(int id, int idCliente, int idProveedor, int calificacion , int calificacion_1, int calificacion_2, string comentario,DateTime fechaCali)
        {
            return new List<Calificacion >();
        }
        //public List<calificacion > ConsultaVArios()
        //{
        //    List<string> camposAstericos=new List<string>(){ "id","id_servicio","calificacion ","calificacion_1","calificacion_2","comentario","DATE_FORMAT(fechaNac, '%d/%m/%Y')"};
        //    List<calificacion > res = new List<calificacion >();
        //    List<object[]> deQuery = Bd.consultaVarios("calificacion _servicio", camposAstericos, "1");
        //    foreach (object cali in deQuery)
        //    {
        //        calificacion  nuevo = new calificacion ();
        //        object[] arreglo = new object[10];
        //        arreglo = (object[])cali;
        //        nuevo.Id = int.Parse(arreglo[0].ToString());
        //        nuevo.id_servicio = int.Parse(arreglo[1].ToString());
        //        nuevo.calificacion  = int.Parse(arreglo[2].ToString());
        //        nuevo.calificacion 1 = int.Parse(arreglo[3].ToString());
        //        nuevo.calificacion_1 = int.Parse(arreglo[4].ToString());
        //        nuevo.Comentario = arreglo[5].ToString();
        //        nuevo.FechaCali = DateTime.Parse(arreglo[6].ToString());
        //        res.Add(nuevo);
        //    }
        //    return res;
        //}
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
