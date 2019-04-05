using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUsuarios
{
    public class Administrador : UsuarioGral
    {
        private new TipoUs tipo = TipoUs.ADMINISTRADOR;

        public TipoUs Tipo1
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



        //TODO Metodo crear Administrador
        /// <summary>
        /// Este metodo es para crear un usuario administrador, por otro admistrador que solo tendra permiso por un usuario administrador.
        /// los datos para hacer el registro en la base de  dqtos se toman con las propiedades heredadas de este objeto, que se establecen 
        /// en las colecciones campos y valores 
        /// </summary>
        /// <returns>verdadero si se creo en la base de datos o falso si hubo un error en la base de datos 
        /// y no se inserto en la base de datos </returns>
        public new bool crear()
        {
            //TODO Reutilizar el metodo insertar de BDlib para crear el registro de administrador
            //INSERT INTO usuarios (nombre, apellido, domicilio, celular, fechaNac, correo_electronico, contraseña, activo, tipo) 
            //VALUES ('ramon', 'rsparza', 'sostenes rocha', '6621498643', '28-07-1984', 'radsdvev@dssd', '123123', 1, 'USUARIO_FINAL');

            //INSERT INTO usuarios (nombre, apellido, domicilio, celular, fechaNac, correo_electronico, contraseña, activo, tipo) 
            //VALUES ("'"+this.nombre+"'", "'"+this.apellido+"'", 'sostenes rocha', '6621498643', '28-07-1984', 'radsdvev@dssd', '123123', 1, 'USUARIO_FINAL');

            campos.Clear();
            valores.Clear();
            
            campos.Add("nombre");
            valores.Add("'" + this.Nombre + "'");
            campos.Add("apellido");
            valores.Add("'" + this.Apellido + "'");
            campos.Add("domicilio");
            valores.Add("'" + this.Domicilio + "'");
            campos.Add("celular");
            valores.Add("'" + this.Celular + "'");
            campos.Add("fechaNac");
            valores.Add("'" + this.FechaNac.Year+"-"+this.FechaNac.Month+"-"+this.FechaNac.Day+ "'");
            campos.Add("correoElectronico");
            valores.Add("'" + this.CorreoElectronico + "'");
            campos.Add("contraseña");
            valores.Add("'" + this.Contraseña + "'");
            campos.Add("activo");
            valores.Add(" 1 ");
            campos.Add("tipo");
            valores.Add("'ADMINISTRADOR'");

            if (bdlib.insertar("usuarios", campos, valores) != false)
            {
                return true;
            }
            else
            {
                return false;
            }
                    
        }//llave final del metodo crear

        public bool actualizar()
        {
            if(bdlib.actualizar("usuarios", campos, valores, iD) != false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//llave del metodo actualizar

        public bool eliminar()
        {
            if (bdlib.eliminar("usuarios", iD) != false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//llave del metodo Eliminar

        public new Administrador consultar(int id)
        {
            Administrador res = new Administrador();
            campos = new List<string>() {  "id", "nombre", "apellido", "domicilio", "celular",
                                           "DATE_FORMAT(fechaNac, '%d/%m/%Y')",
                                            "correoElectronico", "contraseña", "tipo"};
            object[] registro = bdlib.ConsultaUno("usuarios", campos, "id = " + id);
            if (registro != null)
            {
                res.Id = int.Parse(registro[0].ToString());
                res.Nombre = registro[1].ToString();
                res.Apellido = registro[2].ToString();
                res.Domicilio = registro[3].ToString();
                res.Celular = registro[4].ToString();
                res.FechaNac = DateTime.Parse(registro[5].ToString());
                res.CorreoElectronico = registro[6].ToString();
                res.Contraseña = registro[7].ToString();
                if (registro[8].ToString() == TipoUs.USUARIO_FINAL.ToString())
                {
                    res.Tipo = TipoUs.USUARIO_FINAL;
                }
                else res.Tipo = TipoUs.ADMINISTRADOR;

            }
            else
            {
                //no se encontròó el Usuario con el ID especificado
                res = null;
            }
            return res;
        }
    }
}
