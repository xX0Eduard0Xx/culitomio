using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUsuarios
{
    public abstract class Usuario : Persona
    {
        //propiedades
        protected string contraseña = "";
        public TipoUs tipo;
        public int iD = 0;
        /// <summary>
        /// Variable static, para que se pueda acceder el MSG de error de la autetnicaciòn, desde cualquwir FORM
        /// </summary>
        public static string errorLogin = "";
        public static TipoUs tipoUsLogeado;
        public static int idLogeado = 0;

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }



        //constructores
        public Usuario()
        {
            this.campos.Add("contraseña");
        }
        //métodos
        protected new bool crear()
        {
            valores.Clear();
            //se cargan los valores con los datos que se han encapsulado en el objeto
            valores.AddRange(new string[] { "'"+Nombre+"'", "'"+Apellido + "'", "'"+Domicilio + "'", "'"+Celular + "'",
                                            "'"+FechaNac.ToShortDateString()+"'","'"+ CorreoElectronico+"'", "'"+Contraseña+"'" });
            return bdlib.insertar("usuarios", campos, valores);
        }
        protected  bool actualizar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, string contra, int id)
        {
            return true;
        }
        protected new bool eliminar(int id)
        {
            return true;
        }
        protected Usuario consultar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, string contra, int id)
        {
            Usuario us = null;
            return us;
        }

        protected List<Usuario> consultar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, string contra)
        {
            return new List<Usuario>();
        }

        /// <summary>
        /// Mètodo de autenticaciòn para permitir el ACCESO a la aplicaciòn por los usuarios. Tanto Usuarios Finales, 
        /// como Administradores.
        /// Este mòdulo recibe el CORREO ELECTRONICO, y la CONTRASEÑA, para autenticar al usuario.
        /// Si el usuario esta registrado com ADMINISTRADOS y como USUARIO FINAL, se devuelve por default, el ADMINISTRADOR
        /// </summary>
        /// <param name="correo">El correo del usuario registrado para ingresar</param>
        /// <param name="contra">Es la contrseña del usuario registrado</param>
        /// <returns>True si es un usuario registrado, False, si no esta registeado o tiene algun error.</returns>
        public static bool autenticar(string correo, string contra)
        {
            
            bool res = false;
            List<string> campos = new List<string>() { "ID", "contraseña", "tipo" };
            //BDLib.BDLib bdlib = new BDLib.BDLib();
            DBLib.BDLib bdlib = new DBLib.BDLib();
            //primero, consultar si existe el correo en la tabla de usuarios registrados
            object[] resConsulta = bdlib.ConsultaUno("usuarios", campos, "correoElectronico='" + correo + "'");
            //oper tercerario para determinar si hubo res de consulta, si es asi, se parsea la contraseña, si no, se deja en null
            if (resConsulta != null)///// si existe, consultar la contra y correo juntos''' 
            {
                //se parsea la contraseña
                string contraseña = resConsulta[1].ToString();
                //guardamos el tipo y el ID
                Usuario.tipoUsLogeado = resConsulta[2].ToString() == "USUARIO_FINAL" ? TipoUs.USUARIO_FINAL : TipoUs.ADMINISTRADOR;
                Usuario.idLogeado = int.Parse(resConsulta[0].ToString());
                if (contraseña == contra)
                {
                    ////////////// Exito, usuario LOGEADO
                    res = true;
                }
                else
                {
                    ////////////// Error en la CONSTRASEÑA... que la repita
                    Usuario.errorLogin = "Error en la contraseña, volverla a capturar";
                }
            }
            else ///// no existe, regresa false, y EL MSG DE ERROR ES = US NO REGISTRADO
            {
                Usuario.errorLogin = "Error en la autenticación, su correo no está registrado.";
            }
            return res;
        }
        /// <summary>
        /// Mètodo de autenticaciòn para permitir el ACCESO a la aplicaciòn por los usuarios. Tanto Usuarios Finales, 
        /// como Administradores.
        /// Este mòdulo recibe el CORREO ELECTRONICO, y la CONTRASEÑA, para autenticar al usuario.
        /// Si el usuario esta registrado com ADMINISTRADOS y como USUARIO FINAL, se devuelve por default, el ADMINISTRADOR
        /// </summary>
        /// <param name="correo">El correo del usuario registrado para ingresar</param>
        /// <param name="contra">Es la contrseña del usuario registrado</param>
        /// <returns>True si es un usuario registrado, False, si no esta registeado o tiene algun error.</returns>
        

    }//class
    public enum TipoUs
    {
        USUARIO_FINAL,
        ADMINISTRADOR
    }
}
