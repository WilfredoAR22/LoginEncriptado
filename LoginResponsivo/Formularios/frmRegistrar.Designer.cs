namespace LoginResponsivo.Formularios
{
    partial class frmRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClave = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnInsertar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblnotifi = new System.Windows.Forms.Label();
            this.bD_LoginDataSet1 = new LoginResponsivo.BD_LoginDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_UsuarioTableAdapter = new LoginResponsivo.BD_LoginDataSetTableAdapters.tb_UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(15)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(154)))), ((int)(((byte)(124)))));
            this.txtUsuario.LineThickness = 4;
            this.txtUsuario.Location = new System.Drawing.Point(68, 88);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 66);
            this.txtUsuario.TabIndex = 30;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.OnValueChanged += new System.EventHandler(this.txtUsuario_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(61, 48);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(90, 28);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClave.HintForeColor = System.Drawing.Color.Empty;
            this.txtClave.HintText = "";
            this.txtClave.isPassword = false;
            this.txtClave.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(15)))));
            this.txtClave.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.txtClave.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(154)))), ((int)(((byte)(124)))));
            this.txtClave.LineThickness = 4;
            this.txtClave.Location = new System.Drawing.Point(68, 246);
            this.txtClave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(300, 66);
            this.txtClave.TabIndex = 36;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(61, 205);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(67, 28);
            this.bunifuCustomLabel5.TabIndex = 35;
            this.bunifuCustomLabel5.Text = "Clave";
            // 
            // btnInsertar
            // 
            this.btnInsertar.ActiveBorderThickness = 1;
            this.btnInsertar.ActiveCornerRadius = 20;
            this.btnInsertar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(15)))));
            this.btnInsertar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnInsertar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(154)))), ((int)(((byte)(124)))));
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertar.BackgroundImage")));
            this.btnInsertar.ButtonText = "Registrar";
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnInsertar.IdleBorderThickness = 1;
            this.btnInsertar.IdleCornerRadius = 20;
            this.btnInsertar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnInsertar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnInsertar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnInsertar.Location = new System.Drawing.Point(290, 350);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(191, 54);
            this.btnInsertar.TabIndex = 38;
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblnotifi
            // 
            this.lblnotifi.AutoSize = true;
            this.lblnotifi.ForeColor = System.Drawing.Color.White;
            this.lblnotifi.Location = new System.Drawing.Point(83, 170);
            this.lblnotifi.Name = "lblnotifi";
            this.lblnotifi.Size = new System.Drawing.Size(0, 13);
            this.lblnotifi.TabIndex = 84;
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
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(887, 466);
            this.Controls.Add(this.lblnotifi);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrar";
            this.Text = "frmRegistrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_LoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsertar;
        private System.Windows.Forms.Label lblnotifi;
        private BD_LoginDataSet bD_LoginDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BD_LoginDataSetTableAdapters.tb_UsuarioTableAdapter tb_UsuarioTableAdapter;
    }
}