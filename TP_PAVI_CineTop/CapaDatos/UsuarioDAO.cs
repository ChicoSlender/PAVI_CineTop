using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaDatos
{
    class UsuarioDAO
    {

        public Usuario obtenerUsuario(string nombre_usuario)
        {
            //Pide al DBHelper que realice la consulta en la BD y mapea la primera fila a un objeto usuario con el metodo mapearUsuario()
            string consultaSQL = "SELECT * FROM Usuario " +
                "WHERE nombre='" + nombre_usuario + "'";

            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            Usuario usuario;

            if (resultado.Rows.Count > 0)
                usuario = mapearUsuario(resultado.Rows[0]);
            else
                usuario = new Usuario("", "");

            return usuario;
        }
        private Usuario mapearUsuario(DataRow fila)
        {
            //Llena una instancia de la clase Usuario con los datos de la fila parametro
            string nombre = fila[0].ToString();
            string contraseña = fila[1].ToString();
            Usuario usuario = new Usuario(nombre, contraseña);
            return usuario;
        }
    }
}
