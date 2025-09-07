namespace CapaPresentacion
{
    partial class frm_Empleados
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Empleados));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new FontAwesome.Sharp.IconToolStripButton();
            this.btnEditar = new FontAwesome.Sharp.IconToolStripButton();
            this.btnEliminar = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.btnCerrar = new FontAwesome.Sharp.IconToolStripButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.cbox_Estado = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbox_TipoEmpleado = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dtp_FechaIngreso = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btn_Agregar1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Limpiar1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_SalarioBase = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny9 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny10 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Direccion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Dpi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Nombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_codigoEmpleado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Agregar = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Limpiar = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvEmpleados = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_TipoEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.iconToolStripButton1,
            this.btnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1280, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAgregar.Size = new System.Drawing.Size(86, 36);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEditar.Size = new System.Drawing.Size(71, 36);
            this.btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEliminar.Size = new System.Drawing.Size(87, 36);
            this.btnEliminar.Text = "Eliminar";
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.iconToolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconToolStripButton1.Size = new System.Drawing.Size(79, 36);
            this.iconToolStripButton1.Text = "Limpiar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCerrar.Size = new System.Drawing.Size(66, 36);
            this.btnCerrar.Text = "Cerrar";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 44);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonHeaderGroup2);
            this.kryptonSplitContainer1.Panel1MinSize = 380;
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1280, 676);
            this.kryptonSplitContainer1.SplitterDistance = 420;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Padding = new System.Windows.Forms.Padding(16);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.cbox_Estado);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.cbox_TipoEmpleado);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.dtp_FechaIngreso);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_SalarioBase);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Direccion);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Dpi);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Nombre);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_codigoEmpleado);
            this.kryptonHeaderGroup2.Panel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::CapaPresentacion.Properties.Settings.Default, "Arial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.kryptonHeaderGroup2.Panel.Font = global::CapaPresentacion.Properties.Settings.Default.Arial;
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(420, 676);
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.TabIndex = 1;
            this.kryptonHeaderGroup2.ValuesPrimary.Description = "Captura de datos";
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Empleado";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup2.ValuesSecondary.Description = "Registros: 0";
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "";
            // 
            // cbox_Estado
            // 
            this.cbox_Estado.DropDownWidth = 121;
            this.cbox_Estado.Items.AddRange(new object[] {
            "Activo",
            "Suspendido",
            "Despedido"});
            this.cbox_Estado.Location = new System.Drawing.Point(20, 540);
            this.cbox_Estado.Name = "cbox_Estado";
            this.cbox_Estado.Size = new System.Drawing.Size(372, 41);
            this.cbox_Estado.TabIndex = 8;
            // 
            // cbox_TipoEmpleado
            // 
            this.cbox_TipoEmpleado.DropDownWidth = 121;
            this.cbox_TipoEmpleado.Items.AddRange(new object[] {
            "Gerente",
            "Supervisor",
            "Informatica",
            "Contabilidad"});
            this.cbox_TipoEmpleado.Location = new System.Drawing.Point(20, 460);
            this.cbox_TipoEmpleado.Name = "cbox_TipoEmpleado";
            this.cbox_TipoEmpleado.Size = new System.Drawing.Size(372, 41);
            this.cbox_TipoEmpleado.TabIndex = 7;
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Agregar1,
            this.btn_Limpiar1});
            this.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(20, 314);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(372, 42);
            this.dtp_FechaIngreso.TabIndex = 5;
            // 
            // btn_Agregar1
            // 
            this.btn_Agregar1.Image = global::CapaPresentacion.Properties.Resources.comprobado;
            this.btn_Agregar1.UniqueName = "0106D413D09A42FCD791E8C2B7E046CC";
            // 
            // btn_Limpiar1
            // 
            this.btn_Limpiar1.Image = global::CapaPresentacion.Properties.Resources.borrar2;
            this.btn_Limpiar1.UniqueName = "2FB1B58AC8D44BF81ABC7E1ACDC96572";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(20, 510);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(76, 24);
            this.kryptonLabel8.TabIndex = 15;
            this.kryptonLabel8.Values.Text = "Estado:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(20, 430);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(149, 24);
            this.kryptonLabel7.TabIndex = 13;
            this.kryptonLabel7.Values.Text = "Tipo de empleado:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(20, 360);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(97, 24);
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "Salario base:";
            // 
            // txt_SalarioBase
            // 
            this.txt_SalarioBase.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny9,
            this.buttonSpecAny10});
            this.txt_SalarioBase.Location = new System.Drawing.Point(20, 384);
            this.txt_SalarioBase.Name = "txt_SalarioBase";
            this.txt_SalarioBase.Size = new System.Drawing.Size(372, 49);
            this.txt_SalarioBase.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txt_SalarioBase.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txt_SalarioBase.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_SalarioBase.StateActive.Border.Rounding = 6;
            this.txt_SalarioBase.StateActive.Border.Width = 1;
            this.txt_SalarioBase.TabIndex = 6;
            // 
            // buttonSpecAny9
            // 
            this.buttonSpecAny9.Image = global::CapaPresentacion.Properties.Resources.comprobado;
            this.buttonSpecAny9.UniqueName = "C59FEC65F783439D10A4308AEF138039";
            // 
            // buttonSpecAny10
            // 
            this.buttonSpecAny10.Image = global::CapaPresentacion.Properties.Resources.borrar2;
            this.buttonSpecAny10.UniqueName = "C796A866191346BF26A9BA72BA4341FE";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(20, 286);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(108, 24);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Fecha ingreso:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(20, 216);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(77, 24);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Dirección:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5,
            this.buttonSpecAny6});
            this.txt_Direccion.Location = new System.Drawing.Point(20, 240);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(372, 49);
            this.txt_Direccion.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txt_Direccion.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txt_Direccion.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Direccion.StateActive.Border.Rounding = 6;
            this.txt_Direccion.StateActive.Border.Width = 1;
            this.txt_Direccion.TabIndex = 4;
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Image = global::CapaPresentacion.Properties.Resources.comprobado;
            this.buttonSpecAny5.UniqueName = "C59FEC65F783439D10A4308AEF138039";
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Image = global::CapaPresentacion.Properties.Resources.borrar2;
            this.buttonSpecAny6.UniqueName = "C796A866191346BF26A9BA72BA4341FE";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(20, 146);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(37, 24);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "DPI:";
            // 
            // txt_Dpi
            // 
            this.txt_Dpi.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3,
            this.buttonSpecAny4});
            this.txt_Dpi.Location = new System.Drawing.Point(20, 170);
            this.txt_Dpi.Name = "txt_Dpi";
            this.txt_Dpi.Size = new System.Drawing.Size(372, 49);
            this.txt_Dpi.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txt_Dpi.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txt_Dpi.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Dpi.StateActive.Border.Rounding = 6;
            this.txt_Dpi.StateActive.Border.Width = 1;
            this.txt_Dpi.TabIndex = 3;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Image = global::CapaPresentacion.Properties.Resources.comprobado;
            this.buttonSpecAny3.UniqueName = "C59FEC65F783439D10A4308AEF138039";
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Image = global::CapaPresentacion.Properties.Resources.borrar2;
            this.buttonSpecAny4.UniqueName = "C796A866191346BF26A9BA72BA4341FE";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(20, 76);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(69, 24);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1,
            this.buttonSpecAny2});
            this.txt_Nombre.Location = new System.Drawing.Point(20, 100);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(372, 49);
            this.txt_Nombre.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txt_Nombre.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txt_Nombre.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Nombre.StateActive.Border.Rounding = 6;
            this.txt_Nombre.StateActive.Border.Width = 1;
            this.txt_Nombre.TabIndex = 2;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::CapaPresentacion.Properties.Resources.comprobado;
            this.buttonSpecAny1.UniqueName = "C59FEC65F783439D10A4308AEF138039";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::CapaPresentacion.Properties.Resources.borrar2;
            this.buttonSpecAny2.UniqueName = "C796A866191346BF26A9BA72BA4341FE";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 10);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(130, 24);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Código Empleado:";
            // 
            // txt_codigoEmpleado
            // 
            this.txt_codigoEmpleado.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Agregar,
            this.btn_Limpiar});
            this.txt_codigoEmpleado.Location = new System.Drawing.Point(20, 34);
            this.txt_codigoEmpleado.Name = "txt_codigoEmpleado";
            this.txt_codigoEmpleado.Size = new System.Drawing.Size(372, 49);
            this.txt_codigoEmpleado.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txt_codigoEmpleado.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txt_codigoEmpleado.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_codigoEmpleado.StateActive.Border.Rounding = 6;
            this.txt_codigoEmpleado.StateActive.Border.Width = 1;
            this.txt_codigoEmpleado.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.UniqueName = "C59FEC65F783439D10A4308AEF138039";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Image")));
            this.btn_Limpiar.UniqueName = "C796A866191346BF26A9BA72BA4341FE";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::CapaPresentacion.Properties.Settings.Default, "Arial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Font = global::CapaPresentacion.Properties.Settings.Default.Arial;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Padding = new System.Windows.Forms.Padding(8);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dgvEmpleados);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(855, 676);
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "Listado de empleados";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Empleados";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "Registros: 0";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowTemplate.Height = 28;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(853, 642);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "frm_Empleados";
            this.Text = "Gestión de Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbox_Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_TipoEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton btnAgregar;
        private FontAwesome.Sharp.IconToolStripButton btnEditar;
        private FontAwesome.Sharp.IconToolStripButton btnEliminar;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton btnCerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEmpleados;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_SalarioBase;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny9;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Direccion;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Dpi;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Nombre;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_FechaIngreso;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Agregar1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Limpiar1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_codigoEmpleado;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Agregar;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Limpiar;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbox_TipoEmpleado;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbox_Estado;
    }
}
