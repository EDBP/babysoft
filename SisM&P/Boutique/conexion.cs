using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Boutique
{
    class conexion
    {
        private static MySqlConnection _gMysqCConnector = null;
        private static string _gsServidor = "localhost";
        private static string _gsBaseDatos = "boutique";
        private static string _gsUser = "root";
        private static string _gsPassword = "root";

        private static MySqlConnection getInstance()
        {
            if (conexion._gMysqCConnector == null)
            {
                string cs = @"server=" + _gsServidor + ";userid=" + _gsUser + ";password=" + _gsPassword + ";database=" + _gsBaseDatos + ";" + "use procedure bodies=false;";
                conexion._gMysqCConnector = new MySqlConnection(cs);
            }
            return _gMysqCConnector;
        }

        public static void fnEjecutarComando(string consulta)
        {
            try
            {
                MySqlConnection _lMysqCConexion = getInstance();
                _lMysqCConexion.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, _lMysqCConexion);
                cmd.ExecuteNonQuery();
                _lMysqCConexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable fnEjecutarConsulta(String sConsulta)
        {
            MySqlDataReader reader;
            MySqlConnection _lMysqCConexion = getInstance();
            System.Data.DataTable dtReturn = new System.Data.DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand(sConsulta, _lMysqCConexion);
                _lMysqCConexion.Open();
                reader = command.ExecuteReader();
                dtReturn.Load(reader);
                _lMysqCConexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtReturn;
        }
        public static object fnobjEjecutarProcedimientoEscalar(String nombreProcedimiento, MySqlParameter[] pParametros)
        {
            MySqlConnection _lMysqCConexion = getInstance();
            object ret;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _lMysqCConexion;
                cmd.CommandText = nombreProcedimiento;
                cmd.Parameters.AddRange(pParametros);
                _lMysqCConexion.Open();
                ret = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _lMysqCConexion.Close();
            }
            return ret;
        }

        public static object fnEjecutarEscalar(string consulta)
        {
            object ret = -1;
            MySqlConnection _lMysqCConexion = getInstance();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, _lMysqCConexion);
                _lMysqCConexion.Open();
                ret = cmd.ExecuteScalar();
                _lMysqCConexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
    }
}
