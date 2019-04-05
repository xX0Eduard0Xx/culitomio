using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUsuarios
{
    public class UsuarioGral : Usuario
    {
        private new TipoUs tipo;
        private bool activo;
        private int id;

        public TipoUs Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

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

        public UsuarioGral()
        {
            this.campos.Add("activo");
            this.campos.Add("tipo");

        }

        public new bool crear()
        {
            valores.Clear();
            //cargamos la fecha dd/mm/aaaa hacia aaa/mm/dd
            string fechaMysql = FechaNac.Year + "-" + FechaNac.Month + "-" + FechaNac.Day;
            //se cargan los valores con los datos que se han encapsulado en el objeto
            valores.AddRange(new string[] { "'"+Nombre+"'", "'"+Apellido + "'", "'"+Domicilio + "'", "'"+Celular + "'",
                                            "'"+fechaMysql+"'","'"+ CorreoElectronico+"'", "'"+Contraseña+"'", false.ToString()  });
            return bdlib.insertar("usuarios", campos, valores);
        }

        public bool actualizar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, string contra, bool activo, int id)
        {
            valores.Clear();
            //cargamos la fecha dd/mm/aaaa hacia aaa/mm/dd
            string fechaMysql = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;
            //se cargan los valores con los datos que se han encapsulado en el objeto
            valores.AddRange(new string[] { "'"+nom+"'", "'"+ape + "'", "'"+dom+ "'", "'"+cel + "'",
                                            "'"+fechaMysql+"'","'"+ correo+"'", "'"+contra+"'", activo.ToString()  });
            return bdlib.actualizar("usuarios", campos, valores, id);
        }
        public new bool eliminar(int id)
        {
            return bdlib.eliminar("usuarios", id);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="id"></param>
        /// <returns>NULL si no hay resultado de la consulta, y el OBJETO con todos sus valores si hubo resultado </returns>
        public  UsuarioGral consultar( int id)
        {
            List<string> camposAsterisco = new List<string>() { "id", "nombre", "apellido", "domicilio", "celular",
                                                                "DATE_FORMAT(fecha_nac, '%d/%m/%Y')",
                                                                "correo_electronico", "contraseña","activo", "tipo" };
            UsuarioGral res = new UsuarioGral();
            object[] deQuery = bdlib.ConsultaUno("usuarios", camposAsterisco, " id= " + id);
            if (deQuery != null)
            {
                //tomamos cada elemento para ponerlo en cada MIEMRBO DEL OBJETO UsuarioFinal
                res.Id = int.Parse(deQuery[0].ToString());
                res.Nombre = deQuery[1].ToString();
                res.Apellido = deQuery[2].ToString();
                res.Domicilio = deQuery[3].ToString();
                res.Celular = deQuery[4].ToString();
                res.FechaNac = DateTime.Parse(deQuery[5].ToString());
                res.CorreoElectronico = deQuery[6].ToString();
                res.Contraseña = deQuery[7].ToString();
                res.Activo = bool.Parse(deQuery[8].ToString());
                if (deQuery[9].ToString() == "USUARIO_FINAL")
                    res.Tipo = TipoUs.USUARIO_FINAL;
                else
                    res.Tipo = TipoUs.ADMINISTRADOR;
            }
            else
            {
                //si fue null el res, enconces devolemos un OBJETO UsuarioFINAL NULL
                res = null;
            }

            return res;
        }
                                                                                                                
        public  List<UsuarioGral> consultar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, string activo, string tipo)
        {
            List<UsuarioGral> res = new List<UsuarioGral>();
            string where = "";
            where += nom != "" ? " nombre LIKE '%" + nom + "%' AND " : "";
            where += ape != "" ? " aoellido LIKE '%" + ape + "%' AND " : "";
            where += dom != "" ? " domicilio LIKE '%" + dom + "%' AND " : "";
            where += cel != "" ? " celular LIKE '%" + cel + "%' AND " : "";
            where += fecha != null ? " fecha_nac='" + fecha.Year + "-"+fecha.Month+"-"+fecha.Day+"' AND " : "";
            where += correo != "" ? " nombre = '" + correo + "' AND " : "";
            where += activo !="" ? activo=="true"?" activo = 1 AND " : " activo = 0 AND ": "";
            where += tipo !=  "" ? tipo=="USUARIO_FINAL"? " tipo  'USUARIO_FINAL' AND " : " tipo  'ADMINISTRADOR' AND " : "";

            return res;
        }
       
        public List<UsuarioGral> consultarTodos()
        { //SELECT * FROM usuarios WHERE 1
            List<string> camposAsterisco = new List<string>() { "id", "nombre", "apellido", "domicilio", "celular",
                                                                "DATE_FORMAT(fecha_nac, '%d/%m/%Y')",
                                                                "correo_electronico", "contraseña","activo", "tipo" };
            List<UsuarioGral> res = new List<UsuarioGral>();
            List<object[]> deQuery = bdlib.consultar( "usuarios", camposAsterisco, " 1 ");
            // for (int i = 0; i < deQuery.Count; i++)
            foreach (object us in deQuery)
            {
                //recibimos cada objeto y lo hacemos pasar como UusarioFinal, y lo agregamos a la LISTA RES
                UsuarioGral nuevo = new UsuarioGral();
                nuevo.Id = int.Parse(deQuery[0].ToString());
                nuevo.Nombre = deQuery[1].ToString();
                nuevo.Apellido = deQuery[2].ToString();
                nuevo.Domicilio = deQuery[3].ToString();
                nuevo.Celular = deQuery[4].ToString();
                nuevo.FechaNac = DateTime.Parse(deQuery[5].ToString());
                nuevo.CorreoElectronico = deQuery[6].ToString();
                nuevo.Contraseña = deQuery[7].ToString();
                nuevo.Activo = bool.Parse(deQuery[8].ToString());
                if (deQuery[9].ToString() == "USUARIO_FINAL")
                    nuevo.Tipo = TipoUs.USUARIO_FINAL;
                else
                    nuevo.Tipo = TipoUs.ADMINISTRADOR;
                res.Add(nuevo);
            }
            return res;
        }


        public bool log(string correo)
        {
            this.campos.Clear();
            this.campos = new List<string>() { "idUsuario", "fecha", "hora", "comentario" };
            this.valores = new List<string>() { this.Id.ToString(), "CURDATE()", "CURTIME()", "'Login del Usuario: " + correo + "'" };
            return bdlib.insertar("bitacora", campos, valores);
        }

        public UsuarioGral autentica(string correo, string contra)
        {
            UsuarioGral res = new UsuarioGral();
            List<string> camposAsterisco = new List<string>() { "id", "nombre", "apellido", "domicilio", "celular",
                                                                "DATE_FORMAT(fecha_nac, '%d/%m/%Y')",
                                                                "correo_electronico", "contraseña","activo", "tipo" };
            //primero, consultar si existe el correo en la tabla de usuarios registrados
            object[] resConsulta = bdlib.ConsultaUno("usuarios", camposAsterisco, "correo_electronico='" + correo + "' AND contraseña='" + contra + "'");
            //oper tercerario para determinar si hubo res de consulta, si es asi, se parsea la contraseña, si no, se deja en null
            if (resConsulta != null)///// si existe, consultar la contra y correo juntos''' 
            {
                if (resConsulta[9].ToString() == TipoUs.ADMINISTRADOR.ToString())
                {
                    res = new Administrador();
                    res.Tipo = TipoUs.ADMINISTRADOR;
                    res.Activo = true;
                }
                else
                {
                    res = new UsuarioFinal();
                    res.Tipo = TipoUs.USUARIO_FINAL;
                    res.Activo = false;
                }
                //se copia cada valor del arreeglo y se pasa al objeto
                res.Id = int.Parse(resConsulta[0].ToString());
                res.Nombre = resConsulta[1].ToString();
                res.Apellido = resConsulta[2].ToString();
                res.Domicilio = resConsulta[3].ToString();
                res.Celular = resConsulta[4].ToString();
                res.FechaNac = DateTime.Parse(resConsulta[5].ToString());
                res.CorreoElectronico = resConsulta[6].ToString();
                res.Contraseña = resConsulta[7].ToString();
            }
            else ///// no existe, regresa false, y EL MSG DE ERROR ES = US NO REGISTRADO
            {
                Usuario.errorLogin = "Error en la autenticación, su correo no está registrado, o contraseña erronea.";
                res = null;
            }
            return res;
        }

    }
}
