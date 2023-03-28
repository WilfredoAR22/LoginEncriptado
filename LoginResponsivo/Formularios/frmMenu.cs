using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LoginResponsivo.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metodo para abri formularios dentro del panel
        private void Abrirfrm(object frmhijo)
        {
            if (this.PnlForm.Controls.Count > 0)
            {
                this.PnlForm.Controls.RemoveAt(0);
                Form fh = frmhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PnlForm.Controls.Add(fh);
                this.PnlForm.Tag = fh;
                fh.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Abrirfrm(new frmRegistrar());
        }

        //Variables para mover el panel de arriba
        int m, mx, my;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
