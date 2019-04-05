using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBLib
{
    public class BDLib
    {
        public string host;
        public string user;
        public string pwd;
        public string port;
        public string baseDatos;

        public MySqlConnection conexion;
        public MySqlCommand commandsql;
        public MySqlDataReader datareadersql;

        public static string msgError;
        public BDLib(string host, string bd, string us, string pwd, string port)
        {
            this.host = host;
            this.baseDatos = bd;
            this.user = us;
            this.pwd = pwd;
            this.port = port;
            //crear conecction string
            string cadConex = "Server=" + host + ";Database=" + baseDatos + ";Uid=" + us + ";Pwd = " + pwd + "; Port=" + port + "; ";
            //instanciamos la conexion con el connectionstring concatenado
            conexion = new MySqlConnection(cadConex);
        }
        //constructor
        public BDLib()
        {
            //conexion a base de datos en hosting
            this.host = "localhost";
            this.baseDatos = "servihmo";
            this.user = "root";
            this.pwd = "llorsed";
            this.port = "3306";
            //crear conecction string
            string cadConex = "Server=" + host + ";Database=" + baseDatos + "; Port=" + port + "; Uid=" + user + ";Pwd =" + pwd + "; ";
            //instanciamos la conexion con el connectionstring concatenado
            conexion = new MySqlConnection(cadConex);
        }
        public bool conectar()
        {
            bool res = false;
            try
            {
                //abrir la conexion si esta correcta la connectionstring
                conexion.Open();
                //se pone en true si se puede abrir la conexion correctamente
                res = true;
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error MYSQL al conectar. " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error GENERAL al conectar. " + ex.Message;
            }
            return res;
        }//conectar
        //desconectar
        public bool desconectar()
        {
            bool res = false;
            try
            {
                conexion.Close();
                res = true;
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error Mysql al cerrar conexion " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error General al cerrar conexion " + ex.Message;
            }
            return res;
        }//desconectar
        public bool insertar(string tabla, List<string> campos, List<string> valores)
        {

            bool res = false;
            try
            {
                //INSERT INTO tabla (campos, campos, campoN) VALUES ('valor', `valor`...valorN,)
                string sql = "INSERT INTO " + tabla + " (";
                foreach (string campo in campos)
                {
                    sql = sql + campo + ", ";
                }
                //borramos la coma final, que es el ultimo caracter
                sql = sql.Remove(sql.Length - 2, 1);
                //consitnuamos con la concat del INSERT
                sql += ") VALUES (";
                foreach (string valor in valores)
                {
                    sql += valor + ",";
                }
                //tambien quitamos la ultima ',' de valores
                sql = sql.Remove(sql.Length - 1, 1);
                sql += ");";
                //se verifica que la conexion estè abierta, si no, se abre
                commandsql = new MySqlCommand(sql, conexion);
                if (conexion != null && conexion.State != System.Data.ConnectionState.Open)
                {
                    conectar();
                }
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    commandsql.ExecuteNonQuery();
                    res = true;
                }
                else BDLib.msgError = "Conexión con PROBLEMAS";

            }
            catch (MySqlException mysqlex)
            {
                BDLib.msgError = "Error Mysql al insertar " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                BDLib.msgError = "Error GENERAL al insertar " + ex.Message;
            }
            finally
            {
                desconectar();
            }
            return res;
        }//insertar
        public bool actualizar(string tabla, List<string> campos, List<string> valores, int id)
        {
            bool res = false;
            try
            {
                string sql = "UPDATE " + tabla + " SET ";
                for (int i = 0; i < campos.Count; i++)
                {
                    sql += campos[i] + "=" + valores[i] + ", ";
                }
                sql = sql.Remove(sql.Length - 2, 2);
                sql += " WHERE id=" + id;
                commandsql = new MySqlCommand(sql, conexion);
                if (conexion != null && conexion.State != System.Data.ConnectionState.Open)
                {
                    conectar();
                }
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    commandsql.ExecuteNonQuery();
                    res = true;
                }
            }
            catch (MySqlException mysqlex)
            {
                BDLib.msgError = "Error Mysql al cargar nuevos datos " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                BDLib.msgError = "Error GENERAL al cargar nuevos datos " + ex.Message;
            }
            finally
            {
                desconectar();
            }
            return res;
        }//update
        public bool eliminar(string tabla, int id)
        {
            bool res = false;
            try
            {
                string sql = "DELET FROM " + tabla + " WHERE id=" + id + ";";
                commandsql = new MySqlCommand(sql,conexion);
                if (conexion != null && conexion.State != System.Data.ConnectionState.Open)
                {
                    conectar();
                }
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    commandsql.ExecuteNonQuery();
                    res = true;
                }
            }
            catch (MySqlException mysqlex)
            {
                BDLib.msgError = "Error Mysql al eliminar  " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                BDLib.msgError = "Error GENERAL al eliminar " + ex.Message;
            }
            finally
            {
                desconectar();
            }
            return res;
        }//Eliminar
        public List<object[]> consultar(string tabla,List<string>campos,string valores)
        {
            List<object[]> res = new List<object[]>();
            try
            {
                string sql = "SELECT ";
                foreach (string campo in campos)
                {
                    sql += campo + ", ";
                }
                sql = sql.Remove(sql.Length - 2, 2);
                sql += " FROM " + tabla + " WHERE " + valores;
                commandsql = new MySqlCommand(sql, conexion);
                if (conexion != null && conexion.State != System.Data.ConnectionState.Open)
                {
                    conectar();
                }
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    datareadersql = commandsql.ExecuteReader();
                    if (datareadersql.HasRows)
                    {
                        while (datareadersql.Read())
                        {
                            object[] arreglo = new object[datareadersql.FieldCount];
                            for (int i = 0; i < datareadersql.FieldCount; i++)
                            {
                                arreglo[i] = datareadersql[i];
                            }
                            res.Add(arreglo);
                        }
                    }
                }

            }
            catch (MySqlException mysqlex)
            {
                BDLib.msgError = "Error Mysql en la CONSULTA de   " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                BDLib.msgError = "Error GENERAL en la CONSULTA de  " + ex.Message;
            }
            finally
            {
                desconectar();
            }
            return res;
        }//consulta

        //consulta varios campos de la tabla
        public List<object[]> consultaVarios(string tabla, List<string> campos, string valores)
        {
            List<object[]> res = new List<object[]>();
            try
            {
                string sql = "SELECT ";
                foreach (string campo in campos)
                {
                    sql += campo + ",";
                }
                sql = sql.Remove(sql.Length -2, 2);
                sql += " FROM " + tabla + " WHERE " + valores + ";";
                commandsql = new MySqlCommand(sql, conexion);
                if (conexion != null && conexion.State != System.Data.ConnectionState.Open)
                {
                    conectar();
                }
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    datareadersql = commandsql.ExecuteReader();

                    if (datareadersql.HasRows)
                    {
                        while (datareadersql.Read())
                        {
                            object[] arreglo = new object[datareadersql.FieldCount];
                            for (int i = 0; i < datareadersql.FieldCount; i++)
                            {
                                arreglo[i] = datareadersql[i];
                            }
                            res.Add(arreglo);
                        }
                    }
                }
            }
            catch (MySqlException mysqlex)
            {
                BDLib.msgError = "Error Mysql al consultar varios " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                BDLib.msgError = "Error GENERAL al consultar varios  " + ex.Message;
            }
            finally
            {
                desconectar();
            }
            return res;
        }//consulta varios

        //consulta uno de la tabla
        public object[] ConsultaUno(string tabla, List<string> campos, string valor)
        {
            object[] res = null;
            try
            {
                string sql = "SELECT ";
                foreach (string campo in campos)
                {
                    sql += campo + ",";
                }
                sql = sql.Remove(sql.Length - 1, 1);
                sql += " FROM " + tabla + " WHERE " + valor + ";";
                commandsql = new MySqlCommand(sql, conexion);
                if (conexion != null && conexion.State != System.Data.ConnectionState.Open)
                {
                    conectar();
                }
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    datareadersql = commandsql.ExecuteReader();
                    if (datareadersql.HasRows)
                    {
                        if (datareadersql.Read())
                        {
                            res = new object[datareadersql.FieldCount];
                            for (int i = 0; i < datareadersql.FieldCount; i++)
                            {
                                res[i] = datareadersql[i];
                            }
                        }
                    }
                    else
                    {
                        BDLib.msgError = "NO HAY REGISTRO QUE CUMPLAN CON ESE SELECT, el resultado es null";
                    }
                }
            }
            catch (MySqlException mysqlex)
            {
                BDLib.msgError = "Error Mysql al consultar uno " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                BDLib.msgError = "Error GENERAL al consultar uno  " + ex.Message;
            }
            finally
            {
                desconectar();
            }
            return res;
        }//consulta uno
        public object consultarUnDato(string campo, string tabla, string valor)
        {
            object res = null;
            try
            {
                string sql = "SELECT ";
                sql += campo;
                sql += " FROM " + tabla + " WHERE " + valor;
                commandsql = new MySqlCommand(sql, conexion);
                if (conexion.State!=System.Data.ConnectionState.Open)
                {
                    conectar();
                }
                if (conexion.State==System.Data.ConnectionState.Open)
                {
                    datareadersql = commandsql.ExecuteReader();
                    if (datareadersql.HasRows)
                    {
                        if (datareadersql.Read())
                        {
                            res = new object();
                            res = datareadersql[0];
                        }
                    }
                }
            }
            catch (MySqlException mysqlex)
            {
                BDLib.msgError = "Error Mysql al consultar uno registro" + mysqlex.Message;
            }
            catch (Exception ex)
            {
                BDLib.msgError = "Error GENERAL al consultar uno registro " + ex.Message;
            }
            finally
            {
                desconectar();
            }
            return res;
        }
    }
}
