
namespace SisVentaDevExpress.Formularios
{
    partial class frm_Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ingresos));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAnular1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnular = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionIngreso = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWorkIngreso = new DevExpress.Xpo.UnitOfWork(this.components);
            this.dataListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo_Comprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorrelativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.txtIGV = new System.Windows.Forms.MaskedTextBox();
            this.sbTrabajador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionTrabajador = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NonbreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionProveedor = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalP = new System.Windows.Forms.Label();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.gridControlDetalleIngreso = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionDetalleIngreso = new DevExpress.Xpo.XPCollection(this.components);
            this.dataListadoDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtFechaProducion = new System.Windows.Forms.DateTimePicker();
            this.sbArticulo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionArticulos = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIdDetalleIngreso = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblDetalleIngreso = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblArticulos = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblPrecioCompra = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblStockInicial = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblPrecioVenta = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblFechaProd = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblFechaVencimiento = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.cbComprobante = new System.Windows.Forms.ComboBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarCambios = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSerie = new System.Windows.Forms.MaskedTextBox();
            this.txtidIngresos = new System.Windows.Forms.TextBox();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCorrelativo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTrabajador = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblComprobante = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblProveedor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblFechaIngreso = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblSerie = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblIGV = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblidTrabajador = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloIngresos = new System.Windows.Forms.Label();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkIngreso)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbTrabajador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionDetalleIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).BeginInit();
            this.layoutControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetalleIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFechaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCorrelativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblidTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
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
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(935, 554);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 477);
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
            this.tabPage1.Size = new System.Drawing.Size(903, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnAnular1);
            this.layoutControl2.Controls.Add(this.lblTotal);
            this.layoutControl2.Controls.Add(this.btnAnular);
            this.layoutControl2.Controls.Add(this.btnImprimir1);
            this.layoutControl2.Controls.Add(this.btnEditar1);
            this.layoutControl2.Controls.Add(this.btnAgregar);
            this.layoutControl2.Controls.Add(this.gridControl2);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(897, 445);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnAnular1
            // 
            this.btnAnular1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular1.Appearance.Options.UseFont = true;
            this.btnAnular1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular1.ImageOptions.Image")));
            this.btnAnular1.Location = new System.Drawing.Point(308, 12);
            this.btnAnular1.Name = "btnAnular1";
            this.btnAnular1.Size = new System.Drawing.Size(94, 36);
            this.btnAnular1.StyleController = this.layoutControl2;
            this.btnAnular1.TabIndex = 4;
            this.btnAnular1.Text = "Anular";
            this.btnAnular1.Click += new System.EventHandler(this.btnAnular1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(12, 413);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(243, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            // 
            // btnAnular
            // 
            this.btnAnular.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnular.Appearance.Options.UseFont = true;
            this.btnAnular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.ImageOptions.Image")));
            this.btnAnular.Location = new System.Drawing.Point(406, 12);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(97, 36);
            this.btnAnular.StyleController = this.layoutControl2;
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Text = "Eliminar";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimir1.Appearance.Options.UseFont = true;
            this.btnImprimir1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir1.ImageOptions.Image")));
            this.btnImprimir1.Location = new System.Drawing.Point(206, 12);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(98, 36);
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
            this.gridControl2.DataSource = this.xpCollectionIngreso;
            this.gridControl2.Location = new System.Drawing.Point(12, 76);
            this.gridControl2.MainView = this.dataListado;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(873, 333);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataListado});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            this.gridControl2.DoubleClick += new System.EventHandler(this.btnEditar1_Click);
            // 
            // xpCollectionIngreso
            // 
            this.xpCollectionIngreso.ObjectType = typeof(SisVentaDevExpress.Ventas.Ingreso);
            this.xpCollectionIngreso.Session = this.unitOfWorkIngreso;
            // 
            // dataListado
            // 
            this.dataListado.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dataListado.Appearance.GroupRow.Options.UseFont = true;
            this.dataListado.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dataListado.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dataListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrabajador,
            this.colProveedor,
            this.colFecha_Ingreso,
            this.colTipo_Comprobante,
            this.colSerie,
            this.colCorrelativo,
            this.colIGV,
            this.colEstado});
            this.dataListado.GridControl = this.gridControl2;
            this.dataListado.GroupCount = 1;
            this.dataListado.Name = "dataListado";
            this.dataListado.OptionsBehavior.Editable = false;
            this.dataListado.OptionsFind.AlwaysVisible = true;
            this.dataListado.OptionsSelection.MultiSelect = true;
            this.dataListado.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEstado, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTrabajador
            // 
            this.colTrabajador.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTrabajador.AppearanceCell.Options.UseFont = true;
            this.colTrabajador.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTrabajador.AppearanceHeader.Options.UseFont = true;
            this.colTrabajador.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrabajador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrabajador.Caption = "Trabajador";
            this.colTrabajador.FieldName = "IdTrabajador.NombreCompleto";
            this.colTrabajador.Name = "colTrabajador";
            this.colTrabajador.Visible = true;
            this.colTrabajador.VisibleIndex = 0;
            // 
            // colProveedor
            // 
            this.colProveedor.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProveedor.AppearanceCell.Options.UseFont = true;
            this.colProveedor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProveedor.AppearanceHeader.Options.UseFont = true;
            this.colProveedor.AppearanceHeader.Options.UseTextOptions = true;
            this.colProveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.FieldName = "IdProveedor.Razon_Social";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 1;
            // 
            // colFecha_Ingreso
            // 
            this.colFecha_Ingreso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Ingreso.AppearanceCell.Options.UseFont = true;
            this.colFecha_Ingreso.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Ingreso.AppearanceHeader.Options.UseFont = true;
            this.colFecha_Ingreso.AppearanceHeader.Options.UseTextOptions = true;
            this.colFecha_Ingreso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha_Ingreso.Caption = "Fecha Ingreso";
            this.colFecha_Ingreso.FieldName = "Fecha_Ingreso";
            this.colFecha_Ingreso.Name = "colFecha_Ingreso";
            this.colFecha_Ingreso.Visible = true;
            this.colFecha_Ingreso.VisibleIndex = 2;
            // 
            // colTipo_Comprobante
            // 
            this.colTipo_Comprobante.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipo_Comprobante.AppearanceCell.Options.UseFont = true;
            this.colTipo_Comprobante.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipo_Comprobante.AppearanceHeader.Options.UseFont = true;
            this.colTipo_Comprobante.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipo_Comprobante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipo_Comprobante.Caption = "Tipo Comprobante";
            this.colTipo_Comprobante.FieldName = "Tipo_Comprobante";
            this.colTipo_Comprobante.Name = "colTipo_Comprobante";
            this.colTipo_Comprobante.Visible = true;
            this.colTipo_Comprobante.VisibleIndex = 3;
            // 
            // colSerie
            // 
            this.colSerie.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSerie.AppearanceCell.Options.UseFont = true;
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
            // colCorrelativo
            // 
            this.colCorrelativo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCorrelativo.AppearanceCell.Options.UseFont = true;
            this.colCorrelativo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCorrelativo.AppearanceHeader.Options.UseFont = true;
            this.colCorrelativo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCorrelativo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCorrelativo.Caption = "Correlativo";
            this.colCorrelativo.FieldName = "Correlativo";
            this.colCorrelativo.Name = "colCorrelativo";
            this.colCorrelativo.Visible = true;
            this.colCorrelativo.VisibleIndex = 5;
            // 
            // colIGV
            // 
            this.colIGV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIGV.AppearanceCell.Options.UseFont = true;
            this.colIGV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIGV.AppearanceHeader.Options.UseFont = true;
            this.colIGV.AppearanceHeader.Options.UseTextOptions = true;
            this.colIGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIGV.Caption = "Impuesto";
            this.colIGV.FieldName = "IGV";
            this.colIGV.Name = "colIGV";
            this.colIGV.Visible = true;
            this.colIGV.VisibleIndex = 6;
            // 
            // colEstado
            // 
            this.colEstado.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEstado.AppearanceCell.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEstado.AppearanceHeader.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
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
            this.emptySpaceItem9,
            this.layoutControlItem20});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(897, 445);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(877, 337);
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
            this.layoutControlItem7.Location = new System.Drawing.Point(194, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(102, 40);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(102, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(102, 40);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnAnular;
            this.layoutControlItem8.Location = new System.Drawing.Point(394, 0);
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
            this.emptySpaceItem8.Location = new System.Drawing.Point(247, 401);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(630, 24);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.lblTotal;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 401);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(877, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(495, 0);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(382, 40);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.btnAnular1;
            this.layoutControlItem20.Location = new System.Drawing.Point(296, 0);
            this.layoutControlItem20.MaxSize = new System.Drawing.Size(98, 40);
            this.layoutControlItem20.MinSize = new System.Drawing.Size(98, 40);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(98, 40);
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
            this.tabPage2.Size = new System.Drawing.Size(903, 451);
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
            this.layoutControl3.Size = new System.Drawing.Size(897, 445);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Almacen";
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.txtIGV);
            this.layoutControl4.Controls.Add(this.sbTrabajador);
            this.layoutControl4.Controls.Add(this.sbProveedor);
            this.layoutControl4.Controls.Add(this.lblTotalP);
            this.layoutControl4.Controls.Add(this.lblTotalPagado);
            this.layoutControl4.Controls.Add(this.gridControlDetalleIngreso);
            this.layoutControl4.Controls.Add(this.groupBox2);
            this.layoutControl4.Controls.Add(this.txtCorrelativo);
            this.layoutControl4.Controls.Add(this.cbComprobante);
            this.layoutControl4.Controls.Add(this.dtFechaIngreso);
            this.layoutControl4.Controls.Add(this.btnCancelar);
            this.layoutControl4.Controls.Add(this.btnGuardarCambios);
            this.layoutControl4.Controls.Add(this.btnGuardar);
            this.layoutControl4.Controls.Add(this.txtSerie);
            this.layoutControl4.Controls.Add(this.txtidIngresos);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(3, 16);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 66, 650, 400);
            this.layoutControl4.Root = this.layoutControlGroup3;
            this.layoutControl4.Size = new System.Drawing.Size(867, 402);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // txtIGV
            // 
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(658, 38);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(100, 22);
            this.txtIGV.TabIndex = 30;
            this.txtIGV.ValidatingType = typeof(int);
            // 
            // sbTrabajador
            // 
            this.sbTrabajador.Location = new System.Drawing.Point(111, 12);
            this.sbTrabajador.Name = "sbTrabajador";
            this.sbTrabajador.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTrabajador.Properties.Appearance.Options.UseFont = true;
            this.sbTrabajador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbTrabajador.Properties.DataSource = this.xpCollectionTrabajador;
            this.sbTrabajador.Properties.DisplayMember = "NombreCompleto";
            this.sbTrabajador.Properties.PopupView = this.gridView1;
            this.sbTrabajador.Properties.ValueMember = "IdTrabajador";
            this.sbTrabajador.Size = new System.Drawing.Size(194, 22);
            this.sbTrabajador.StyleController = this.layoutControl4;
            this.sbTrabajador.TabIndex = 29;
            this.sbTrabajador.EditValueChanged += new System.EventHandler(this.sbTrabajador_EditValueChanged);
            // 
            // xpCollectionTrabajador
            // 
            this.xpCollectionTrabajador.ObjectType = typeof(SisVentaDevExpress.Ventas.Trabajador);
            this.xpCollectionTrabajador.Session = this.unitOfWorkIngreso;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NonbreCompleto});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // sbProveedor
            // 
            this.sbProveedor.Location = new System.Drawing.Point(111, 38);
            this.sbProveedor.Name = "sbProveedor";
            this.sbProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbProveedor.Properties.Appearance.Options.UseFont = true;
            this.sbProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbProveedor.Properties.DataSource = this.xpCollectionProveedor;
            this.sbProveedor.Properties.DisplayMember = "Razon_Social";
            this.sbProveedor.Properties.PopupView = this.searchLookUpEdit2View;
            this.sbProveedor.Properties.ValueMember = "IdProveedor";
            this.sbProveedor.Size = new System.Drawing.Size(194, 22);
            this.sbProveedor.StyleController = this.layoutControl4;
            this.sbProveedor.TabIndex = 28;
            this.sbProveedor.EditValueChanged += new System.EventHandler(this.sbProveedor_EditValueChanged);
            // 
            // xpCollectionProveedor
            // 
            this.xpCollectionProveedor.ObjectType = typeof(SisVentaDevExpress.Ventas.Proveedor);
            this.xpCollectionProveedor.Session = this.unitOfWorkIngreso;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Proveedor});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // Proveedor
            // 
            this.Proveedor.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedor.AppearanceCell.Options.UseFont = true;
            this.Proveedor.AppearanceCell.Options.UseTextOptions = true;
            this.Proveedor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedor.AppearanceHeader.Options.UseFont = true;
            this.Proveedor.AppearanceHeader.Options.UseTextOptions = true;
            this.Proveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Proveedor.Caption = "Proveedor";
            this.Proveedor.FieldName = "Razon_Social";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Visible = true;
            this.Proveedor.VisibleIndex = 0;
            // 
            // lblTotalP
            // 
            this.lblTotalP.Location = new System.Drawing.Point(106, 330);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(144, 20);
            this.lblTotalP.TabIndex = 27;
            this.lblTotalP.Text = "0,0";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.Location = new System.Drawing.Point(12, 330);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(90, 20);
            this.lblTotalPagado.TabIndex = 26;
            this.lblTotalPagado.Text = "Total Pagado:";
            // 
            // gridControlDetalleIngreso
            // 
            this.gridControlDetalleIngreso.DataSource = this.xpCollectionDetalleIngreso;
            this.gridControlDetalleIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlDetalleIngreso.Location = new System.Drawing.Point(12, 164);
            this.gridControlDetalleIngreso.MainView = this.dataListadoDetalle;
            this.gridControlDetalleIngreso.Name = "gridControlDetalleIngreso";
            this.gridControlDetalleIngreso.Size = new System.Drawing.Size(843, 162);
            this.gridControlDetalleIngreso.TabIndex = 25;
            this.gridControlDetalleIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataListadoDetalle});
            this.gridControlDetalleIngreso.DoubleClick += new System.EventHandler(this.gridControlDetalleIngreso_DoubleClick);
            // 
            // xpCollectionDetalleIngreso
            // 
            this.xpCollectionDetalleIngreso.ObjectType = typeof(SisVentaDevExpress.Ventas.Detalle_Ingreso);
            this.xpCollectionDetalleIngreso.Session = this.unitOfWorkIngreso;
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colCodigoArticulo,
            this.ColArticulo,
            this.colPrecio_Compra,
            this.colPrecio_Venta,
            this.colStockInicial,
            this.colFecha_Produccion,
            this.colFecha_Vencimiento,
            this.gridColumn3});
            this.dataListadoDetalle.GridControl = this.gridControlDetalleIngreso;
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.OptionsBehavior.Editable = false;
            this.dataListadoDetalle.OptionsView.ShowFooter = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "id Ingreso";
            this.gridColumn2.FieldName = "IdIngreso.IdIngreso";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
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
            this.colCodigoArticulo.Caption = "Cod Articulo";
            this.colCodigoArticulo.FieldName = "IdArticulo.IdArticulos";
            this.colCodigoArticulo.Name = "colCodigoArticulo";
            this.colCodigoArticulo.Visible = true;
            this.colCodigoArticulo.VisibleIndex = 1;
            // 
            // ColArticulo
            // 
            this.ColArticulo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColArticulo.AppearanceCell.Options.UseFont = true;
            this.ColArticulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColArticulo.AppearanceHeader.Options.UseFont = true;
            this.ColArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.ColArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColArticulo.Caption = "Articulo";
            this.ColArticulo.FieldName = "IdArticulo.Nombre";
            this.ColArticulo.Name = "ColArticulo";
            this.ColArticulo.Visible = true;
            this.ColArticulo.VisibleIndex = 2;
            // 
            // colPrecio_Compra
            // 
            this.colPrecio_Compra.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrecio_Compra.AppearanceCell.Options.UseFont = true;
            this.colPrecio_Compra.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecio_Compra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio_Compra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrecio_Compra.AppearanceHeader.Options.UseFont = true;
            this.colPrecio_Compra.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio_Compra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio_Compra.Caption = "Precio Compra";
            this.colPrecio_Compra.FieldName = "Precio_Compra";
            this.colPrecio_Compra.Name = "colPrecio_Compra";
            this.colPrecio_Compra.Visible = true;
            this.colPrecio_Compra.VisibleIndex = 3;
            // 
            // colPrecio_Venta
            // 
            this.colPrecio_Venta.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrecio_Venta.AppearanceCell.Options.UseFont = true;
            this.colPrecio_Venta.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecio_Venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio_Venta.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrecio_Venta.AppearanceHeader.Options.UseFont = true;
            this.colPrecio_Venta.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio_Venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio_Venta.FieldName = "Precio_Venta";
            this.colPrecio_Venta.Name = "colPrecio_Venta";
            this.colPrecio_Venta.Visible = true;
            this.colPrecio_Venta.VisibleIndex = 4;
            // 
            // colStockInicial
            // 
            this.colStockInicial.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStockInicial.AppearanceCell.Options.UseFont = true;
            this.colStockInicial.AppearanceCell.Options.UseTextOptions = true;
            this.colStockInicial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStockInicial.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStockInicial.AppearanceHeader.Options.UseFont = true;
            this.colStockInicial.AppearanceHeader.Options.UseTextOptions = true;
            this.colStockInicial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStockInicial.Caption = "Articulo Ingresado";
            this.colStockInicial.FieldName = "Stock_inicial";
            this.colStockInicial.Name = "colStockInicial";
            this.colStockInicial.Visible = true;
            this.colStockInicial.VisibleIndex = 5;
            // 
            // colFecha_Produccion
            // 
            this.colFecha_Produccion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Produccion.AppearanceCell.Options.UseFont = true;
            this.colFecha_Produccion.AppearanceCell.Options.UseTextOptions = true;
            this.colFecha_Produccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha_Produccion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Produccion.AppearanceHeader.Options.UseFont = true;
            this.colFecha_Produccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colFecha_Produccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha_Produccion.Caption = "Fecha Prod";
            this.colFecha_Produccion.FieldName = "Fecha_Produccion";
            this.colFecha_Produccion.Name = "colFecha_Produccion";
            this.colFecha_Produccion.Visible = true;
            this.colFecha_Produccion.VisibleIndex = 6;
            // 
            // colFecha_Vencimiento
            // 
            this.colFecha_Vencimiento.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Vencimiento.AppearanceCell.Options.UseFont = true;
            this.colFecha_Vencimiento.AppearanceCell.Options.UseTextOptions = true;
            this.colFecha_Vencimiento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha_Vencimiento.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFecha_Vencimiento.AppearanceHeader.Options.UseFont = true;
            this.colFecha_Vencimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.colFecha_Vencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha_Vencimiento.Caption = "Fecha Venc";
            this.colFecha_Vencimiento.FieldName = "Fecha_Vencimiento";
            this.colFecha_Vencimiento.Name = "colFecha_Vencimiento";
            this.colFecha_Vencimiento.Visible = true;
            this.colFecha_Vencimiento.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Sub Total";
            this.gridColumn3.FieldName = "Sub_total";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.layoutControl5);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 71);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // layoutControl5
            // 
            this.layoutControl5.Controls.Add(this.btnQuitar);
            this.layoutControl5.Controls.Add(this.btnAgregar1);
            this.layoutControl5.Controls.Add(this.dtFechaVencimiento);
            this.layoutControl5.Controls.Add(this.dtFechaProducion);
            this.layoutControl5.Controls.Add(this.sbArticulo);
            this.layoutControl5.Controls.Add(this.txtIdDetalleIngreso);
            this.layoutControl5.Controls.Add(this.txtStockInicial);
            this.layoutControl5.Controls.Add(this.txtPrecioCompra);
            this.layoutControl5.Controls.Add(this.txtPrecioVenta);
            this.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl5.Location = new System.Drawing.Point(3, 16);
            this.layoutControl5.Name = "layoutControl5";
            this.layoutControl5.Root = this.layoutControlGroup4;
            this.layoutControl5.Size = new System.Drawing.Size(837, 52);
            this.layoutControl5.TabIndex = 0;
            this.layoutControl5.Text = "layoutControl5";
            // 
            // btnQuitar
            // 
            this.btnQuitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.ImageOptions.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(784, 62);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(24, 22);
            this.btnQuitar.StyleController = this.layoutControl5;
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar1.ImageOptions.Image")));
            this.btnAgregar1.Location = new System.Drawing.Point(784, 36);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(24, 22);
            this.btnAgregar1.StyleController = this.layoutControl5;
            this.btnAgregar1.TabIndex = 8;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(655, 62);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(115, 20);
            this.dtFechaVencimiento.TabIndex = 7;
            // 
            // dtFechaProducion
            // 
            this.dtFechaProducion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaProducion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaProducion.Location = new System.Drawing.Point(653, 36);
            this.dtFechaProducion.Name = "dtFechaProducion";
            this.dtFechaProducion.Size = new System.Drawing.Size(117, 20);
            this.dtFechaProducion.TabIndex = 6;
            // 
            // sbArticulo
            // 
            this.sbArticulo.Location = new System.Drawing.Point(73, 36);
            this.sbArticulo.Name = "sbArticulo";
            this.sbArticulo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbArticulo.Properties.Appearance.Options.UseFont = true;
            this.sbArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbArticulo.Properties.DataSource = this.xpCollectionArticulos;
            this.sbArticulo.Properties.DisplayMember = "Nombre";
            this.sbArticulo.Properties.PopupView = this.searchLookUpEdit1View;
            this.sbArticulo.Properties.ValueMember = "IdArticulos";
            this.sbArticulo.Size = new System.Drawing.Size(127, 22);
            this.sbArticulo.StyleController = this.layoutControl5;
            this.sbArticulo.TabIndex = 5;
            this.sbArticulo.EditValueChanged += new System.EventHandler(this.sbArticulo_EditValueChanged);
            // 
            // xpCollectionArticulos
            // 
            this.xpCollectionArticulos.ObjectType = typeof(SisVentaDevExpress.Ventas.Articulo);
            this.xpCollectionArticulos.Session = this.unitOfWorkIngreso;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn12.AppearanceCell.Options.UseFont = true;
            this.gridColumn12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn12.AppearanceHeader.Options.UseFont = true;
            this.gridColumn12.Caption = "Articulos";
            this.gridColumn12.FieldName = "Nombre";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // txtIdDetalleIngreso
            // 
            this.txtIdDetalleIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalleIngreso.Location = new System.Drawing.Point(143, 12);
            this.txtIdDetalleIngreso.Name = "txtIdDetalleIngreso";
            this.txtIdDetalleIngreso.Size = new System.Drawing.Size(665, 20);
            this.txtIdDetalleIngreso.TabIndex = 4;
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockInicial.Location = new System.Drawing.Point(99, 62);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(101, 20);
            this.txtStockInicial.TabIndex = 4;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(380, 36);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(108, 20);
            this.txtPrecioCompra.TabIndex = 4;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(374, 62);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(114, 20);
            this.txtPrecioVenta.TabIndex = 4;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblDetalleIngreso,
            this.emptySpaceItem11,
            this.lblArticulos,
            this.emptySpaceItem15,
            this.lblPrecioCompra,
            this.lblStockInicial,
            this.emptySpaceItem14,
            this.lblPrecioVenta,
            this.LblFechaProd,
            this.emptySpaceItem4,
            this.emptySpaceItem16,
            this.lblFechaVencimiento,
            this.emptySpaceItem18,
            this.layoutControlItem18,
            this.layoutControlItem19});
            this.layoutControlGroup4.Name = "Root";
            this.layoutControlGroup4.Size = new System.Drawing.Size(820, 96);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // lblDetalleIngreso
            // 
            this.lblDetalleIngreso.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleIngreso.AppearanceItemCaption.Options.UseFont = true;
            this.lblDetalleIngreso.Control = this.txtIdDetalleIngreso;
            this.lblDetalleIngreso.Location = new System.Drawing.Point(0, 0);
            this.lblDetalleIngreso.Name = "lblDetalleIngreso";
            this.lblDetalleIngreso.Size = new System.Drawing.Size(800, 24);
            this.lblDetalleIngreso.Text = "Id Detalle Ingresos:";
            this.lblDetalleIngreso.TextSize = new System.Drawing.Size(128, 16);
            this.lblDetalleIngreso.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(480, 24);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(80, 26);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblArticulos
            // 
            this.lblArticulos.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.AppearanceItemCaption.Options.UseFont = true;
            this.lblArticulos.Control = this.sbArticulo;
            this.lblArticulos.Location = new System.Drawing.Point(0, 24);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(192, 26);
            this.lblArticulos.Text = "Articulo:";
            this.lblArticulos.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblArticulos.TextSize = new System.Drawing.Size(56, 16);
            this.lblArticulos.TextToControlDistance = 5;
            // 
            // emptySpaceItem15
            // 
            this.emptySpaceItem15.AllowHotTrack = false;
            this.emptySpaceItem15.Location = new System.Drawing.Point(192, 24);
            this.emptySpaceItem15.Name = "emptySpaceItem15";
            this.emptySpaceItem15.Size = new System.Drawing.Size(77, 26);
            this.emptySpaceItem15.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.AppearanceItemCaption.Options.UseFont = true;
            this.lblPrecioCompra.Control = this.txtPrecioCompra;
            this.lblPrecioCompra.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrecioCompra.CustomizationFormText = "Id Detalle Ingresos:";
            this.lblPrecioCompra.Location = new System.Drawing.Point(269, 24);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(211, 26);
            this.lblPrecioCompra.Text = "PrecioCompra:";
            this.lblPrecioCompra.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblPrecioCompra.TextSize = new System.Drawing.Size(94, 16);
            this.lblPrecioCompra.TextToControlDistance = 5;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockInicial.AppearanceItemCaption.Options.UseFont = true;
            this.lblStockInicial.Control = this.txtStockInicial;
            this.lblStockInicial.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStockInicial.CustomizationFormText = "Id Detalle Ingresos:";
            this.lblStockInicial.Location = new System.Drawing.Point(0, 50);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(192, 26);
            this.lblStockInicial.Text = "Stock Inicial:";
            this.lblStockInicial.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblStockInicial.TextSize = new System.Drawing.Size(82, 16);
            this.lblStockInicial.TextToControlDistance = 5;
            // 
            // emptySpaceItem14
            // 
            this.emptySpaceItem14.AllowHotTrack = false;
            this.emptySpaceItem14.Location = new System.Drawing.Point(192, 50);
            this.emptySpaceItem14.Name = "emptySpaceItem14";
            this.emptySpaceItem14.Size = new System.Drawing.Size(77, 26);
            this.emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.AppearanceItemCaption.Options.UseFont = true;
            this.lblPrecioVenta.Control = this.txtPrecioVenta;
            this.lblPrecioVenta.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrecioVenta.CustomizationFormText = "Id Detalle Ingresos:";
            this.lblPrecioVenta.Location = new System.Drawing.Point(269, 50);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(211, 26);
            this.lblPrecioVenta.Text = "Precio Venta:";
            this.lblPrecioVenta.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblPrecioVenta.TextSize = new System.Drawing.Size(88, 16);
            this.lblPrecioVenta.TextToControlDistance = 5;
            // 
            // LblFechaProd
            // 
            this.LblFechaProd.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaProd.AppearanceItemCaption.Options.UseFont = true;
            this.LblFechaProd.Control = this.dtFechaProducion;
            this.LblFechaProd.Location = new System.Drawing.Point(560, 24);
            this.LblFechaProd.Name = "LblFechaProd";
            this.LblFechaProd.Size = new System.Drawing.Size(202, 26);
            this.LblFechaProd.Text = "Fecha Prod:";
            this.LblFechaProd.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.LblFechaProd.TextSize = new System.Drawing.Size(76, 16);
            this.LblFechaProd.TextToControlDistance = 5;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(762, 24);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem16
            // 
            this.emptySpaceItem16.AllowHotTrack = false;
            this.emptySpaceItem16.Location = new System.Drawing.Point(480, 50);
            this.emptySpaceItem16.Name = "emptySpaceItem16";
            this.emptySpaceItem16.Size = new System.Drawing.Size(80, 26);
            this.emptySpaceItem16.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.AppearanceItemCaption.Options.UseFont = true;
            this.lblFechaVencimiento.Control = this.dtFechaVencimiento;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(560, 50);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(202, 26);
            this.lblFechaVencimiento.Text = "Fecha Venc:";
            this.lblFechaVencimiento.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblFechaVencimiento.TextSize = new System.Drawing.Size(78, 16);
            this.lblFechaVencimiento.TextToControlDistance = 5;
            // 
            // emptySpaceItem18
            // 
            this.emptySpaceItem18.AllowHotTrack = false;
            this.emptySpaceItem18.Location = new System.Drawing.Point(762, 50);
            this.emptySpaceItem18.Name = "emptySpaceItem18";
            this.emptySpaceItem18.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem18.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.btnAgregar1;
            this.layoutControlItem18.Location = new System.Drawing.Point(772, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.btnQuitar;
            this.layoutControlItem19.Location = new System.Drawing.Point(772, 50);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativo.Location = new System.Drawing.Point(570, 64);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(285, 20);
            this.txtCorrelativo.TabIndex = 23;
            // 
            // cbComprobante
            // 
            this.cbComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComprobante.FormattingEnabled = true;
            this.cbComprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "REMISION"});
            this.cbComprobante.Location = new System.Drawing.Point(111, 64);
            this.cbComprobante.Name = "cbComprobante";
            this.cbComprobante.Size = new System.Drawing.Size(226, 24);
            this.cbComprobante.TabIndex = 20;
            this.cbComprobante.Text = "TICKET";
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngreso.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(427, 38);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(107, 20);
            this.dtFechaIngreso.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(234, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 36);
            this.btnCancelar.StyleController = this.layoutControl4;
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.ImageOptions.Image")));
            this.btnGuardarCambios.Location = new System.Drawing.Point(106, 354);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(124, 36);
            this.btnGuardarCambios.StyleController = this.layoutControl4;
            this.btnGuardarCambios.TabIndex = 14;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(12, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 36);
            this.btnGuardar.StyleController = this.layoutControl4;
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSerie.Location = new System.Drawing.Point(384, 64);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 21);
            this.txtSerie.TabIndex = 11;
            // 
            // txtidIngresos
            // 
            this.txtidIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtidIngresos.Location = new System.Drawing.Point(408, 12);
            this.txtidIngresos.Name = "txtidIngresos";
            this.txtidIngresos.Size = new System.Drawing.Size(447, 20);
            this.txtidIngresos.TabIndex = 4;
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
            this.layoutControlItem16,
            this.emptySpaceItem6,
            this.layoutControlItem17,
            this.lblCorrelativo,
            this.lblTrabajador,
            this.lblComprobante,
            this.lblProveedor,
            this.lblFechaIngreso,
            this.emptySpaceItem3,
            this.lblSerie,
            this.lblIGV,
            this.emptySpaceItem7,
            this.lblidTrabajador,
            this.layoutControlItem12,
            this.emptySpaceItem5});
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(867, 402);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnGuardar;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 342);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(94, 40);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(94, 40);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(94, 40);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnGuardarCambios;
            this.layoutControlItem11.Location = new System.Drawing.Point(94, 342);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(128, 40);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(128, 40);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(128, 40);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(297, 26);
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
            this.layoutControlItem3.Size = new System.Drawing.Size(847, 75);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.gridControlDetalleIngreso;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 152);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(847, 166);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.lblTotalPagado;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 318);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(94, 24);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(94, 24);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(94, 24);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(242, 318);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(605, 24);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.lblTotalP;
            this.layoutControlItem17.Location = new System.Drawing.Point(94, 318);
            this.layoutControlItem17.MaxSize = new System.Drawing.Size(148, 24);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(148, 24);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(148, 24);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.AppearanceItemCaption.Options.UseFont = true;
            this.lblCorrelativo.Control = this.txtCorrelativo;
            this.lblCorrelativo.Location = new System.Drawing.Point(476, 52);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(371, 25);
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
            this.lblTrabajador.MaxSize = new System.Drawing.Size(297, 26);
            this.lblTrabajador.MinSize = new System.Drawing.Size(297, 26);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(297, 26);
            this.lblTrabajador.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lblTrabajador.Text = "Trabajador";
            this.lblTrabajador.TextSize = new System.Drawing.Size(96, 16);
            // 
            // lblComprobante
            // 
            this.lblComprobante.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobante.AppearanceItemCaption.Options.UseFont = true;
            this.lblComprobante.Control = this.cbComprobante;
            this.lblComprobante.Location = new System.Drawing.Point(0, 52);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(329, 25);
            this.lblComprobante.Text = "Comprobante:";
            this.lblComprobante.TextSize = new System.Drawing.Size(96, 16);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.AppearanceItemCaption.Options.UseFont = true;
            this.lblProveedor.Control = this.sbProveedor;
            this.lblProveedor.Location = new System.Drawing.Point(0, 26);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(297, 26);
            this.lblProveedor.Text = "Proveedor:";
            this.lblProveedor.TextSize = new System.Drawing.Size(96, 16);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.AppearanceItemCaption.Options.UseFont = true;
            this.lblFechaIngreso.Control = this.dtFechaIngreso;
            this.lblFechaIngreso.Location = new System.Drawing.Point(316, 26);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(210, 26);
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            this.lblFechaIngreso.TextSize = new System.Drawing.Size(96, 16);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(750, 26);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(97, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblSerie
            // 
            this.lblSerie.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSerie.AppearanceItemCaption.Options.UseFont = true;
            this.lblSerie.Control = this.txtSerie;
            this.lblSerie.Location = new System.Drawing.Point(329, 52);
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
            this.lblIGV.Location = new System.Drawing.Point(547, 26);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(203, 26);
            this.lblIGV.Text = "Impuesto:";
            this.lblIGV.TextSize = new System.Drawing.Size(96, 16);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(526, 26);
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
            this.lblidTrabajador.Control = this.txtidIngresos;
            this.lblidTrabajador.Location = new System.Drawing.Point(297, 0);
            this.lblidTrabajador.Name = "lblidTrabajador";
            this.lblidTrabajador.Size = new System.Drawing.Size(550, 26);
            this.lblidTrabajador.Text = "Id Ingresos:";
            this.lblidTrabajador.TextSize = new System.Drawing.Size(96, 16);
            this.lblidTrabajador.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnCancelar;
            this.layoutControlItem12.Location = new System.Drawing.Point(222, 342);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(94, 40);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(94, 40);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(94, 40);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(316, 342);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(531, 40);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(897, 445);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.groupBox1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(877, 425);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(279, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 49);
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
            this.lblTituloIngresos.Size = new System.Drawing.Size(263, 49);
            this.lblTituloIngresos.TabIndex = 1;
            this.lblTituloIngresos.Text = "Ingresos  Almacen";
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
            this.emptySpaceItem2.Location = new System.Drawing.Point(371, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(544, 53);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblTituloIngresos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(267, 53);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pictureBox1;
            this.layoutControlItem2.Location = new System.Drawing.Point(267, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 53);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.tabControl1;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(915, 481);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // frm_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 554);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_Ingresos";
            this.Text = "Mantenimiento de Ingresos de almacen";
            this.Load += new System.EventHandler(this.frm_Ingresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkIngreso)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbTrabajador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionDetalleIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).EndInit();
            this.layoutControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetalleIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFechaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCorrelativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblidTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkDetalleIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloIngresos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.Label lblTotal;
        private DevExpress.XtraEditors.SimpleButton btnAnular;
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
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.ComboBox cbComprobante;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCambios;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.MaskedTextBox txtSerie;
        private System.Windows.Forms.TextBox txtidIngresos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem lblidTrabajador;
        private DevExpress.XtraLayout.LayoutControlItem lblSerie;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem lblFechaIngreso;
        private DevExpress.XtraLayout.LayoutControlItem lblComprobante;
        private DevExpress.XtraLayout.LayoutControlItem lblCorrelativo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraLayout.LayoutControl layoutControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit sbArticulo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox txtIdDetalleIngreso;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem lblDetalleIngreso;
        private DevExpress.XtraLayout.LayoutControlItem lblArticulos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.TextBox txtStockInicial;
        private DevExpress.XtraLayout.LayoutControlItem lblStockInicial;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private DevExpress.XtraLayout.LayoutControlItem lblPrecioCompra;
        private DevExpress.XtraLayout.LayoutControlItem lblPrecioVenta;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtFechaProducion;
        private DevExpress.XtraLayout.LayoutControlItem LblFechaProd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem16;
        private DevExpress.XtraLayout.LayoutControlItem lblFechaVencimiento;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem18;
        private DevExpress.XtraEditors.SearchLookUpEdit sbProveedor;
        private DevExpress.Xpo.XPCollection xpCollectionProveedor;
        private DevExpress.Xpo.UnitOfWork unitOfWorkIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.Label lblTotalPagado;
        private DevExpress.XtraGrid.GridControl gridControlDetalleIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView dataListadoDetalle;
        private DevExpress.Xpo.XPCollection xpCollectionArticulos;
        private DevExpress.Xpo.UnitOfWork unitOfWorkDetalleIngreso;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem lblProveedor;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private DevExpress.Xpo.XPCollection xpCollectionIngreso;
        private DevExpress.XtraEditors.SearchLookUpEdit sbTrabajador;
        private DevExpress.Xpo.XPCollection xpCollectionTrabajador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem lblTrabajador;
        private System.Windows.Forms.MaskedTextBox txtIGV;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem lblIGV;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraEditors.SimpleButton btnQuitar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn NonbreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_Comprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colCorrelativo;
        private DevExpress.XtraGrid.Columns.GridColumn colIGV;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.Xpo.XPCollection xpCollectionDetalleIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn ColArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Compra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Venta;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraEditors.SimpleButton btnAnular1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colStockInicial;
    }
}