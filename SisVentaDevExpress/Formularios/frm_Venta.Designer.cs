
namespace SisVentaDevExpress.Formularios
{
    partial class frm_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Venta));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnComprobante = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWorkVentas = new DevExpress.Xpo.UnitOfWork(this.components);
            this.dataListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoComprovante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsecutivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.txtIGV = new System.Windows.Forms.MaskedTextBox();
            this.sbTrabajador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionTrabajador = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewTrabajador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NonbreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionCliente = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlDetalleVenta = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionDetalleVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.dataListadoDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtuculoDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDescuento = new System.Windows.Forms.MaskedTextBox();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.txtPrescioTotal = new System.Windows.Forms.TextBox();
            this.sbArticulo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionArticulo = new DevExpress.Xpo.XPCollection(this.components);
            this.gridviewArticulo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistecia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.txtstockActual = new System.Windows.Forms.TextBox();
            this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdDetalleVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblDetalleIngreso = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblArticulo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblPrecioVenta = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblExistencia = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblPrecioTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblcantidadSolisitada = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDescuento1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.cbComprobante = new System.Windows.Forms.ComboBox();
            this.dtFechaventa = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarCambios = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSerie = new System.Windows.Forms.MaskedTextBox();
            this.txtidVenta = new System.Windows.Forms.TextBox();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCorrelativo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTrabajador = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblComprobante = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblSerie = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblIGV = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblidTrabajador = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblFechaVenta = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloIngresos = new System.Windows.Forms.Label();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWorkDetalleIngreso = new DevExpress.Xpo.UnitOfWork(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbTrabajador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).BeginInit();
            this.layoutControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetalleIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcantidadSolisitada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescuento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCorrelativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblidTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkDetalleIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tabControl1);
            this.layoutControl1.Controls.Add(this.pictureBox1);
            this.layoutControl1.Controls.Add(this.lblTituloIngresos);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 175, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(935, 554);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.layoutControl2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnComprobante);
            this.layoutControl2.Controls.Add(this.lblTotal);
            this.layoutControl2.Controls.Add(this.btnEliminar);
            this.layoutControl2.Controls.Add(this.btnImprimir1);
            this.layoutControl2.Controls.Add(this.btnEditar1);
            this.layoutControl2.Controls.Add(this.btnAgregar);
            this.layoutControl2.Controls.Add(this.gridControl2);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 156, 650, 400);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(897, 435);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnComprobante
            // 
            this.btnComprobante.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.Appearance.Options.UseFont = true;
            this.btnComprobante.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobante.ImageOptions.Image")));
            this.btnComprobante.Location = new System.Drawing.Point(206, 12);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(121, 36);
            this.btnComprobante.StyleController = this.layoutControl2;
            this.btnComprobante.TabIndex = 3;
            this.btnComprobante.Text = "Comproante";
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(12, 403);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(243, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(436, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 36);
            this.btnEliminar.StyleController = this.layoutControl2;
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimir1.Appearance.Options.UseFont = true;
            this.btnImprimir1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir1.ImageOptions.Image")));
            this.btnImprimir1.Location = new System.Drawing.Point(331, 12);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(101, 36);
            this.btnImprimir1.StyleController = this.layoutControl2;
            this.btnImprimir1.TabIndex = 4;
            this.btnImprimir1.Text = "Imprimir";
            this.btnImprimir1.Click += new System.EventHandler(this.btnImprimir1_Click);
            // 
            // btnEditar1
            // 
            this.btnEditar1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditar1.Appearance.Options.UseFont = true;
            this.btnEditar1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar1.ImageOptions.Image")));
            this.btnEditar1.Location = new System.Drawing.Point(112, 12);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(90, 36);
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
            this.btnAgregar.Size = new System.Drawing.Size(96, 36);
            this.btnAgregar.StyleController = this.layoutControl2;
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.xpCollectionVenta;
            this.gridControl2.Location = new System.Drawing.Point(12, 52);
            this.gridControl2.MainView = this.dataListado;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(873, 347);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataListado});
            this.gridControl2.DoubleClick += new System.EventHandler(this.btnEditar1_Click);
            // 
            // xpCollectionVenta
            // 
            this.xpCollectionVenta.ObjectType = typeof(SisVentaDevExpress.Ventas.Venta);
            this.xpCollectionVenta.Session = this.unitOfWorkVentas;
            // 
            // dataListado
            // 
            this.dataListado.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.dataListado.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dataListado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListado.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataListado.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListado.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.dataListado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dataListado.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dataListado.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dataListado.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dataListado.Appearance.Empty.Options.UseBackColor = true;
            this.dataListado.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataListado.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.dataListado.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.dataListado.Appearance.EvenRow.Options.UseBackColor = true;
            this.dataListado.Appearance.EvenRow.Options.UseForeColor = true;
            this.dataListado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListado.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.dataListado.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListado.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.dataListado.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dataListado.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dataListado.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.dataListado.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.dataListado.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListado.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.dataListado.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dataListado.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dataListado.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dataListado.Appearance.FixedLine.Options.UseBackColor = true;
            this.dataListado.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataListado.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dataListado.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dataListado.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.dataListado.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.SteelBlue;
            this.dataListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListado.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.dataListado.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dataListado.Appearance.FocusedRow.Options.UseFont = true;
            this.dataListado.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dataListado.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListado.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dataListado.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dataListado.Appearance.FooterPanel.Options.UseFont = true;
            this.dataListado.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.GroupButton.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dataListado.Appearance.GroupButton.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListado.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListado.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListado.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dataListado.Appearance.GroupFooter.Options.UseFont = true;
            this.dataListado.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.dataListado.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.dataListado.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataListado.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupPanel.Options.UseFont = true;
            this.dataListado.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupRow.BackColor = System.Drawing.Color.LightGray;
            this.dataListado.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListado.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.GroupRow.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupRow.Options.UseFont = true;
            this.dataListado.Appearance.GroupRow.Options.UseForeColor = true;
            this.dataListado.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataListado.Appearance.HeaderPanel.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.dataListado.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListado.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dataListado.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dataListado.Appearance.HeaderPanel.Options.UseFont = true;
            this.dataListado.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dataListado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.dataListado.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListado.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dataListado.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dataListado.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.HorzLine.Options.UseBackColor = true;
            this.dataListado.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dataListado.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.dataListado.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.dataListado.Appearance.OddRow.Options.UseBackColor = true;
            this.dataListado.Appearance.OddRow.Options.UseForeColor = true;
            this.dataListado.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.dataListado.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListado.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.dataListado.Appearance.Preview.Options.UseBackColor = true;
            this.dataListado.Appearance.Preview.Options.UseFont = true;
            this.dataListado.Appearance.Preview.Options.UseForeColor = true;
            this.dataListado.Appearance.Row.BackColor = System.Drawing.Color.LightGray;
            this.dataListado.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListado.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.Row.Options.UseBackColor = true;
            this.dataListado.Appearance.Row.Options.UseFont = true;
            this.dataListado.Appearance.Row.Options.UseForeColor = true;
            this.dataListado.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dataListado.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dataListado.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dataListado.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.dataListado.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dataListado.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dataListado.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.VertLine.Options.UseBackColor = true;
            this.dataListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaVenta,
            this.colTrabajador,
            this.colCliente2,
            this.colTipoComprovante,
            this.colSerie,
            this.colConsecutivo,
            this.colSubtotal,
            this.colIVA,
            this.colTotalPagar});
            this.dataListado.GridControl = this.gridControl2;
            this.dataListado.Name = "dataListado";
            this.dataListado.OptionsBehavior.Editable = false;
            this.dataListado.OptionsFind.AlwaysVisible = true;
            this.dataListado.OptionsSelection.MultiSelect = true;
            this.dataListado.OptionsView.EnableAppearanceEvenRow = true;
            this.dataListado.OptionsView.EnableAppearanceOddRow = true;
            this.dataListado.OptionsView.ShowGroupPanel = false;
            this.dataListado.PaintStyleName = "Flat";
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFechaVenta.AppearanceCell.Options.UseFont = true;
            this.colFechaVenta.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaVenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaVenta.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFechaVenta.AppearanceHeader.Options.UseFont = true;
            this.colFechaVenta.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaVenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaVenta.Caption = "Fecha Venta";
            this.colFechaVenta.DisplayFormat.FormatString = "d";
            this.colFechaVenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaVenta.FieldName = "Fecha";
            this.colFechaVenta.Name = "colFechaVenta";
            this.colFechaVenta.Visible = true;
            this.colFechaVenta.VisibleIndex = 0;
            // 
            // colTrabajador
            // 
            this.colTrabajador.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTrabajador.AppearanceCell.Options.UseFont = true;
            this.colTrabajador.AppearanceCell.Options.UseTextOptions = true;
            this.colTrabajador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrabajador.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTrabajador.AppearanceHeader.Options.UseFont = true;
            this.colTrabajador.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrabajador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrabajador.Caption = "Trabajador";
            this.colTrabajador.FieldName = "IdTrabajador.NombreCompleto";
            this.colTrabajador.Name = "colTrabajador";
            this.colTrabajador.Visible = true;
            this.colTrabajador.VisibleIndex = 1;
            // 
            // colCliente2
            // 
            this.colCliente2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente2.AppearanceCell.Options.UseFont = true;
            this.colCliente2.AppearanceCell.Options.UseTextOptions = true;
            this.colCliente2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCliente2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente2.AppearanceHeader.Options.UseFont = true;
            this.colCliente2.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliente2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCliente2.Caption = "Cliente";
            this.colCliente2.FieldName = "IdCliente.NombreCompleto";
            this.colCliente2.Name = "colCliente2";
            this.colCliente2.Visible = true;
            this.colCliente2.VisibleIndex = 2;
            // 
            // colTipoComprovante
            // 
            this.colTipoComprovante.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoComprovante.AppearanceCell.Options.UseFont = true;
            this.colTipoComprovante.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoComprovante.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipoComprovante.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoComprovante.AppearanceHeader.Options.UseFont = true;
            this.colTipoComprovante.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoComprovante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipoComprovante.Caption = "Comprovante";
            this.colTipoComprovante.FieldName = "Tipo_Comprobante";
            this.colTipoComprovante.Name = "colTipoComprovante";
            this.colTipoComprovante.Visible = true;
            this.colTipoComprovante.VisibleIndex = 3;
            // 
            // colSerie
            // 
            this.colSerie.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSerie.AppearanceCell.Options.UseFont = true;
            this.colSerie.AppearanceCell.Options.UseTextOptions = true;
            this.colSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSerie.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSerie.AppearanceHeader.Options.UseFont = true;
            this.colSerie.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 4;
            // 
            // colConsecutivo
            // 
            this.colConsecutivo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colConsecutivo.AppearanceCell.Options.UseFont = true;
            this.colConsecutivo.AppearanceCell.Options.UseTextOptions = true;
            this.colConsecutivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colConsecutivo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colConsecutivo.AppearanceHeader.Options.UseFont = true;
            this.colConsecutivo.AppearanceHeader.Options.UseTextOptions = true;
            this.colConsecutivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colConsecutivo.Caption = "Consecutivo";
            this.colConsecutivo.FieldName = "Correlativo";
            this.colConsecutivo.Name = "colConsecutivo";
            this.colConsecutivo.Visible = true;
            this.colConsecutivo.VisibleIndex = 5;
            // 
            // colSubtotal
            // 
            this.colSubtotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSubtotal.AppearanceCell.Options.UseFont = true;
            this.colSubtotal.AppearanceCell.Options.UseTextOptions = true;
            this.colSubtotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubtotal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSubtotal.AppearanceHeader.Options.UseFont = true;
            this.colSubtotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubtotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubtotal.Caption = "Sub Total";
            this.colSubtotal.DisplayFormat.FormatString = "C$ {0:n2}";
            this.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubtotal.FieldName = "SubTotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 6;
            // 
            // colIVA
            // 
            this.colIVA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIVA.AppearanceCell.Options.UseFont = true;
            this.colIVA.AppearanceCell.Options.UseTextOptions = true;
            this.colIVA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIVA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIVA.AppearanceHeader.Options.UseFont = true;
            this.colIVA.AppearanceHeader.Options.UseTextOptions = true;
            this.colIVA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIVA.Caption = "IVA";
            this.colIVA.DisplayFormat.FormatString = "{0} %";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IGV";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 7;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotalPagar.AppearanceCell.Options.UseFont = true;
            this.colTotalPagar.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalPagar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPagar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotalPagar.AppearanceHeader.Options.UseFont = true;
            this.colTotalPagar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPagar.Caption = "Total Pagar";
            this.colTotalPagar.DisplayFormat.FormatString = "C$ {0:n2}";
            this.colTotalPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPagar.FieldName = "TotalPagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 8;
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
            this.layoutControlItem13,
            this.emptySpaceItem1,
            this.layoutControlItem20});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(897, 435);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(877, 351);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAgregar;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(100, 40);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(100, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(100, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEditar1;
            this.layoutControlItem6.Location = new System.Drawing.Point(100, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(94, 40);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(94, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(94, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnImprimir1;
            this.layoutControlItem7.Location = new System.Drawing.Point(319, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(105, 40);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(105, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(105, 40);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnEliminar;
            this.layoutControlItem8.Location = new System.Drawing.Point(424, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(101, 40);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(101, 40);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(101, 40);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(247, 391);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(630, 24);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.lblTotal;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 391);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(247, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(247, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(247, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(525, 0);
            this.emptySpaceItem1.Name = "item0";
            this.emptySpaceItem1.Size = new System.Drawing.Size(352, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.btnComprobante;
            this.layoutControlItem20.Location = new System.Drawing.Point(194, 0);
            this.layoutControlItem20.MaxSize = new System.Drawing.Size(125, 40);
            this.layoutControlItem20.MinSize = new System.Drawing.Size(125, 40);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(125, 40);
            this.layoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem20.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem20.TextVisible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.layoutControl3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 441);
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
            this.layoutControl3.Size = new System.Drawing.Size(897, 435);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.txtIGV);
            this.layoutControl4.Controls.Add(this.sbTrabajador);
            this.layoutControl4.Controls.Add(this.sbCliente);
            this.layoutControl4.Controls.Add(this.gridControlDetalleVenta);
            this.layoutControl4.Controls.Add(this.groupBox2);
            this.layoutControl4.Controls.Add(this.txtCorrelativo);
            this.layoutControl4.Controls.Add(this.cbComprobante);
            this.layoutControl4.Controls.Add(this.dtFechaventa);
            this.layoutControl4.Controls.Add(this.btnCancelar);
            this.layoutControl4.Controls.Add(this.btnGuardarCambios);
            this.layoutControl4.Controls.Add(this.btnGuardar);
            this.layoutControl4.Controls.Add(this.txtSerie);
            this.layoutControl4.Controls.Add(this.txtidVenta);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(3, 16);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(409, 474, 650, 400);
            this.layoutControl4.Root = this.layoutControlGroup3;
            this.layoutControl4.Size = new System.Drawing.Size(867, 392);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // txtIGV
            // 
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(740, 38);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(105, 22);
            this.txtIGV.TabIndex = 30;
            this.txtIGV.Text = "15";
            this.txtIGV.ValidatingType = typeof(int);
            // 
            // sbTrabajador
            // 
            this.sbTrabajador.EditValue = "";
            this.sbTrabajador.Location = new System.Drawing.Point(120, 12);
            this.sbTrabajador.Name = "sbTrabajador";
            this.sbTrabajador.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTrabajador.Properties.Appearance.Options.UseFont = true;
            this.sbTrabajador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbTrabajador.Properties.DataSource = this.xpCollectionTrabajador;
            this.sbTrabajador.Properties.DisplayMember = "NombreCompleto";
            this.sbTrabajador.Properties.PopupView = this.gridViewTrabajador;
            this.sbTrabajador.Properties.ValueMember = "IdTrabajador";
            this.sbTrabajador.Size = new System.Drawing.Size(185, 22);
            this.sbTrabajador.StyleController = this.layoutControl4;
            this.sbTrabajador.TabIndex = 29;
            // 
            // xpCollectionTrabajador
            // 
            this.xpCollectionTrabajador.ObjectType = typeof(SisVentaDevExpress.Ventas.Trabajador);
            this.xpCollectionTrabajador.Session = this.unitOfWorkVentas;
            // 
            // gridViewTrabajador
            // 
            this.gridViewTrabajador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NonbreCompleto});
            this.gridViewTrabajador.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewTrabajador.Name = "gridViewTrabajador";
            this.gridViewTrabajador.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewTrabajador.OptionsView.ShowGroupPanel = false;
            // 
            // NonbreCompleto
            // 
            this.NonbreCompleto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonbreCompleto.AppearanceCell.Options.UseFont = true;
            this.NonbreCompleto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonbreCompleto.AppearanceHeader.Options.UseFont = true;
            this.NonbreCompleto.AppearanceHeader.Options.UseTextOptions = true;
            this.NonbreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NonbreCompleto.Caption = "Trabajador";
            this.NonbreCompleto.FieldName = "NombreCompleto";
            this.NonbreCompleto.Name = "NonbreCompleto";
            this.NonbreCompleto.Visible = true;
            this.NonbreCompleto.VisibleIndex = 0;
            // 
            // sbCliente
            // 
            this.sbCliente.EditValue = "";
            this.sbCliente.Location = new System.Drawing.Point(120, 38);
            this.sbCliente.Name = "sbCliente";
            this.sbCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCliente.Properties.Appearance.Options.UseFont = true;
            this.sbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbCliente.Properties.DataSource = this.xpCollectionCliente;
            this.sbCliente.Properties.DisplayMember = "NombreCompleto";
            this.sbCliente.Properties.PopupView = this.gridViewCliente;
            this.sbCliente.Properties.ValueMember = "IdCliente";
            this.sbCliente.Size = new System.Drawing.Size(264, 22);
            this.sbCliente.StyleController = this.layoutControl4;
            this.sbCliente.TabIndex = 28;
            // 
            // xpCollectionCliente
            // 
            this.xpCollectionCliente.ObjectType = typeof(SisVentaDevExpress.Ventas.Cliente);
            this.xpCollectionCliente.Session = this.unitOfWorkVentas;
            // 
            // gridViewCliente
            // 
            this.gridViewCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCliente});
            this.gridViewCliente.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCliente.Name = "gridViewCliente";
            this.gridViewCliente.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCliente.OptionsView.ShowGroupPanel = false;
            // 
            // colCliente
            // 
            this.colCliente.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente.AppearanceCell.Options.UseFont = true;
            this.colCliente.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente.AppearanceHeader.Options.UseFont = true;
            this.colCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "NombreCompleto";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 0;
            // 
            // gridControlDetalleVenta
            // 
            this.gridControlDetalleVenta.DataSource = this.xpCollectionDetalleVenta;
            this.gridControlDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlDetalleVenta.Location = new System.Drawing.Point(12, 177);
            this.gridControlDetalleVenta.MainView = this.dataListadoDetalle;
            this.gridControlDetalleVenta.Name = "gridControlDetalleVenta";
            this.gridControlDetalleVenta.Size = new System.Drawing.Size(843, 163);
            this.gridControlDetalleVenta.TabIndex = 25;
            this.gridControlDetalleVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataListadoDetalle});
            this.gridControlDetalleVenta.Click += new System.EventHandler(this.gridControlDetalleVenta_Click);
            this.gridControlDetalleVenta.DoubleClick += new System.EventHandler(this.gridControlDetalleVenta_DoubleClick);
            // 
            // xpCollectionDetalleVenta
            // 
            this.xpCollectionDetalleVenta.ObjectType = typeof(SisVentaDevExpress.Ventas.Detalle_venta);
            this.xpCollectionDetalleVenta.Session = this.unitOfWorkVentas;
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListadoDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dataListadoDetalle.Appearance.Empty.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataListadoDetalle.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.dataListadoDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.dataListadoDetalle.Appearance.EvenRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.EvenRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListadoDetalle.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.dataListadoDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListadoDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.dataListadoDetalle.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.dataListadoDetalle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListadoDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.dataListadoDetalle.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dataListadoDetalle.Appearance.FixedLine.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataListadoDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.dataListadoDetalle.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.dataListadoDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.FooterPanel.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.GroupButton.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.GroupButton.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListadoDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListadoDetalle.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.dataListadoDetalle.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataListadoDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupPanel.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.LightGray;
            this.dataListadoDetalle.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.GroupRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.GroupRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataListadoDetalle.Appearance.HeaderPanel.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.dataListadoDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.dataListadoDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListadoDetalle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.HorzLine.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.dataListadoDetalle.Appearance.OddRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.OddRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.dataListadoDetalle.Appearance.Preview.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.Preview.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.Preview.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.Row.BackColor = System.Drawing.Color.SteelBlue;
            this.dataListadoDetalle.Appearance.Row.BackColor2 = System.Drawing.Color.SteelBlue;
            this.dataListadoDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.dataListadoDetalle.Appearance.Row.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.Row.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.Row.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dataListadoDetalle.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.dataListadoDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.VertLine.Options.UseBackColor = true;
            this.dataListadoDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colArtuculoDetalle,
            this.colCategoria1,
            this.colPresentacion1,
            this.colprecioVenta,
            this.colCantidad,
            this.colDescuento,
            this.colTotal});
            this.dataListadoDetalle.GridControl = this.gridControlDetalleVenta;
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.OptionsBehavior.Editable = false;
            this.dataListadoDetalle.OptionsFind.AlwaysVisible = true;
            this.dataListadoDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.dataListadoDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.dataListadoDetalle.OptionsView.ShowFooter = true;
            this.dataListadoDetalle.OptionsView.ShowGroupPanel = false;
            this.dataListadoDetalle.PaintStyleName = "Flat";
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigo.AppearanceCell.Options.UseFont = true;
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigo.AppearanceHeader.Options.UseFont = true;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.Caption = "Codigo";
            this.colCodigo.FieldName = "IdArticulo.Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colArtuculoDetalle
            // 
            this.colArtuculoDetalle.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colArtuculoDetalle.AppearanceCell.Options.UseFont = true;
            this.colArtuculoDetalle.AppearanceCell.Options.UseTextOptions = true;
            this.colArtuculoDetalle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArtuculoDetalle.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colArtuculoDetalle.AppearanceHeader.Options.UseFont = true;
            this.colArtuculoDetalle.AppearanceHeader.Options.UseTextOptions = true;
            this.colArtuculoDetalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArtuculoDetalle.Caption = "Articulo";
            this.colArtuculoDetalle.FieldName = "IdArticulo.Nombre";
            this.colArtuculoDetalle.Name = "colArtuculoDetalle";
            this.colArtuculoDetalle.Visible = true;
            this.colArtuculoDetalle.VisibleIndex = 1;
            // 
            // colCategoria1
            // 
            this.colCategoria1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria1.AppearanceCell.Options.UseFont = true;
            this.colCategoria1.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoria1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoria1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria1.AppearanceHeader.Options.UseFont = true;
            this.colCategoria1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoria1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoria1.Caption = "Categoria";
            this.colCategoria1.FieldName = "IdArticulo.IdCategoria.Nombre";
            this.colCategoria1.Name = "colCategoria1";
            this.colCategoria1.Visible = true;
            this.colCategoria1.VisibleIndex = 2;
            // 
            // colPresentacion1
            // 
            this.colPresentacion1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPresentacion1.AppearanceCell.Options.UseFont = true;
            this.colPresentacion1.AppearanceCell.Options.UseTextOptions = true;
            this.colPresentacion1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPresentacion1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPresentacion1.AppearanceHeader.Options.UseFont = true;
            this.colPresentacion1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPresentacion1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPresentacion1.Caption = "Presentacion";
            this.colPresentacion1.FieldName = "IdArticulo.IdPresentacion.Nombre";
            this.colPresentacion1.Name = "colPresentacion1";
            this.colPresentacion1.Visible = true;
            this.colPresentacion1.VisibleIndex = 3;
            // 
            // colprecioVenta
            // 
            this.colprecioVenta.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colprecioVenta.AppearanceCell.Options.UseFont = true;
            this.colprecioVenta.AppearanceCell.Options.UseTextOptions = true;
            this.colprecioVenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprecioVenta.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colprecioVenta.AppearanceHeader.Options.UseFont = true;
            this.colprecioVenta.AppearanceHeader.Options.UseTextOptions = true;
            this.colprecioVenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprecioVenta.Caption = "Precio Unitario";
            this.colprecioVenta.DisplayFormat.FormatString = "C$ {0:n2}";
            this.colprecioVenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecioVenta.FieldName = "Precio_Venta";
            this.colprecioVenta.Name = "colprecioVenta";
            this.colprecioVenta.Visible = true;
            this.colprecioVenta.VisibleIndex = 4;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCantidad.AppearanceCell.Options.UseFont = true;
            this.colCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCantidad.AppearanceHeader.Options.UseFont = true;
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.Caption = "Cantidad Solicitada";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 5;
            // 
            // colDescuento
            // 
            this.colDescuento.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescuento.AppearanceCell.Options.UseFont = true;
            this.colDescuento.AppearanceCell.Options.UseTextOptions = true;
            this.colDescuento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescuento.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescuento.AppearanceHeader.Options.UseFont = true;
            this.colDescuento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescuento.Caption = "Descuento";
            this.colDescuento.DisplayFormat.FormatString = "{0} %";
            this.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 6;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotal.AppearanceCell.Options.UseFont = true;
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotal.AppearanceHeader.Options.UseFont = true;
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "C$ {0:n2}";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "Total a Pagar= C$ {0:n2}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.layoutControl5);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 84);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // layoutControl5
            // 
            this.layoutControl5.Controls.Add(this.txtDescuento);
            this.layoutControl5.Controls.Add(this.txtCantidad);
            this.layoutControl5.Controls.Add(this.txtPrescioTotal);
            this.layoutControl5.Controls.Add(this.sbArticulo);
            this.layoutControl5.Controls.Add(this.txtIdDetalle);
            this.layoutControl5.Controls.Add(this.txtstockActual);
            this.layoutControl5.Controls.Add(this.btnQuitar);
            this.layoutControl5.Controls.Add(this.btnAgregar1);
            this.layoutControl5.Controls.Add(this.txtIdDetalleVenta);
            this.layoutControl5.Controls.Add(this.txtPrecioVenta);
            this.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl5.Location = new System.Drawing.Point(3, 16);
            this.layoutControl5.Name = "layoutControl5";
            this.layoutControl5.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 21, 650, 400);
            this.layoutControl5.Root = this.layoutControlGroup4;
            this.layoutControl5.Size = new System.Drawing.Size(837, 65);
            this.layoutControl5.TabIndex = 0;
            this.layoutControl5.Text = "layoutControl5";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(684, 62);
            this.txtDescuento.Mask = "9999999999";
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(104, 22);
            this.txtDescuento.TabIndex = 17;
            this.txtDescuento.ValidatingType = typeof(int);
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(486, 62);
            this.txtCantidad.Mask = "9999999999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(105, 22);
            this.txtCantidad.TabIndex = 16;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCantidad_MaskInputRejected);
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtPrescioTotal
            // 
            this.txtPrescioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrescioTotal.Location = new System.Drawing.Point(98, 88);
            this.txtPrescioTotal.Name = "txtPrescioTotal";
            this.txtPrescioTotal.ReadOnly = true;
            this.txtPrescioTotal.Size = new System.Drawing.Size(90, 20);
            this.txtPrescioTotal.TabIndex = 15;
            this.txtPrescioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sbArticulo
            // 
            this.sbArticulo.EditValue = "";
            this.sbArticulo.Location = new System.Drawing.Point(73, 36);
            this.sbArticulo.Name = "sbArticulo";
            this.sbArticulo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbArticulo.Properties.Appearance.Options.UseFont = true;
            this.sbArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbArticulo.Properties.DataSource = this.xpCollectionArticulo;
            this.sbArticulo.Properties.DisplayMember = "Nombre";
            this.sbArticulo.Properties.PopupView = this.gridviewArticulo;
            this.sbArticulo.Properties.ValueMember = "IdArticulos";
            this.sbArticulo.Size = new System.Drawing.Size(715, 22);
            this.sbArticulo.StyleController = this.layoutControl5;
            this.sbArticulo.TabIndex = 14;
            this.sbArticulo.EditValueChanged += new System.EventHandler(this.sbArticulo_EditValueChanged);
            // 
            // xpCollectionArticulo
            // 
            this.xpCollectionArticulo.ObjectType = typeof(SisVentaDevExpress.Ventas.Articulo);
            this.xpCollectionArticulo.Session = this.unitOfWorkVentas;
            // 
            // gridviewArticulo
            // 
            this.gridviewArticulo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoArticulo,
            this.colArticulo,
            this.colCategoria,
            this.colPresentacion,
            this.colPrecioUnitario,
            this.colExistecia});
            this.gridviewArticulo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridviewArticulo.GroupCount = 2;
            this.gridviewArticulo.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdArticulo.Nombre", null, "({0})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridviewArticulo.Name = "gridviewArticulo";
            this.gridviewArticulo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridviewArticulo.OptionsView.ShowGroupPanel = false;
            this.gridviewArticulo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoria, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPresentacion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCodigoArticulo
            // 
            this.colCodigoArticulo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigoArticulo.AppearanceCell.Options.UseFont = true;
            this.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigoArticulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigoArticulo.AppearanceHeader.Options.UseFont = true;
            this.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigoArticulo.Caption = "Codigo Articulo";
            this.colCodigoArticulo.FieldName = "Codigo";
            this.colCodigoArticulo.Name = "colCodigoArticulo";
            this.colCodigoArticulo.Visible = true;
            this.colCodigoArticulo.VisibleIndex = 0;
            this.colCodigoArticulo.Width = 68;
            // 
            // colArticulo
            // 
            this.colArticulo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colArticulo.AppearanceCell.Options.UseFont = true;
            this.colArticulo.AppearanceCell.Options.UseTextOptions = true;
            this.colArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArticulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colArticulo.AppearanceHeader.Options.UseFont = true;
            this.colArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.colArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArticulo.Caption = "Articulo";
            this.colArticulo.FieldName = "Nombre";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 1;
            this.colArticulo.Width = 68;
            // 
            // colCategoria
            // 
            this.colCategoria.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria.AppearanceCell.Options.UseFont = true;
            this.colCategoria.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoria.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria.AppearanceHeader.Options.UseFont = true;
            this.colCategoria.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoria.Caption = "Categoria";
            this.colCategoria.FieldName = "IdCategoria.Nombre";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 2;
            this.colCategoria.Width = 68;
            // 
            // colPresentacion
            // 
            this.colPresentacion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPresentacion.AppearanceCell.Options.UseFont = true;
            this.colPresentacion.AppearanceCell.Options.UseTextOptions = true;
            this.colPresentacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPresentacion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPresentacion.AppearanceHeader.Options.UseFont = true;
            this.colPresentacion.AppearanceHeader.Options.UseTextOptions = true;
            this.colPresentacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPresentacion.Caption = "Presentacion";
            this.colPresentacion.FieldName = "IdPresentacion.Nombre";
            this.colPresentacion.Name = "colPresentacion";
            this.colPresentacion.Visible = true;
            this.colPresentacion.VisibleIndex = 4;
            this.colPresentacion.Width = 68;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrecioUnitario.AppearanceCell.Options.UseFont = true;
            this.colPrecioUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecioUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecioUnitario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrecioUnitario.AppearanceHeader.Options.UseFont = true;
            this.colPrecioUnitario.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecioUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecioUnitario.Caption = "Precio Unitario";
            this.colPrecioUnitario.DisplayFormat.FormatString = "C$  {0}";
            this.colPrecioUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioUnitario.FieldName = "PrecioVenta";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 2;
            this.colPrecioUnitario.Width = 68;
            // 
            // colExistecia
            // 
            this.colExistecia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colExistecia.AppearanceCell.Options.UseFont = true;
            this.colExistecia.AppearanceCell.Options.UseTextOptions = true;
            this.colExistecia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExistecia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colExistecia.AppearanceHeader.Options.UseFont = true;
            this.colExistecia.AppearanceHeader.Options.UseTextOptions = true;
            this.colExistecia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExistecia.Caption = "Existencia";
            this.colExistecia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistecia.FieldName = "Existencia";
            this.colExistecia.Name = "colExistecia";
            this.colExistecia.Visible = true;
            this.colExistecia.VisibleIndex = 3;
            this.colExistecia.Width = 59;
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalle.Location = new System.Drawing.Point(355, 12);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(470, 20);
            this.txtIdDetalle.TabIndex = 13;
            this.txtIdDetalle.Visible = false;
            // 
            // txtstockActual
            // 
            this.txtstockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockActual.Location = new System.Drawing.Point(287, 62);
            this.txtstockActual.Name = "txtstockActual";
            this.txtstockActual.ReadOnly = true;
            this.txtstockActual.Size = new System.Drawing.Size(52, 20);
            this.txtstockActual.TabIndex = 12;
            this.txtstockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuitar
            // 
            this.btnQuitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.ImageOptions.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(802, 62);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(23, 22);
            this.btnQuitar.StyleController = this.layoutControl5;
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar1.ImageOptions.Image")));
            this.btnAgregar1.Location = new System.Drawing.Point(802, 36);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar1.StyleController = this.layoutControl5;
            this.btnAgregar1.TabIndex = 8;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // txtIdDetalleVenta
            // 
            this.txtIdDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalleVenta.Location = new System.Drawing.Point(125, 12);
            this.txtIdDetalleVenta.Name = "txtIdDetalleVenta";
            this.txtIdDetalleVenta.Size = new System.Drawing.Size(226, 20);
            this.txtIdDetalleVenta.TabIndex = 4;
            this.txtIdDetalleVenta.Visible = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(116, 62);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(69, 20);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblDetalleIngreso,
            this.layoutControlItem18,
            this.layoutControlItem21,
            this.lblArticulo,
            this.emptySpaceItem11,
            this.emptySpaceItem13,
            this.lblPrecioVenta,
            this.emptySpaceItem4,
            this.lblExistencia,
            this.lblPrecioTotal,
            this.emptySpaceItem14,
            this.emptySpaceItem15,
            this.layoutControlItem19,
            this.emptySpaceItem9,
            this.lblcantidadSolisitada,
            this.lblDescuento1});
            this.layoutControlGroup4.Name = "Root";
            this.layoutControlGroup4.Size = new System.Drawing.Size(837, 130);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // lblDetalleIngreso
            // 
            this.lblDetalleIngreso.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleIngreso.AppearanceItemCaption.Options.UseFont = true;
            this.lblDetalleIngreso.Control = this.txtIdDetalleVenta;
            this.lblDetalleIngreso.Location = new System.Drawing.Point(0, 0);
            this.lblDetalleIngreso.Name = "lblDetalleIngreso";
            this.lblDetalleIngreso.Size = new System.Drawing.Size(343, 24);
            this.lblDetalleIngreso.Text = "Id Detalle Venta:";
            this.lblDetalleIngreso.TextSize = new System.Drawing.Size(110, 16);
            this.lblDetalleIngreso.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.btnAgregar1;
            this.layoutControlItem18.Location = new System.Drawing.Point(790, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(27, 26);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.txtIdDetalle;
            this.layoutControlItem21.Location = new System.Drawing.Point(343, 0);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(474, 24);
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            this.layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.AppearanceItemCaption.Options.UseFont = true;
            this.lblArticulo.Control = this.sbArticulo;
            this.lblArticulo.Location = new System.Drawing.Point(0, 24);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(780, 26);
            this.lblArticulo.Text = "Articulo:";
            this.lblArticulo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblArticulo.TextSize = new System.Drawing.Size(56, 16);
            this.lblArticulo.TextToControlDistance = 5;
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(0, 100);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(817, 10);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(180, 76);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(637, 24);
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.AppearanceItemCaption.Options.UseFont = true;
            this.lblPrecioVenta.Control = this.txtPrecioVenta;
            this.lblPrecioVenta.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrecioVenta.CustomizationFormText = "Id Detalle Ingresos:";
            this.lblPrecioVenta.Location = new System.Drawing.Point(0, 50);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(177, 26);
            this.lblPrecioVenta.Text = "Precio Unitario:";
            this.lblPrecioVenta.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblPrecioVenta.TextSize = new System.Drawing.Size(99, 16);
            this.lblPrecioVenta.TextToControlDistance = 5;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(331, 50);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblExistencia
            // 
            this.lblExistencia.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.AppearanceItemCaption.Options.UseFont = true;
            this.lblExistencia.Control = this.txtstockActual;
            this.lblExistencia.Location = new System.Drawing.Point(201, 50);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(130, 26);
            this.lblExistencia.Text = "Existencia:";
            this.lblExistencia.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblExistencia.TextSize = new System.Drawing.Size(69, 16);
            this.lblExistencia.TextToControlDistance = 5;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.AppearanceItemCaption.Options.UseFont = true;
            this.lblPrecioTotal.Control = this.txtPrescioTotal;
            this.lblPrecioTotal.Location = new System.Drawing.Point(0, 76);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(180, 24);
            this.lblPrecioTotal.Text = "Precio Total:";
            this.lblPrecioTotal.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblPrecioTotal.TextSize = new System.Drawing.Size(81, 16);
            this.lblPrecioTotal.TextToControlDistance = 5;
            // 
            // emptySpaceItem14
            // 
            this.emptySpaceItem14.AllowHotTrack = false;
            this.emptySpaceItem14.Location = new System.Drawing.Point(583, 50);
            this.emptySpaceItem14.Name = "emptySpaceItem14";
            this.emptySpaceItem14.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem15
            // 
            this.emptySpaceItem15.AllowHotTrack = false;
            this.emptySpaceItem15.Location = new System.Drawing.Point(177, 50);
            this.emptySpaceItem15.Name = "emptySpaceItem15";
            this.emptySpaceItem15.Size = new System.Drawing.Size(24, 26);
            this.emptySpaceItem15.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.btnQuitar;
            this.layoutControlItem19.Location = new System.Drawing.Point(790, 50);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(27, 26);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(780, 24);
            this.emptySpaceItem9.MaxSize = new System.Drawing.Size(10, 52);
            this.emptySpaceItem9.MinSize = new System.Drawing.Size(10, 52);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(10, 52);
            this.emptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblcantidadSolisitada
            // 
            this.lblcantidadSolisitada.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadSolisitada.AppearanceItemCaption.Options.UseFont = true;
            this.lblcantidadSolisitada.Control = this.txtCantidad;
            this.lblcantidadSolisitada.Location = new System.Drawing.Point(341, 50);
            this.lblcantidadSolisitada.Name = "lblcantidadSolisitada";
            this.lblcantidadSolisitada.Size = new System.Drawing.Size(242, 26);
            this.lblcantidadSolisitada.Text = "Cantidad Solicitada:";
            this.lblcantidadSolisitada.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblcantidadSolisitada.TextSize = new System.Drawing.Size(128, 16);
            this.lblcantidadSolisitada.TextToControlDistance = 5;
            // 
            // lblDescuento1
            // 
            this.lblDescuento1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento1.AppearanceItemCaption.Options.UseFont = true;
            this.lblDescuento1.Control = this.txtDescuento;
            this.lblDescuento1.Location = new System.Drawing.Point(593, 50);
            this.lblDescuento1.Name = "lblDescuento1";
            this.lblDescuento1.Size = new System.Drawing.Size(187, 26);
            this.lblDescuento1.Text = "Descuento:";
            this.lblDescuento1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblDescuento1.TextSize = new System.Drawing.Size(74, 16);
            this.lblDescuento1.TextToControlDistance = 5;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativo.Location = new System.Drawing.Point(517, 64);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(338, 20);
            this.txtCorrelativo.TabIndex = 23;
            // 
            // cbComprobante
            // 
            this.cbComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComprobante.FormattingEnabled = true;
            this.cbComprobante.Items.AddRange(new object[] {
            "PREFORMA",
            "ORDEN DE COMPRA",
            "FACTURA"});
            this.cbComprobante.Location = new System.Drawing.Point(120, 64);
            this.cbComprobante.Name = "cbComprobante";
            this.cbComprobante.Size = new System.Drawing.Size(164, 24);
            this.cbComprobante.TabIndex = 20;
            this.cbComprobante.Text = "FACTURA";
            // 
            // dtFechaventa
            // 
            this.dtFechaventa.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaventa.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtFechaventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaventa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaventa.Location = new System.Drawing.Point(515, 38);
            this.dtFechaventa.Name = "dtFechaventa";
            this.dtFechaventa.Size = new System.Drawing.Size(92, 20);
            this.dtFechaventa.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(275, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 36);
            this.btnCancelar.StyleController = this.layoutControl4;
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Appearance.Options.UseFont = true;
            this.btnGuardarCambios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.ImageOptions.Image")));
            this.btnGuardarCambios.Location = new System.Drawing.Point(116, 344);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(155, 36);
            this.btnGuardarCambios.StyleController = this.layoutControl4;
            this.btnGuardarCambios.TabIndex = 14;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(12, 344);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 36);
            this.btnGuardar.StyleController = this.layoutControl4;
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSerie.Location = new System.Drawing.Point(331, 64);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 21);
            this.txtSerie.TabIndex = 11;
            // 
            // txtidVenta
            // 
            this.txtidVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtidVenta.Location = new System.Drawing.Point(733, 12);
            this.txtidVenta.Name = "txtidVenta";
            this.txtidVenta.Size = new System.Drawing.Size(122, 22);
            this.txtidVenta.TabIndex = 4;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem12,
            this.layoutControlItem3,
            this.layoutControlItem15,
            this.lblCorrelativo,
            this.lblTrabajador,
            this.lblComprobante,
            this.lblCliente,
            this.emptySpaceItem5,
            this.lblSerie,
            this.lblIGV,
            this.emptySpaceItem7,
            this.lblidTrabajador,
            this.layoutControlItem12,
            this.emptySpaceItem6,
            this.emptySpaceItem10,
            this.lblFechaVenta});
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(867, 392);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnGuardar;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 332);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(104, 40);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(104, 40);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnGuardarCambios;
            this.layoutControlItem11.Location = new System.Drawing.Point(104, 332);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(159, 40);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(159, 40);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(159, 40);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(376, 26);
            this.emptySpaceItem12.MaxSize = new System.Drawing.Size(19, 0);
            this.emptySpaceItem12.MinSize = new System.Drawing.Size(19, 10);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(19, 26);
            this.emptySpaceItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupBox2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 77);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(847, 88);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.gridControlDetalleVenta;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 165);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(847, 167);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.AppearanceItemCaption.Options.UseFont = true;
            this.lblCorrelativo.Control = this.txtCorrelativo;
            this.lblCorrelativo.Location = new System.Drawing.Point(423, 52);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(424, 25);
            this.lblCorrelativo.Text = "Correlativo:";
            this.lblCorrelativo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblCorrelativo.TextSize = new System.Drawing.Size(77, 16);
            this.lblCorrelativo.TextToControlDistance = 5;
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajador.AppearanceItemCaption.Options.UseFont = true;
            this.lblTrabajador.Control = this.sbTrabajador;
            this.lblTrabajador.Location = new System.Drawing.Point(0, 0);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(297, 26);
            this.lblTrabajador.Text = "Vendedor:";
            this.lblTrabajador.TextSize = new System.Drawing.Size(105, 16);
            // 
            // lblComprobante
            // 
            this.lblComprobante.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobante.AppearanceItemCaption.Options.UseFont = true;
            this.lblComprobante.Control = this.cbComprobante;
            this.lblComprobante.Location = new System.Drawing.Point(0, 52);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(276, 25);
            this.lblComprobante.Text = "Comprobante:";
            this.lblComprobante.TextSize = new System.Drawing.Size(105, 16);
            // 
            // lblCliente
            // 
            this.lblCliente.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.AppearanceItemCaption.Options.UseFont = true;
            this.lblCliente.Control = this.sbCliente;
            this.lblCliente.Location = new System.Drawing.Point(0, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(376, 26);
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.TextSize = new System.Drawing.Size(105, 16);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(837, 26);
            this.emptySpaceItem5.Name = "emptySpaceItem3";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblSerie
            // 
            this.lblSerie.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSerie.AppearanceItemCaption.Options.UseFont = true;
            this.lblSerie.Control = this.txtSerie;
            this.lblSerie.Location = new System.Drawing.Point(276, 52);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(147, 25);
            this.lblSerie.Text = "Serie:";
            this.lblSerie.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblSerie.TextSize = new System.Drawing.Size(38, 16);
            this.lblSerie.TextToControlDistance = 5;
            // 
            // lblIGV
            // 
            this.lblIGV.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.AppearanceItemCaption.Options.UseFont = true;
            this.lblIGV.Control = this.txtIGV;
            this.lblIGV.Location = new System.Drawing.Point(620, 26);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(217, 26);
            this.lblIGV.Text = "Impuesto:";
            this.lblIGV.TextSize = new System.Drawing.Size(105, 16);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(599, 26);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(21, 0);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(21, 10);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(21, 26);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblidTrabajador
            // 
            this.lblidTrabajador.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblidTrabajador.AppearanceItemCaption.Options.UseFont = true;
            this.lblidTrabajador.Control = this.txtidVenta;
            this.lblidTrabajador.Location = new System.Drawing.Point(613, 0);
            this.lblidTrabajador.MaxSize = new System.Drawing.Size(234, 26);
            this.lblidTrabajador.MinSize = new System.Drawing.Size(234, 26);
            this.lblidTrabajador.Name = "lblidTrabajador";
            this.lblidTrabajador.Size = new System.Drawing.Size(234, 26);
            this.lblidTrabajador.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lblidTrabajador.Text = "Id Venta:";
            this.lblidTrabajador.TextSize = new System.Drawing.Size(105, 16);
            this.lblidTrabajador.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnCancelar;
            this.layoutControlItem12.Location = new System.Drawing.Point(263, 332);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(106, 40);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(106, 40);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(106, 40);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(369, 332);
            this.emptySpaceItem6.Name = "emptySpaceItem5";
            this.emptySpaceItem6.Size = new System.Drawing.Size(478, 40);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(297, 0);
            this.emptySpaceItem10.MaxSize = new System.Drawing.Size(316, 26);
            this.emptySpaceItem10.MinSize = new System.Drawing.Size(316, 26);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(316, 26);
            this.emptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.AppearanceItemCaption.Options.UseFont = true;
            this.lblFechaVenta.Control = this.dtFechaventa;
            this.lblFechaVenta.Location = new System.Drawing.Point(395, 26);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(204, 26);
            this.lblFechaVenta.Text = "Fecha de Venta:";
            this.lblFechaVenta.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(897, 435);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.groupBox1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(877, 415);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 59);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloIngresos
            // 
            this.lblTituloIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloIngresos.ForeColor = System.Drawing.Color.Blue;
            this.lblTituloIngresos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTituloIngresos.Location = new System.Drawing.Point(12, 12);
            this.lblTituloIngresos.Name = "lblTituloIngresos";
            this.lblTituloIngresos.Size = new System.Drawing.Size(128, 59);
            this.lblTituloIngresos.TabIndex = 1;
            this.lblTituloIngresos.Text = "Ventas";
            this.lblTituloIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem14});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(935, 554);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(236, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(679, 63);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblTituloIngresos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(132, 63);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(132, 63);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(132, 63);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pictureBox1;
            this.layoutControlItem2.Location = new System.Drawing.Point(132, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(104, 63);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 63);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 63);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.tabControl1;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 63);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(915, 471);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(SisVentaDevExpress.Ventas.Venta);
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 554);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_Venta";
            this.Text = "Mantenimiento de Ventas";
            this.Load += new System.EventHandler(this.frm_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbTrabajador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).EndInit();
            this.layoutControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetalleIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcantidadSolisitada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescuento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCorrelativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblidTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkDetalleIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.Label lblTituloIngresos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton btnComprobante;
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private System.Windows.Forms.MaskedTextBox txtIGV;
        private DevExpress.XtraEditors.SearchLookUpEdit sbTrabajador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn NonbreCompleto;
        private DevExpress.XtraEditors.SearchLookUpEdit sbCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView Cliente;
        private DevExpress.XtraGrid.GridControl gridControlDetalleVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView dataListadoDetalle;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraLayout.LayoutControl layoutControl5;
        private DevExpress.XtraEditors.SimpleButton btnQuitar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar1;
        private System.Windows.Forms.TextBox txtIdDetalleVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem lblDetalleIngreso;
        private DevExpress.XtraLayout.LayoutControlItem lblPrecioVenta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.ComboBox cbComprobante;
        private System.Windows.Forms.DateTimePicker dtFechaventa;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCambios;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.MaskedTextBox txtSerie;
        private System.Windows.Forms.TextBox txtidVenta;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem lblCorrelativo;
        private DevExpress.XtraLayout.LayoutControlItem lblTrabajador;
        private DevExpress.XtraLayout.LayoutControlItem lblComprobante;
        private DevExpress.XtraLayout.LayoutControlItem lblCliente;
        private DevExpress.XtraLayout.LayoutControlItem lblFechaVenta;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem lblSerie;
        private DevExpress.XtraLayout.LayoutControlItem lblIGV;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlItem lblidTrabajador;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.TextBox txtstockActual;
        private DevExpress.XtraLayout.LayoutControlItem lblExistencia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.Xpo.XPCollection xpCollectionTrabajador;
        private DevExpress.Xpo.UnitOfWork unitOfWorkVentas;
        private DevExpress.Xpo.XPCollection xpCollectionCliente;
        private DevExpress.Xpo.XPCollection xpCollectionVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraEditors.SearchLookUpEdit sbArticulo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewArticulo;
        private DevExpress.XtraLayout.LayoutControlItem lblArticulo;
        private DevExpress.Xpo.XPCollection xpCollectionArticulo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
        private System.Windows.Forms.TextBox txtPrescioTotal;
        private DevExpress.XtraLayout.LayoutControlItem lblPrecioTotal;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colExistecia;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.MaskedTextBox txtDescuento;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private DevExpress.XtraLayout.LayoutControlItem lblcantidadSolisitada;
        private DevExpress.XtraLayout.LayoutControlItem lblDescuento1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCliente;
        private DevExpress.Xpo.XPCollection xpCollectionDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colArtuculoDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.Xpo.UnitOfWork unitOfWorkDetalleIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria1;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente2;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoComprovante;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colConsecutivo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
    }
}