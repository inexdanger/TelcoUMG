namespace CapaPresentacion
{
    partial class frm_MenuPrincipal
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
            this.PanelLateral = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_CerrarS = new FontAwesome.Sharp.IconButton();
            this.Btn_Materiales = new FontAwesome.Sharp.IconButton();
            this.btn_Proveedores = new FontAwesome.Sharp.IconButton();
            this.btn_Clientes = new FontAwesome.Sharp.IconButton();
            this.PanelSeparacionLateral = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PanelLogo = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PanelSuperior = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PanelSeparadorSuperior = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PanelCentral = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Usuarios = new FontAwesome.Sharp.IconButton();
            this.btn_Empleados = new FontAwesome.Sharp.IconButton();
            this.btn_Planilla = new FontAwesome.Sharp.IconButton();
            this.btn_Servicios = new FontAwesome.Sharp.IconButton();
            this.btn_Contratos = new FontAwesome.Sharp.IconButton();
            this.btn_Facturas = new FontAwesome.Sharp.IconButton();
            this.btn_Pagos = new FontAwesome.Sharp.IconButton();
            this.btn_Inventarios = new FontAwesome.Sharp.IconButton();
            this.btn_Compras = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelLateral)).BeginInit();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSeparacionLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSeparadorSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCentral)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.AutoScroll = true;
            this.PanelLateral.Controls.Add(this.btn_Compras);
            this.PanelLateral.Controls.Add(this.btn_Inventarios);
            this.PanelLateral.Controls.Add(this.btn_Pagos);
            this.PanelLateral.Controls.Add(this.btn_Facturas);
            this.PanelLateral.Controls.Add(this.btn_Contratos);
            this.PanelLateral.Controls.Add(this.btn_Servicios);
            this.PanelLateral.Controls.Add(this.btn_Planilla);
            this.PanelLateral.Controls.Add(this.btn_Empleados);
            this.PanelLateral.Controls.Add(this.btn_Usuarios);
            this.PanelLateral.Controls.Add(this.btn_CerrarS);
            this.PanelLateral.Controls.Add(this.Btn_Materiales);
            this.PanelLateral.Controls.Add(this.btn_Proveedores);
            this.PanelLateral.Controls.Add(this.btn_Clientes);
            this.PanelLateral.Controls.Add(this.PanelSeparacionLateral);
            this.PanelLateral.Controls.Add(this.PanelLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(332, 1093);
            this.PanelLateral.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.PanelLateral.TabIndex = 0;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            // 
            // btn_CerrarS
            // 
            this.btn_CerrarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_CerrarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CerrarS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CerrarS.FlatAppearance.BorderSize = 0;
            this.btn_CerrarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_CerrarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_CerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarS.ForeColor = System.Drawing.Color.Silver;
            this.btn_CerrarS.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_CerrarS.IconColor = System.Drawing.Color.Silver;
            this.btn_CerrarS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CerrarS.IconSize = 32;
            this.btn_CerrarS.Location = new System.Drawing.Point(0, 1021);
            this.btn_CerrarS.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_CerrarS.Name = "btn_CerrarS";
            this.btn_CerrarS.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_CerrarS.Size = new System.Drawing.Size(332, 72);
            this.btn_CerrarS.TabIndex = 6;
            this.btn_CerrarS.Tag = "CerrarSesion";
            this.btn_CerrarS.Text = "CerrarSesion";
            this.btn_CerrarS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CerrarS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CerrarS.UseVisualStyleBackColor = false;
            this.btn_CerrarS.Click += new System.EventHandler(this.btn_CerrarS_Click);
            // 
            // Btn_Materiales
            // 
            this.Btn_Materiales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.Btn_Materiales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Materiales.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Materiales.FlatAppearance.BorderSize = 0;
            this.Btn_Materiales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.Btn_Materiales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.Btn_Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Materiales.ForeColor = System.Drawing.Color.Silver;
            this.Btn_Materiales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Materiales.IconColor = System.Drawing.Color.Silver;
            this.Btn_Materiales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Materiales.IconSize = 32;
            this.Btn_Materiales.Location = new System.Drawing.Point(0, 259);
            this.Btn_Materiales.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Materiales.Name = "Btn_Materiales";
            this.Btn_Materiales.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.Btn_Materiales.Size = new System.Drawing.Size(332, 72);
            this.Btn_Materiales.TabIndex = 4;
            this.Btn_Materiales.Tag = "Materiales";
            this.Btn_Materiales.Text = "Materiales";
            this.Btn_Materiales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Materiales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Materiales.UseVisualStyleBackColor = false;
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.btn_Proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedores.ForeColor = System.Drawing.Color.Silver;
            this.btn_Proveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Proveedores.IconColor = System.Drawing.Color.Silver;
            this.btn_Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Proveedores.IconSize = 32;
            this.btn_Proveedores.Location = new System.Drawing.Point(0, 187);
            this.btn_Proveedores.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Proveedores.Size = new System.Drawing.Size(332, 72);
            this.btn_Proveedores.TabIndex = 3;
            this.btn_Proveedores.Tag = "Proveedores";
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Proveedores.UseVisualStyleBackColor = false;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.ForeColor = System.Drawing.Color.Silver;
            this.btn_Clientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Clientes.IconColor = System.Drawing.Color.Silver;
            this.btn_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Clientes.IconSize = 32;
            this.btn_Clientes.Location = new System.Drawing.Point(0, 115);
            this.btn_Clientes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Clientes.Size = new System.Drawing.Size(332, 72);
            this.btn_Clientes.TabIndex = 2;
            this.btn_Clientes.Tag = "Clientes";
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // PanelSeparacionLateral
            // 
            this.PanelSeparacionLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSeparacionLateral.Location = new System.Drawing.Point(0, 111);
            this.PanelSeparacionLateral.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelSeparacionLateral.Name = "PanelSeparacionLateral";
            this.PanelSeparacionLateral.Size = new System.Drawing.Size(332, 4);
            this.PanelSeparacionLateral.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.PanelSeparacionLateral.TabIndex = 1;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(332, 111);
            this.PanelLogo.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(332, 0);
            this.PanelSuperior.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.PanelSuperior.Size = new System.Drawing.Size(1560, 82);
            this.PanelSuperior.StateCommon.Color1 = System.Drawing.Color.White;
            this.PanelSuperior.TabIndex = 1;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            this.PanelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseMove);
            // 
            // PanelSeparadorSuperior
            // 
            this.PanelSeparadorSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSeparadorSuperior.Location = new System.Drawing.Point(332, 82);
            this.PanelSeparadorSuperior.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelSeparadorSuperior.Name = "PanelSeparadorSuperior";
            this.PanelSeparadorSuperior.Size = new System.Drawing.Size(1560, 4);
            this.PanelSeparadorSuperior.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.PanelSeparadorSuperior.TabIndex = 2;
            // 
            // PanelCentral
            // 
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(332, 86);
            this.PanelCentral.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1560, 1007);
            this.PanelCentral.StateCommon.Color1 = System.Drawing.Color.White;
            this.PanelCentral.TabIndex = 3;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.ForeColor = System.Drawing.Color.Silver;
            this.btn_Usuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Usuarios.IconColor = System.Drawing.Color.Silver;
            this.btn_Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Usuarios.IconSize = 32;
            this.btn_Usuarios.Location = new System.Drawing.Point(0, 331);
            this.btn_Usuarios.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Usuarios.Size = new System.Drawing.Size(332, 72);
            this.btn_Usuarios.TabIndex = 7;
            this.btn_Usuarios.Tag = "Usuarios";
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Usuarios.UseVisualStyleBackColor = false;
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Empleados.FlatAppearance.BorderSize = 0;
            this.btn_Empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleados.ForeColor = System.Drawing.Color.Silver;
            this.btn_Empleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Empleados.IconColor = System.Drawing.Color.Silver;
            this.btn_Empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Empleados.IconSize = 32;
            this.btn_Empleados.Location = new System.Drawing.Point(0, 403);
            this.btn_Empleados.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Empleados.Size = new System.Drawing.Size(332, 72);
            this.btn_Empleados.TabIndex = 8;
            this.btn_Empleados.Tag = "Empleados";
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Empleados.UseVisualStyleBackColor = false;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // btn_Planilla
            // 
            this.btn_Planilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Planilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Planilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Planilla.FlatAppearance.BorderSize = 0;
            this.btn_Planilla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Planilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Planilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Planilla.ForeColor = System.Drawing.Color.Silver;
            this.btn_Planilla.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Planilla.IconColor = System.Drawing.Color.Silver;
            this.btn_Planilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Planilla.IconSize = 32;
            this.btn_Planilla.Location = new System.Drawing.Point(0, 475);
            this.btn_Planilla.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Planilla.Name = "btn_Planilla";
            this.btn_Planilla.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Planilla.Size = new System.Drawing.Size(332, 72);
            this.btn_Planilla.TabIndex = 9;
            this.btn_Planilla.Tag = "Pagos";
            this.btn_Planilla.Text = "Pagos";
            this.btn_Planilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Planilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Planilla.UseVisualStyleBackColor = false;
            // 
            // btn_Servicios
            // 
            this.btn_Servicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Servicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Servicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Servicios.FlatAppearance.BorderSize = 0;
            this.btn_Servicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Servicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Servicios.ForeColor = System.Drawing.Color.Silver;
            this.btn_Servicios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Servicios.IconColor = System.Drawing.Color.Silver;
            this.btn_Servicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Servicios.IconSize = 32;
            this.btn_Servicios.Location = new System.Drawing.Point(0, 547);
            this.btn_Servicios.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Servicios.Name = "btn_Servicios";
            this.btn_Servicios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Servicios.Size = new System.Drawing.Size(332, 72);
            this.btn_Servicios.TabIndex = 10;
            this.btn_Servicios.Tag = "Servicios";
            this.btn_Servicios.Text = "Servicios";
            this.btn_Servicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Servicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Servicios.UseVisualStyleBackColor = false;
            // 
            // btn_Contratos
            // 
            this.btn_Contratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Contratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Contratos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Contratos.FlatAppearance.BorderSize = 0;
            this.btn_Contratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Contratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Contratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contratos.ForeColor = System.Drawing.Color.Silver;
            this.btn_Contratos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Contratos.IconColor = System.Drawing.Color.Silver;
            this.btn_Contratos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Contratos.IconSize = 32;
            this.btn_Contratos.Location = new System.Drawing.Point(0, 619);
            this.btn_Contratos.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Contratos.Name = "btn_Contratos";
            this.btn_Contratos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Contratos.Size = new System.Drawing.Size(332, 72);
            this.btn_Contratos.TabIndex = 11;
            this.btn_Contratos.Tag = "Contratos";
            this.btn_Contratos.Text = "Contratos";
            this.btn_Contratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Contratos.UseVisualStyleBackColor = false;
            // 
            // btn_Facturas
            // 
            this.btn_Facturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Facturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Facturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Facturas.FlatAppearance.BorderSize = 0;
            this.btn_Facturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Facturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturas.ForeColor = System.Drawing.Color.Silver;
            this.btn_Facturas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Facturas.IconColor = System.Drawing.Color.Silver;
            this.btn_Facturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Facturas.IconSize = 32;
            this.btn_Facturas.Location = new System.Drawing.Point(0, 691);
            this.btn_Facturas.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Facturas.Name = "btn_Facturas";
            this.btn_Facturas.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Facturas.Size = new System.Drawing.Size(332, 72);
            this.btn_Facturas.TabIndex = 12;
            this.btn_Facturas.Tag = "Facturas";
            this.btn_Facturas.Text = "Facturas";
            this.btn_Facturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Facturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Facturas.UseVisualStyleBackColor = false;
            // 
            // btn_Pagos
            // 
            this.btn_Pagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Pagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Pagos.FlatAppearance.BorderSize = 0;
            this.btn_Pagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Pagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pagos.ForeColor = System.Drawing.Color.Silver;
            this.btn_Pagos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Pagos.IconColor = System.Drawing.Color.Silver;
            this.btn_Pagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Pagos.IconSize = 32;
            this.btn_Pagos.Location = new System.Drawing.Point(0, 763);
            this.btn_Pagos.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Pagos.Name = "btn_Pagos";
            this.btn_Pagos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Pagos.Size = new System.Drawing.Size(332, 72);
            this.btn_Pagos.TabIndex = 13;
            this.btn_Pagos.Tag = "Pagos";
            this.btn_Pagos.Text = "Pagos";
            this.btn_Pagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pagos.UseVisualStyleBackColor = false;
            // 
            // btn_Inventarios
            // 
            this.btn_Inventarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Inventarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inventarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inventarios.FlatAppearance.BorderSize = 0;
            this.btn_Inventarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Inventarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Inventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventarios.ForeColor = System.Drawing.Color.Silver;
            this.btn_Inventarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Inventarios.IconColor = System.Drawing.Color.Silver;
            this.btn_Inventarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Inventarios.IconSize = 32;
            this.btn_Inventarios.Location = new System.Drawing.Point(0, 835);
            this.btn_Inventarios.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Inventarios.Name = "btn_Inventarios";
            this.btn_Inventarios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Inventarios.Size = new System.Drawing.Size(332, 72);
            this.btn_Inventarios.TabIndex = 14;
            this.btn_Inventarios.Tag = "Inventarios";
            this.btn_Inventarios.Text = "Inventarios";
            this.btn_Inventarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Inventarios.UseVisualStyleBackColor = false;
            // 
            // btn_Compras
            // 
            this.btn_Compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(85)))));
            this.btn_Compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Compras.FlatAppearance.BorderSize = 0;
            this.btn_Compras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(222)))));
            this.btn_Compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(74)))), ((int)(((byte)(240)))));
            this.btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compras.ForeColor = System.Drawing.Color.Silver;
            this.btn_Compras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Compras.IconColor = System.Drawing.Color.Silver;
            this.btn_Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Compras.IconSize = 32;
            this.btn_Compras.Location = new System.Drawing.Point(0, 907);
            this.btn_Compras.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Compras.Size = new System.Drawing.Size(332, 72);
            this.btn_Compras.TabIndex = 15;
            this.btn_Compras.Tag = "Compras";
            this.btn_Compras.Text = "Compras";
            this.btn_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Compras.UseVisualStyleBackColor = false;
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1892, 1093);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelSeparadorSuperior);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MenuPrincipal";
            this.Load += new System.EventHandler(this.frm_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelLateral)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelSeparacionLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSeparadorSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCentral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelLateral;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelLogo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelSuperior;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelSeparacionLateral;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelSeparadorSuperior;
        private FontAwesome.Sharp.IconButton btn_Clientes;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelCentral;
        private FontAwesome.Sharp.IconButton Btn_Materiales;
        private FontAwesome.Sharp.IconButton btn_Proveedores;
        private FontAwesome.Sharp.IconButton btn_CerrarS;
        private FontAwesome.Sharp.IconButton btn_Contratos;
        private FontAwesome.Sharp.IconButton btn_Servicios;
        private FontAwesome.Sharp.IconButton btn_Planilla;
        private FontAwesome.Sharp.IconButton btn_Empleados;
        private FontAwesome.Sharp.IconButton btn_Usuarios;
        private FontAwesome.Sharp.IconButton btn_Facturas;
        private FontAwesome.Sharp.IconButton btn_Pagos;
        private FontAwesome.Sharp.IconButton btn_Compras;
        private FontAwesome.Sharp.IconButton btn_Inventarios;
    }
}