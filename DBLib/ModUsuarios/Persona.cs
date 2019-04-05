using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLib;

namespace ModUsuarios
{
    /// <summary>
    /// Establece la estructura de los objetos PERSONA en el programa,
    /// Define todos los mètodos del CRUD que se requieren,
    /// y utiliza el objeto BDLIb para llevar a cabo las acciones con la BD
    /// </summary>
    public abstract class Persona
    {
        //propiedades
        protected string nombre = "";
        protected string apellido = "";
        protected string domicilio = "";
        protected string celular = "";
        protected DateTime fechaNac = new DateTime();
        protected string correoElectronico = "";
        //TO DO: crear clase...
        protected DBLib.BDLib bdlib = new DBLib.BDLib();
        
        //protected BDLib.BDLib bdlib = new BDLib.BDLib();

        //lista de strings para campos
        protected List<string> campos = new List<string>();
        //lista de strings para valores
        protected List<string> valores = new List<string>();

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }

            set
            {
                domicilio = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public DateTime FechaNac
        {
            get
            {
                return fechaNac;
            }

            set
            {
                fechaNac = value;
            }
        }

        public string CorreoElectronico
        {
            get
            {
                return correoElectronico;
            }

            set
            {
                correoElectronico = value;
            }
        }



        //constructor 
        public Persona()
        {
            //se cargan los textos en el objeto campos
            campos.AddRange(new string[] { "nombre", "apellido", "domicilio", "celular", "fechaNac", "correoElectronico" });
        }
        //mètodos
        protected bool crear()
        {
            valores.Clear();
            //cargamos la fecha dd/mm/aaaa hacia aaa/mm/dd
            string fechaMysql = FechaNac.Year + "-" + FechaNac.Month + "-" + FechaNac.Day;
            //se cargan los valores con los datos que se han encapsulado en el objeto
            valores.AddRange(new string[] { "'"+Nombre+"'", "'"+Apellido + "'", "'"+Domicilio + "'", "'"+Celular + "'",
                                            "'"+fechaMysql+"'","'"+ CorreoElectronico+"'" });
            return bdlib.insertar("usuarios", campos, valores);
        }
        protected bool actualizar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, int id)
        {
            return true;
        }
        protected bool eliminar(int id)
        {
            return true;
        }
        protected Persona consultar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, int id)
        {
            Persona per=null;
            return per;
        }

        protected List<Persona> consultar(string nom, string ape, string dom, string cel, DateTime fecha, string correo)
        {
            return new List<Persona>();
        }

    }
}
