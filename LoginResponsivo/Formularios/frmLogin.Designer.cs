namespace LoginResponsivo
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.bD_LoginDataSet1 = new LoginResponsivo.BD_LoginDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_UsuarioTableAdapter = new LoginResponsivo.BD_LoginDataSetTableAdapters.tb_UsuarioTableAdapter();
            this.lblmensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblnotifi = new System.Windows.Forms.Label();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            this.btnIniciar.ActiveBorderThickness = 1;
            this.btnIniciar.ActiveCornerRadius = 20;
            this.btnIniciar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.btnIniciar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(51)))));
            this.btnIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(51)))), ((int)(((byte)(247)))));
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.ButtonText = "Iniciar Sesion";
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnIniciar.IdleBorderThickness = 1;
            this.btnIniciar.IdleCornerRadius = 20;
            this.btnIniciar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(68)))), ((int)(((byte)(4)))));
            this.btnIniciar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(51)))));
            this.btnIniciar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(237)))));
            this.btnIniciar.Location = new System.Drawing.Point(255, 298);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(181, 41);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.pnlArriba.Controls.Add(this.Salir);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(461, 47);
            this.pnlArriba.TabIndex = 4;
            this.pnlArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlArriba_MouseDown);
            this.pnlArriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlArriba_MouseMove);
            this.pnlArriba.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlArriba_MouseUp);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::LoginResponsivo.Properties.Resources.cruz1;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salir.Location = new System.Drawing.Point(423, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(26, 26);
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // bD_LoginDataSet1
            // 
            this.bD_LoginDataSet1.DataSetName = "BD_LoginDataSet";
            this.bD_LoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tb_Usuario";
            this.bindingSource1.DataSource = this.bD_LoginDataSet1;
            // 
            // tb_UsuarioTableAdapter
            // 
            this.tb_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.Color.White;
            this.lblmensaje.Location = new System.Drawing.Point(51, 271);
            this.lblmensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 21);
            this.lblmensaje.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(119)))), ((int)(((byte)(247)))));
            this.txtUser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtUser.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.txtUser.BorderThickness = 3;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.Yellow;
            this.txtUser.isPassword = false;
            this.txtUser.Location = new System.Drawing.Point(66, 98);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(370, 44);
            this.txtUser.TabIndex = 12;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPass
            // 
            this.txtPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(119)))), ((int)(((byte)(247)))));
            this.txtPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.txtPass.BorderThickness = 3;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass.ForeColor = System.Drawing.Color.Yellow;
            this.txtPass.isPassword = true;
            this.txtPass.Location = new System.Drawing.Point(66, 211);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(370, 44);
            this.txtPass.TabIndex = 13;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblnotifi
            // 
            this.lblnotifi.AutoSize = true;
            this.lblnotifi.ForeColor = System.Drawing.Color.White;
            this.lblnotifi.Location = new System.Drawing.Point(88, 149);
            this.lblnotifi.Name = "lblnotifi";
            this.lblnotifi.Size = new System.Drawing.Size(0, 13);
            this.lblnotifi.TabIndex = 83;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(461, 364);
            this.Controls.Add(this.lblnotifi);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.pnlArriba);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIniciar;
        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.PictureBox Salir;
        private BD_LoginDataSet bD_LoginDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BD_LoginDataSetTableAdapters.tb_UsuarioTableAdapter tb_UsuarioTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel lblmensaje;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUser;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPass;
        private System.Windows.Forms.Label lblnotifi;
    }
}

