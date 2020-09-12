﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TP_PAVI_CineTop.CapaDatos
{
    class DBHelper
    {
        //Setea la unica instancia de la clase y la cadena de conexion a la BD
        static DBHelper instancia = new DBHelper();
        SqlConnection conexion;
        SqlTransaction transaccion;

        public DBHelper()
        {
            string nombreBD = ConfigurationManager.AppSettings["dbName"];
            string cadenaConexion = ConfigurationManager.ConnectionStrings[nombreBD].ConnectionString;
            conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
        }

        public static DBHelper GetDBHelper()
        {
            if (instancia == null)
                instancia = new DBHelper();

            instancia.conectar();
            return instancia;
        }

        private void conectar()
        {
            //Intenta conectarse a la BD y devuelve esa conexion

            try
            {
                if(conexion.State != ConnectionState.Open) conexion.Open();
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
        }

        private void desconectar()
        {
            //Cierra la conexion a la BD pasada como parametro
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        public DataTable consultaSQL(string consulta)
        {
            //Realiza la consulta pasada como parametro y devuelve un DataTable con el resultado
            //Si no hubo errores en la consulta cierra la conexion
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            comando.Connection = conexion;

            try
            {
                tabla.Load(comando.ExecuteReader());
                return tabla;
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                desconectar();
            }
        }
    }
}
