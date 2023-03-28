using LoginResponsivo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginResponsivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Variables para mover el panel de arriba
        int m, mx, my;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LoginDataSet1.tb_Usuario' Puede moverla o quitarla según sea necesario.
            this.tb_UsuarioTableAdapter.Fill(this.bD_LoginDataSet1.tb_Usuario);

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlArriba_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pnlArriba_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnlArriba_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        int? id;
        int intentos;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(this.tb_UsuarioTableAdapter.Login(txtUser.Text, txtPass.Text));
            if (id > 0)
            {
                Application.OpenForms["frmLogin"].Visible = false;
                //MessageBox.Show("Bienvenido " + Convert.ToString(this.tb_usuarioTableAdapter.Nombre(Convert.ToInt32(id))));
                MessageBox.Show("Bienvenido");
                frmMenu Menu = new frmMenu();
                Menu.Show();
            }
            else
            {
                intentos += 1;
                if (intentos == 4)
                {
                    MessageBox.Show("A SUPERADO EL LIMITE DE INTENTOS, POR FAVOR COMUNIQUESE CON UNO DE LOS ADMINISTRADORES", "ProtectoFinalBD1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                else
                {
                    lblmensaje.Text = ("Usuario o Contraseña incorrecta");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
            }
        }
    }
}
