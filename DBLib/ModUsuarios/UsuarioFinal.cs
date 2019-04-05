using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUsuarios
{
    public class UsuarioFinal : UsuarioGral
    {
        //propiedades
        public bool activo = false;



        //constructores
        public UsuarioFinal()
        {
 
        }
        //constructor para crear nuevo registro
        public UsuarioFinal(string nom, string ape, string dom, string cel, DateTime fecha, string correo, string contra, bool activo )
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.Domicilio = dom;
            this.Celular = cel;
            this.FechaNac = fecha;
            this.CorreoElectronico = correo;
            this.Contraseña = contra;
            this.Activo = activo;
        }

       

        //métodos
        public new bool crear()
        {
            return base.crear();
        }


        public new  bool actualizar(string nom, string ape, string dom, string cel, DateTime fecha, string correo, string contra, bool activo,  int id)
        {
            return base.actualizar(nom, ape, dom, cel, fecha, correo, contra, activo, id);
        }
        public new bool eliminar(int id)
        {
            return base.eliminar(id);
        }
        public new UsuarioFinal consultar(int id)
        {
            return (UsuarioFinal) base.consultar(id);
        }

        public new List<UsuarioFinal> consultarTodos()
        {
            List<UsuarioFinal> res = new List<UsuarioFinal>();
            foreach (UsuarioGral us in base.consultarTodos())
            {
                res.Add((UsuarioFinal)us);
            }
            return res;
        }
        public  List<UsuarioFinal> consulta()
        {
            List<UsuarioFinal> res = new List<UsuarioFinal>();
            foreach (UsuarioGral us in base.consultarTodos())
            {
                res.Add((UsuarioFinal)us);
            }
            return res;
        }
    }//class
    
}
