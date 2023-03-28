using Bunifu.Framework.Lib;
using LoginResponsivo.BD_LoginDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginResponsivo.Formularios
{
    public partial class frmRegistrar : Form
    {
        int? usuario;
        
        public frmRegistrar()
        {
            InitializeComponent();            
        }

        private void txtUsuario_OnValueChanged(object sender, EventArgs e)
        {
            lblnotifi.Visible = true;
            int? id = this.tb_UsuarioTableAdapter.Usuario(txtUsuario.Text);
            usuario = id;
            if (id > 0)
            {
                lblnotifi.Text = "Usuario ya en uso, porfavor intente con otro";
            }
            else
            { 
                lblnotifi.Text = "Usuario Correcto";
            }
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LoginDataSet1.tb_Usuario' Puede moverla o quitarla según sea necesario.
            this.tb_UsuarioTableAdapter.Fill(this.bD_LoginDataSet1.tb_Usuario);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario > 0)
                {
                    MessageBox.Show("Porfavor intente ingresando otro usuario");
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    lblnotifi.Text = "";
                    txtUsuario.Focus();
                }
                else
                {
                    this.tb_UsuarioTableAdapter.InsertarUser(txtUsuario.Text, txtClave.Text);
                    MessageBox.Show("Usuario Registrado");
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    lblnotifi.Text = "";
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
