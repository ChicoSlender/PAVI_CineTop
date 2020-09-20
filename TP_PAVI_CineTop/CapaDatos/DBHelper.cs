using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DBHelper
{
    //Setea la unica instancia de la clase y la cadena de conexion a la BD

    enum TipoConexion
    {
        comun, transaccion
    }

    enum EstadoTransaccion
    {
        exito, error
    }

    private class CadenaConexion
    {
        public string benja = "Data Source=LAPTOP-TP28K55O\\SQLEXPRESS;Initial Catalog=CINETOP;Integrated Security=True";
        public string agus = "Data Source=DESKTOP-048MGER\\SQLEXPRESS;Initial Catalog=CINETOP;Integrated Security=True";
    }

    static DBHelper instancia = new DBHelper();
    SqlConnection conexion;
    SqlTransaction transaccion;
    TipoConexion tipo;
    EstadoTransaccion estadoTransaccion;
    string resultado;

    public DBHelper()
    {
        conexion = new SqlConnection();
        //string nombreBD = ConfigurationManager.AppSettings["dbName"];
        //string cadenaConexion = ConfigurationManager.ConnectionStrings[nombreBD].ConnectionString;

        string cadenaConexion = new CadenaConexion().benja;
        conexion.ConnectionString = cadenaConexion;
        tipo = TipoConexion.comun;
        resultado = "";
    }

    public static DBHelper GetDBHelper()
    {
        if (instancia == null)
            instancia = new DBHelper();

        return instancia;
    }

    public void conectar()
    {
        try
        {
            if(conexion.State != ConnectionState.Open) conexion.Open();
            this.resultado = "";
        }
        catch(SqlException ex)
        {
            throw (ex);
        }
    }

    public string desconectar()
    {
        if(tipo == TipoConexion.transaccion)
        {
            if(estadoTransaccion == EstadoTransaccion.exito)
            {
                commit();
                this.resultado = "Transaccion realizada con exito";
            }
            else
            {
                rollback();
                this.resultado = "Transaccion fallida" + "\n" + this.resultado;
            }
        }
        if(conexion.State == ConnectionState.Open)
        {
            conexion.Close();
        }
        return this.resultado;

    }

    public void comenzarTransaccion()
    {
        conectar();
        transaccion = conexion.BeginTransaction();
        estadoTransaccion = EstadoTransaccion.exito;
        tipo = TipoConexion.transaccion;
        this.resultado = "";
    }

    public void commit()
    {
        if (transaccion != null)
            transaccion.Commit();
    }

    public void rollback()
    {
        if (transaccion != null)
            transaccion.Rollback();
    }

    public DataTable consultaSQL(string consulta)
    {
        //Realiza la consulta pasada como parametro y devuelve un DataTable con el resultado
        //Si no hubo errores en la consulta cierra la conexion
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        try
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            comando.Connection = conexion;
            tabla.Load(comando.ExecuteReader());
            return tabla;
        }
        catch(SqlException ex)
        {
            throw (ex);
        }
    }

    public int ejecutarSQL(string consulta)
    {
        SqlCommand comando = new SqlCommand();
        try
        {
            comando.CommandType = CommandType.Text;
            comando.Transaction = transaccion;
            comando.CommandText = consulta;
            comando.Connection = conexion;
            return comando.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            this.resultado += ex.ToString() + "\n";
            return 0;
        }
    }
}

