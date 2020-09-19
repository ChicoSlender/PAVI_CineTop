using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using TP_PAVI_CineTop.CapaDatos;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServUsuario
    {
        //Instancia la clase UsuarioDAO de la capa de datos para poder acceder a la base de datos
        UsuarioDAO dbUsuario = new UsuarioDAO();

        public Usuario validarUsuario(string nombre_usuario, string contraseña)
        {
            //Pide a la instancia de UsuarioDAO que obtenga el usuario de la BD con el nombre de usuario de parametro
            //Si el usuario obtenido no está vacio, significa que se encontró y se devuelve el objeto usuario con sus datos
            //Caso contrario se retorna un objeto nulo
            Usuario usuarioObtenido = dbUsuario.obtenerUsuario(nombre_usuario);

            if (usuarioObtenido.Nombre != "" && usuarioObtenido.Contraseña == contraseña)
                return usuarioObtenido;
            else
                return null;
        }

        public IList<Usuario> obtenerUsuarios()
        {
            return dbUsuario.obtenerUsuarios();
        }

        public bool existeUsuario(string nombreUsuario)
        {
            return dbUsuario.obtenerUsuario(nombreUsuario).Nombre != "";
        }

    }
}
