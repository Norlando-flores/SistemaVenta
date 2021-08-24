
namespace SisVentaDevExpress.Formularios
{
    partial class frm_Trabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Trabajador));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.xpCollectiontrabajadores = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWorkTrabajadores = new DevExpress.Xpo.UnitOfWork(this.components);
            this.dataListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Nacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContraseña = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.chboxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbAcceso = new System.Windows.Forms.ComboBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarCambios = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCorreo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtidTrabajador = new System.Windows.Forms.TextBox();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblidTrabajador = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCedula = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDireccion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTelefono = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCorreo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblApellido = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblFechaNacimiento = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblAcceso = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblSexo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblContraseña = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloTrabajadores = new System.Windows.Forms.Label();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.search = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectiontrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblidTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaNacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAcceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tabControl1);
            this.layoutControl1.Controls.Add(this.pictureBox1);
            this.layoutControl1.Controls.Add(this.lblTituloTrabajadores);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(816, 551);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 439);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.layoutControl2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.lblTotal);
            this.layoutControl2.Controls.Add(this.btnEliminar);
            this.layoutControl2.Controls.Add(this.btnImprimir1);
            this.layoutControl2.Controls.Add(this.btnEditar1);
            this.layoutControl2.Controls.Add(this.btnAgregar);
            this.layoutControl2.Controls.Add(this.gridControl2);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(778, 407);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // lblTotal
            // 
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(12, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(375, 28);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(595, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 36);
            this.btnEliminar.StyleController = this.layoutControl2;
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimir1.Appearance.Options.UseFont = true;
            this.btnImprimir1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir1.ImageOptions.Image")));
            this.btnImprimir1.Location = new System.Drawing.Point(410, 12);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(181, 36);
            this.btnImprimir1.StyleController = this.layoutControl2;
            this.btnImprimir1.TabIndex = 3;
            this.btnImprimir1.Text = "Imprimir";
            this.btnImprimir1.Click += new System.EventHandler(this.btnImprimir1_Click);
            // 
            // btnEditar1
            // 
            this.btnEditar1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditar1.Appearance.Options.UseFont = true;
            this.btnEditar1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar1.ImageOptions.Image")));
            this.btnEditar1.Location = new System.Drawing.Point(213, 12);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(193, 36);
            this.btnEditar1.StyleController = this.layoutControl2;
            this.btnEditar1.TabIndex = 2;
            this.btnEditar1.Text = "Editar";
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(197, 36);
            this.btnAgregar.StyleController = this.layoutControl2;
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.xpCollectiontrabajadores;
            this.gridControl2.Location = new System.Drawing.Point(12, 52);
            this.gridControl2.MainView = this.dataListado;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(754, 311);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataListado});
            this.gridControl2.DoubleClick += new System.EventHandler(this.btnEditar1_Click);
            // 
            // xpCollectiontrabajadores
            // 
            this.xpCollectiontrabajadores.ObjectType = typeof(SisVentaDevExpress.Ventas.Trabajador);
            this.xpCollectiontrabajadores.Session = this.unitOfWorkTrabajadores;
            // 
            // dataListado
            // 
            this.dataListado.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dataListado.Appearance.GroupRow.Options.UseFont = true;
            this.dataListado.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dataListado.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dataListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre,
            this.colApellidos,
            this.colSexo,
            this.colFecha_Nacimiento,
            this.colCedula,
            this.colDireccion,
            this.colTelefono,
            this.colEmail,
            this.colAcceso,
            this.colUsuario,
            this.colContraseña});
            this.dataListado.GridControl = this.gridControl2;
            this.dataListado.Name = "dataListado";
            this.dataListado.OptionsBehavior.Editable = false;
            this.dataListado.OptionsFind.AlwaysVisible = true;
            this.dataListado.OptionsSelection.MultiSelect = true;
            // 
            // colNombre
            // 
            this.colNombre.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombre.AppearanceCell.Options.UseFont = true;
            this.colNombre.AppearanceCell.Options.UseTextOptions = true;
            this.colNombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombre.AppearanceHeader.Options.UseFont = true;
            this.colNombre.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colApellidos
            // 
            this.colApellidos.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colApellidos.AppearanceCell.Options.UseFont = true;
            this.colApellidos.AppearanceCell.Options.UseTextOptions = true;
            this.colApellidos.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colApellidos.AppearanceHeader.Options.UseFont = true;
            this.colApellidos.AppearanceHeader.Options.UseTextOptions = true;
            this.colApellidos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApellidos.Caption = "Apellidos";
            this.colApellidos.FieldName = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.Visible = true;
            this.colApellidos.VisibleIndex = 1;
            // 
            // colSexo
            // 
            this.colSexo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSexo.AppearanceCell.Options.UseFont = true;
            this.colSexo.AppearanceCell.Options.UseTextOptions = true;
            this.colSexo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSexo.AppearanceHeader.Options.UseFont = true;
            this.colSexo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSexo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSexo.Caption = "Sexo";
            this.colSexo.FieldName = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 2;
            // 
            // colFecha_Nacimiento
            // 
            this.colFecha_Nacimiento.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Nacimiento.AppearanceCell.Options.UseFont = true;
            this.colFecha_Nacimiento.AppearanceCell.Options.UseTextOptions = true;
            this.colFecha_Nacimiento.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Nacimiento.AppearanceHeader.Options.UseFont = true;
            this.colFecha_Nacimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.colFecha_Nacimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha_Nacimiento.Caption = "Fecha Nacimiento";
            this.colFecha_Nacimiento.FieldName = "Fecha_Nacimiento";
            this.colFecha_Nacimiento.Name = "colFecha_Nacimiento";
            this.colFecha_Nacimiento.Visible = true;
            this.colFecha_Nacimiento.VisibleIndex = 3;
            // 
            // colCedula
            // 
            this.colCedula.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCedula.AppearanceCell.Options.UseFont = true;
            this.colCedula.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCedula.AppearanceHeader.Options.UseFont = true;
            this.colCedula.AppearanceHeader.Options.UseTextOptions = true;
            this.colCedula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCedula.Caption = "Cedula";
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 4;
            // 
            // colDireccion
            // 
            this.colDireccion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDireccion.AppearanceCell.Options.UseFont = true;
            this.colDireccion.AppearanceCell.Options.UseTextOptions = true;
            this.colDireccion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDireccion.AppearanceHeader.Options.UseFont = true;
            this.colDireccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDireccion.Caption = "Direccion";
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 5;
            // 
            // colTelefono
            // 
            this.colTelefono.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTelefono.AppearanceCell.Options.UseFont = true;
            this.colTelefono.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefono.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTelefono.AppearanceHeader.Options.UseFont = true;
            this.colTelefono.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefono.Caption = "Telefono";
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceCell.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Correo";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // colAcceso
            // 
            this.colAcceso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAcceso.AppearanceCell.Options.UseFont = true;
            this.colAcceso.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAcceso.AppearanceHeader.Options.UseFont = true;
            this.colAcceso.AppearanceHeader.Options.UseTextOptions = true;
            this.colAcceso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAcceso.Caption = "Acceso";
            this.colAcceso.FieldName = "Acceso";
            this.colAcceso.Name = "colAcceso";
            this.colAcceso.Visible = true;
            this.colAcceso.VisibleIndex = 8;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUsuario.AppearanceCell.Options.UseFont = true;
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUsuario.AppearanceHeader.Options.UseFont = true;
            this.colUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 9;
            // 
            // colContraseña
            // 
            this.colContraseña.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colContraseña.AppearanceCell.Options.UseFont = true;
            this.colContraseña.AppearanceCell.Options.UseTextOptions = true;
            this.colContraseña.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colContraseña.AppearanceHeader.Options.UseFont = true;
            this.colContraseña.AppearanceHeader.Options.UseTextOptions = true;
            this.colContraseña.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContraseña.Caption = "Contraseña";
            this.colContraseña.FieldName = "Contraseña";
            this.colContraseña.Name = "colContraseña";
            this.colContraseña.Visible = true;
            this.colContraseña.VisibleIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem8,
            this.layoutControlItem13});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(778, 407);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(758, 315);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAgregar;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(201, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEditar1;
            this.layoutControlItem6.Location = new System.Drawing.Point(201, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(197, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnImprimir1;
            this.layoutControlItem7.Location = new System.Drawing.Point(398, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(185, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnEliminar;
            this.layoutControlItem8.Location = new System.Drawing.Point(583, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(175, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(379, 355);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(379, 32);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.lblTotal;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 355);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(379, 32);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.layoutControl3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.groupBox1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(3, 3);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(778, 407);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajadores";
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.chboxMostrarContraseña);
            this.layoutControl4.Controls.Add(this.txtContraseña);
            this.layoutControl4.Controls.Add(this.txtUsuario);
            this.layoutControl4.Controls.Add(this.cbSexo);
            this.layoutControl4.Controls.Add(this.cbAcceso);
            this.layoutControl4.Controls.Add(this.dtFechaNacimiento);
            this.layoutControl4.Controls.Add(this.txtApellido);
            this.layoutControl4.Controls.Add(this.btnCancelar);
            this.layoutControl4.Controls.Add(this.btnGuardarCambios);
            this.layoutControl4.Controls.Add(this.btnGuardar);
            this.layoutControl4.Controls.Add(this.txtCorreo);
            this.layoutControl4.Controls.Add(this.txtTelefono);
            this.layoutControl4.Controls.Add(this.txtDireccion);
            this.layoutControl4.Controls.Add(this.txtCedula);
            this.layoutControl4.Controls.Add(this.txtNombre);
            this.layoutControl4.Controls.Add(this.txtidTrabajador);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(3, 16);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup3;
            this.layoutControl4.Size = new System.Drawing.Size(748, 364);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // chboxMostrarContraseña
            // 
            this.chboxMostrarContraseña.Location = new System.Drawing.Point(600, 268);
            this.chboxMostrarContraseña.Name = "chboxMostrarContraseña";
            this.chboxMostrarContraseña.Size = new System.Drawing.Size(136, 20);
            this.chboxMostrarContraseña.TabIndex = 24;
            this.chboxMostrarContraseña.Text = "Mostrar Contraseña";
            this.chboxMostrarContraseña.UseVisualStyleBackColor = true;
            this.chboxMostrarContraseña.CheckedChanged += new System.EventHandler(this.chboxMostrarContraseña_CheckedChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(431, 268);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(165, 20);
            this.txtContraseña.TabIndex = 23;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(131, 268);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 20);
            this.txtUsuario.TabIndex = 22;
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(131, 90);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(241, 24);
            this.cbSexo.TabIndex = 21;
            // 
            // cbAcceso
            // 
            this.cbAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcceso.FormattingEnabled = true;
            this.cbAcceso.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Almasenero"});
            this.cbAcceso.Location = new System.Drawing.Point(495, 130);
            this.cbAcceso.Name = "cbAcceso";
            this.cbAcceso.Size = new System.Drawing.Size(241, 24);
            this.cbAcceso.TabIndex = 20;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(495, 90);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(241, 20);
            this.dtFechaNacimiento.TabIndex = 19;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(495, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 20);
            this.txtApellido.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(519, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(217, 36);
            this.btnCancelar.StyleController = this.layoutControl4;
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.ImageOptions.Image")));
            this.btnGuardarCambios.Location = new System.Drawing.Point(269, 316);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(246, 36);
            this.btnGuardarCambios.StyleController = this.layoutControl4;
            this.btnGuardarCambios.TabIndex = 14;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(12, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(253, 36);
            this.btnGuardar.StyleController = this.layoutControl4;
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.Color.Blue;
            this.txtCorreo.Location = new System.Drawing.Point(430, 229);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(306, 20);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTelefono.Location = new System.Drawing.Point(131, 229);
            this.txtTelefono.Mask = "(999)0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(241, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(131, 170);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(605, 40);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCedula.Location = new System.Drawing.Point(131, 130);
            this.txtCedula.Mask = "000-000000-0000A";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(241, 21);
            this.txtCedula.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(131, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtidTrabajador
            // 
            this.txtidTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtidTrabajador.Location = new System.Drawing.Point(131, 12);
            this.txtidTrabajador.Name = "txtidTrabajador";
            this.txtidTrabajador.Size = new System.Drawing.Size(605, 20);
            this.txtidTrabajador.TabIndex = 4;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblidTrabajador,
            this.lblNombre,
            this.lblCedula,
            this.lblDireccion,
            this.lblTelefono,
            this.lblCorreo,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.lblApellido,
            this.lblFechaNacimiento,
            this.emptySpaceItem3,
            this.emptySpaceItem7,
            this.lblAcceso,
            this.lblSexo,
            this.lblUsuario,
            this.lblContraseña,
            this.emptySpaceItem9,
            this.emptySpaceItem4,
            this.emptySpaceItem11,
            this.layoutControlItem3});
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(748, 364);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // lblidTrabajador
            // 
            this.lblidTrabajador.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblidTrabajador.AppearanceItemCaption.Options.UseFont = true;
            this.lblidTrabajador.Control = this.txtidTrabajador;
            this.lblidTrabajador.Location = new System.Drawing.Point(0, 0);
            this.lblidTrabajador.Name = "lblidTrabajador";
            this.lblidTrabajador.Size = new System.Drawing.Size(728, 24);
            this.lblidTrabajador.Text = "Id Proveedor:";
            this.lblidTrabajador.TextSize = new System.Drawing.Size(116, 16);
            this.lblidTrabajador.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lblNombre
            // 
            this.lblNombre.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.AppearanceItemCaption.Options.UseFont = true;
            this.lblNombre.Control = this.txtNombre;
            this.lblNombre.Location = new System.Drawing.Point(0, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(364, 24);
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblCedula
            // 
            this.lblCedula.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCedula.AppearanceItemCaption.Options.UseFont = true;
            this.lblCedula.Control = this.txtCedula;
            this.lblCedula.Location = new System.Drawing.Point(0, 118);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(364, 25);
            this.lblCedula.Text = "Cedula:";
            this.lblCedula.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.AppearanceItemCaption.Options.UseFont = true;
            this.lblDireccion.Control = this.txtDireccion;
            this.lblDireccion.Location = new System.Drawing.Point(0, 158);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(728, 44);
            this.lblDireccion.Text = "Direccion:";
            this.lblDireccion.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.AppearanceItemCaption.Options.UseFont = true;
            this.lblTelefono.Control = this.txtTelefono;
            this.lblTelefono.Location = new System.Drawing.Point(0, 217);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(364, 24);
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.AppearanceItemCaption.Options.UseFont = true;
            this.lblCorreo.Control = this.txtCorreo;
            this.lblCorreo.Location = new System.Drawing.Point(364, 217);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(364, 24);
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblCorreo.TextSize = new System.Drawing.Size(49, 16);
            this.lblCorreo.TextToControlDistance = 5;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnGuardar;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 304);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(257, 40);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnGuardarCambios;
            this.layoutControlItem11.Location = new System.Drawing.Point(257, 304);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(250, 40);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnCancelar;
            this.layoutControlItem12.Location = new System.Drawing.Point(507, 304);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(221, 40);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(728, 15);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 143);
            this.emptySpaceItem6.Name = "emptySpaceItem1";
            this.emptySpaceItem6.Size = new System.Drawing.Size(728, 15);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblApellido
            // 
            this.lblApellido.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApellido.AppearanceItemCaption.Options.UseFont = true;
            this.lblApellido.Control = this.txtApellido;
            this.lblApellido.Location = new System.Drawing.Point(364, 39);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(364, 24);
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimiento.AppearanceItemCaption.Options.UseFont = true;
            this.lblFechaNacimiento.Control = this.dtFechaNacimiento;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(364, 78);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(364, 25);
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            this.lblFechaNacimiento.TextSize = new System.Drawing.Size(116, 16);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 63);
            this.emptySpaceItem3.Name = "item0";
            this.emptySpaceItem3.Size = new System.Drawing.Size(728, 15);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 103);
            this.emptySpaceItem7.Name = "emptySpaceItem6";
            this.emptySpaceItem7.Size = new System.Drawing.Size(728, 15);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblAcceso
            // 
            this.lblAcceso.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceso.AppearanceItemCaption.Options.UseFont = true;
            this.lblAcceso.Control = this.cbAcceso;
            this.lblAcceso.Location = new System.Drawing.Point(364, 118);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(364, 25);
            this.lblAcceso.Text = "Acceso:";
            this.lblAcceso.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblSexo
            // 
            this.lblSexo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.AppearanceItemCaption.Options.UseFont = true;
            this.lblSexo.Control = this.cbSexo;
            this.lblSexo.Location = new System.Drawing.Point(0, 78);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(364, 25);
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.AppearanceItemCaption.Options.UseFont = true;
            this.lblUsuario.Control = this.txtUsuario;
            this.lblUsuario.Location = new System.Drawing.Point(0, 256);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(300, 24);
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextSize = new System.Drawing.Size(116, 16);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.AppearanceItemCaption.Options.UseFont = true;
            this.lblContraseña.Control = this.txtContraseña;
            this.lblContraseña.Location = new System.Drawing.Point(300, 256);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(288, 24);
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.TextSize = new System.Drawing.Size(116, 16);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(0, 202);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(728, 15);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 241);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(728, 15);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(0, 280);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(728, 24);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chboxMostrarContraseña;
            this.layoutControlItem3.Location = new System.Drawing.Point(588, 256);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(778, 407);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.groupBox1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(758, 387);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(208, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 84);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloTrabajadores
            // 
            this.lblTituloTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloTrabajadores.ForeColor = System.Drawing.Color.Blue;
            this.lblTituloTrabajadores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTituloTrabajadores.Location = new System.Drawing.Point(12, 12);
            this.lblTituloTrabajadores.Name = "lblTituloTrabajadores";
            this.lblTituloTrabajadores.Size = new System.Drawing.Size(192, 84);
            this.lblTituloTrabajadores.TabIndex = 5;
            this.lblTituloTrabajadores.Text = "Trabajadores";
            this.lblTituloTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.search,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(816, 551);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(302, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(494, 88);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // search
            // 
            this.search.Control = this.lblTituloTrabajadores;
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(196, 88);
            this.search.TextSize = new System.Drawing.Size(0, 0);
            this.search.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(196, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(106, 88);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tabControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(796, 443);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 280);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(712, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm_Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 551);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_Trabajador";
            this.Text = "Mantenimiento de trabajadores";
            this.Load += new System.EventHandler(this.frm_Trabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectiontrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblidTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaNacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAcceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.Label lblTituloTrabajadores;
        private DevExpress.XtraLayout.LayoutControlItem search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.Label lblTotal;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnImprimir1;
        private DevExpress.XtraEditors.SimpleButton btnEditar1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView dataListado;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCambios;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.MaskedTextBox txtCorreo;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtidTrabajador;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem lblidTrabajador;
        private DevExpress.XtraLayout.LayoutControlItem lblNombre;
        private DevExpress.XtraLayout.LayoutControlItem lblCedula;
        private DevExpress.XtraLayout.LayoutControlItem lblDireccion;
        private DevExpress.XtraLayout.LayoutControlItem lblTelefono;
        private DevExpress.XtraLayout.LayoutControlItem lblCorreo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem lblApellido;
        private DevExpress.XtraLayout.LayoutControlItem lblFechaNacimiento;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Xpo.UnitOfWork unitOfWorkTrabajadores;
        private DevExpress.Xpo.XPCollection xpCollectiontrabajadores;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbAcceso;
        private DevExpress.XtraLayout.LayoutControlItem lblAcceso;
        private DevExpress.XtraLayout.LayoutControlItem lblSexo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lblUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lblContraseña;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Nacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceso;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colContraseña;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.CheckBox chboxMostrarContraseña;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}