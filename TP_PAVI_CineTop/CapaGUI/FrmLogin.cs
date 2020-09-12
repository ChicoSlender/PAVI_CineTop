﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI_CineTop.CapaNegocio;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaGUI
{
    public partial class FrmLogin : Form
    {
        Usuario usuario;

        public FrmLogin()
        {
            InitializeComponent();
        }

        internal Usuario Usuario { get => usuario; set => usuario = value; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Obtiene el texto de los txtBox y valida si son strings no vacios
            string nombre_usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (nombre_usuario == "")
            {
                MessageBox.Show("Debe ingresar un usuario", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }
            if (contraseña == "")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }

            //Llama a la clase ServUsuario de la capa de negocio y le pide validar el usuario
            //Si se devuelve un usuario null (inexistente o contraseña incorrecta) lo informa
            //Caso contrario el login se realiza exitosamente y se cierra el formulario
            ServUsuario servUsuario = new ServUsuario();
            usuario = servUsuario.validarUsuario(nombre_usuario, contraseña);

            if (usuario == null)
            {
                MessageBox.Show("Usuario/contraseña incorrecto/s", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ingreso correcto al sistema", "Informacion de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContraseña.Focus();
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
