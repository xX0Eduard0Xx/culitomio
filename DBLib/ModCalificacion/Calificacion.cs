using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLib;

namespace ModCalificacion 
{ 
    public class Calificacion 
    {
        protected BDLib Bd = new BDLib();
        private int id;
        private int id_servicio;
        private int calificacion_global;
        private int calificacion_1;
        private int calificacion_2;
        private string comentario;
        private DateTime fechaCali = new DateTime();
        protected List<string> campos = new List<string>();
        protected List<string> valores = new List<string>();

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Id_servicio
        {
            get
            {
                return id_servicio;
            }

            set
            {
                id_servicio = value;
            }
        }

        public int Calificacion_global
        {
            get
            {
                return calificacion_global;
            }

            set
            {
                calificacion_global = value;
            }
        }

        public int Calificacion_1
        {
            get
            {
                return calificacion_1;
            }

            set
            {
                calificacion_1 = value;
            }
        }

        public int Calificacion_2
        {
            get
            {
                return calificacion_2;
            }

            set
            {
                calificacion_2 = value;
            }
        }

        public  string Comentario
        {
            get
            {
                return comentario;
            }

            set
            {
                comentario = value;
            }
        }

        public DateTime FechaCali
        {
            get
            {
                return fechaCali;
            }

            set
            {
                fechaCali = value;
            }
        }

       

        public Calificacion ()
        {
            campos.Clear();
            campos.AddRange(new List<string>() {"id","calificacion_global ","calificacion_1","calificacion_2","comentario","fechaCalifi" });
        }

        public Calificacion (int calificacion , int calificacionDetalle_1, int calificacionDetalle_2, string comentario, DateTime fechacali)
        {
            this.Calificacion_global =calificacion ;
            this.Calificacion_1 = calificacionDetalle_1;
            this.Calificacion_2 = calificacionDetalle_2;
            this.Comentario = comentario;
            this.FechaCali = fechacali;
        }

        protected bool crearCali()
        {
            bool res = false;
            return res;
        }
        //es un update que se deja en blanco
        protected bool eliminarComen(int id)
        {
            bool res = false;
            return res;
        }
        protected bool modificarCali(int califG, int califD1, int califD2)
        {
            bool res = false;
            return res;
        }
        protected bool modificarComen(string comentario)
        {
            bool res = false;
            return res;
        }
        protected Calificacion  consultar(string cliente, string proveedor, DateTime fechaInicio, int califiG, int califiD1, int califiD2, string comentario)
        {
            Calificacion  cali = null;
            return cali;
        }
        protected List<Calificacion > consulta(int id,int idCliente,int idProveedor, int calificacion , int calificacion_1, int calificacion_2, string comentario,DateTime fechaCali)
        {
            return new List<Calificacion >();
        }
        public List<Calificacion > ConsultaVAriosServicios()
        {
            List<string> camposAstericos = new List<string>() { "id", "id_servicio", "calificacion_global", "calificacion_1", "calificacion_2", "comentario", "DATE_FORMAT(fechacalifi, '%d/%m/%Y') " };
            List<Calificacion > res = new List<Calificacion >();
            List<object[]> deQuery = Bd.consultaVarios("calificacion _servicio", camposAstericos, "1");
            foreach (object[] arreglo in deQuery)
            {
                Calificacion  nuevo = new Calificacion ();
                nuevo.Id = int.Parse(arreglo[0].ToString());
                nuevo.Id_servicio = int.Parse(arreglo[1].ToString());
                nuevo.Calificacion_global  = int.Parse(arreglo[2].ToString());
                nuevo.Calificacion_1 = int.Parse(arreglo[3].ToString());
                nuevo.Calificacion_2 = int.Parse(arreglo[4].ToString());
                nuevo.Comentario = arreglo[5].ToString();
                nuevo.FechaCali = DateTime.Parse(arreglo[6].ToString());
                res.Add(nuevo);
            }
            return res;
        }
        public List<Calificacion > ConsultaVAriosMandados()
        {
            List<string> camposAstericos = new List<string>() { "id", "idMandado", "calificacion ", "calificacion_1", "calificacion_2", "comentario", "DATE_FORMAT(fechacalifi, '%d/%m/%Y') " };
            List<Calificacion > res = new List<Calificacion >();
            List<object[]> deQuery = Bd.consultaVarios("calificacion _mandado", camposAstericos, "1");
            foreach (object[] arreglo in deQuery)
            {
                Calificacion  nuevo = new Calificacion ();
                nuevo.Id = int.Parse(arreglo[0].ToString());
                nuevo.id_servicio = int.Parse(arreglo[1].ToString());
                nuevo.calificacion_global  = int.Parse(arreglo[2].ToString());
                nuevo.calificacion_1= int.Parse(arreglo[3].ToString());
                nuevo.calificacion_2 = int.Parse(arreglo[4].ToString());
                nuevo.Comentario = arreglo[5].ToString();
                nuevo.FechaCali = DateTime.Parse(arreglo[6].ToString());
                res.Add(nuevo);
            }
            return res;
        }

        protected bool notificarPendiente(string asunto, string mensaje)
        {
            bool res = false;
            return res;
        }
        protected bool notificarCalificado(string asunto, string mensaje)
        {
            bool res = false;
            return res;
        }
        protected enum Tipocalificacion 
        {
            Cliente,
            Proveedor
        }
    }
}
