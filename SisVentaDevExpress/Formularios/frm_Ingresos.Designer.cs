
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            this.gridControlDetalleIngreso = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionDetalleIngreso = new DevExpress.Xpo.XPCollection(this.components);
            this.dataListadoDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
            this.sbArticulo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionArticulos = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIdDetalleIngreso = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnAgregar2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblDetalleIngreso = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblArticulos = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblPrecioCompra = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblStockInicial = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblPrecioVenta = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.unitOfWorkDetalleIngreso = new DevExpress.Xpo.UnitOfWork(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregar1 = new DevExpress.XtraEditors.SimpleButton();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkDetalleIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tabControl1);
            this.layoutControl1.Controls.Add(this.pictureBox1);
            this.layoutControl1.Controls.Add(this.lblTituloIngresos);
            this.layoutControl1.Controls.Add(this.btnSalir);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 328, 650, 400);
            this.layoutControl1.Root = this.Root;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.layoutControl2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.lblTotal);
            this.layoutControl2.Controls.Add(this.btnAnular);
            this.layoutControl2.Controls.Add(this.btnImprimir1);
            this.layoutControl2.Controls.Add(this.btnEditar1);
            this.layoutControl2.Controls.Add(this.btnAgregar);
            this.layoutControl2.Controls.Add(this.gridControl2);
            resources.ApplyResources(this.layoutControl2, "layoutControl2");
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            // 
            // lblTotal
            // 
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // btnAnular
            // 
            this.btnAnular.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAnular.Appearance.Font")));
            this.btnAnular.Appearance.Options.UseFont = true;
            this.btnAnular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.ImageOptions.Image")));
            resources.ApplyResources(this.btnAnular, "btnAnular");
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.StyleController = this.layoutControl2;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnImprimir1.Appearance.Font")));
            this.btnImprimir1.Appearance.Options.UseFont = true;
            this.btnImprimir1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir1.ImageOptions.Image")));
            resources.ApplyResources(this.btnImprimir1, "btnImprimir1");
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.StyleController = this.layoutControl2;
            this.btnImprimir1.Click += new System.EventHandler(this.btnImprimir1_Click);
            // 
            // btnEditar1
            // 
            this.btnEditar1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnEditar1.Appearance.Font")));
            this.btnEditar1.Appearance.Options.UseFont = true;
            this.btnEditar1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar1.ImageOptions.Image")));
            resources.ApplyResources(this.btnEditar1, "btnEditar1");
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.StyleController = this.layoutControl2;
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAgregar.Appearance.Font")));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.StyleController = this.layoutControl2;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.xpCollectionIngreso;
            resources.ApplyResources(this.gridControl2, "gridControl2");
            this.gridControl2.MainView = this.dataListado;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataListado});
            this.gridControl2.DoubleClick += new System.EventHandler(this.btnEditar1_Click);
            // 
            // xpCollectionIngreso
            // 
            this.xpCollectionIngreso.ObjectType = typeof(SisVentaDevExpress.Ventas.Ingreso);
            this.xpCollectionIngreso.Session = this.unitOfWorkIngreso;
            // 
            // dataListado
            // 
            this.dataListado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.ColumnFilterButton.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.ColumnFilterButton.BackColor2")));
            this.dataListado.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.dataListado.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dataListado.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dataListado.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dataListado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListado.Appearance.ColumnFilterButtonActive.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.ColumnFilterButtonActive.BackColor2")));
            this.dataListado.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListado.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.dataListado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dataListado.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dataListado.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dataListado.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dataListado.Appearance.Empty.Options.UseBackColor = true;
            this.dataListado.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataListado.Appearance.EvenRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.EvenRow.BackColor2")));
            this.dataListado.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.EvenRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListado.Appearance.EvenRow.GradientMode")));
            this.dataListado.Appearance.EvenRow.Options.UseBackColor = true;
            this.dataListado.Appearance.EvenRow.Options.UseForeColor = true;
            this.dataListado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListado.Appearance.FilterCloseButton.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.FilterCloseButton.BackColor2")));
            this.dataListado.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListado.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.FilterCloseButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListado.Appearance.FilterCloseButton.GradientMode")));
            this.dataListado.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dataListado.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dataListado.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.dataListado.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.dataListado.Appearance.FilterPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.FilterPanel.BackColor2")));
            this.dataListado.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.FilterPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListado.Appearance.FilterPanel.GradientMode")));
            this.dataListado.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dataListado.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dataListado.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dataListado.Appearance.FixedLine.Options.UseBackColor = true;
            this.dataListado.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataListado.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dataListado.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dataListado.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.dataListado.Appearance.FocusedRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.FocusedRow.BackColor2")));
            this.dataListado.Appearance.FocusedRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListado.Appearance.FocusedRow.Font")));
            this.dataListado.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dataListado.Appearance.FocusedRow.Options.UseFont = true;
            this.dataListado.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dataListado.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dataListado.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dataListado.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.GroupButton.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dataListado.Appearance.GroupButton.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListado.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListado.Appearance.GroupFooter.Font = ((System.Drawing.Font)(resources.GetObject("dataListado.Appearance.GroupFooter.Font")));
            this.dataListado.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dataListado.Appearance.GroupFooter.Options.UseFont = true;
            this.dataListado.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.dataListado.Appearance.GroupPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.GroupPanel.BackColor2")));
            this.dataListado.Appearance.GroupPanel.Font = ((System.Drawing.Font)(resources.GetObject("dataListado.Appearance.GroupPanel.Font")));
            this.dataListado.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupPanel.Options.UseFont = true;
            this.dataListado.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dataListado.Appearance.GroupRow.BackColor = System.Drawing.Color.LightGray;
            this.dataListado.Appearance.GroupRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListado.Appearance.GroupRow.Font")));
            this.dataListado.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.GroupRow.Options.UseBackColor = true;
            this.dataListado.Appearance.GroupRow.Options.UseFont = true;
            this.dataListado.Appearance.GroupRow.Options.UseForeColor = true;
            this.dataListado.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataListado.Appearance.HeaderPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.HeaderPanel.BackColor2")));
            this.dataListado.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("dataListado.Appearance.HeaderPanel.Font")));
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
            this.dataListado.Appearance.OddRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.OddRow.BackColor2")));
            this.dataListado.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListado.Appearance.OddRow.GradientMode")));
            this.dataListado.Appearance.OddRow.Options.UseBackColor = true;
            this.dataListado.Appearance.OddRow.Options.UseForeColor = true;
            this.dataListado.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.dataListado.Appearance.Preview.Font = ((System.Drawing.Font)(resources.GetObject("dataListado.Appearance.Preview.Font")));
            this.dataListado.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.dataListado.Appearance.Preview.Options.UseBackColor = true;
            this.dataListado.Appearance.Preview.Options.UseFont = true;
            this.dataListado.Appearance.Preview.Options.UseForeColor = true;
            this.dataListado.Appearance.Row.BackColor = System.Drawing.Color.LightGray;
            this.dataListado.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("dataListado.Appearance.Row.Font")));
            this.dataListado.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dataListado.Appearance.Row.Options.UseBackColor = true;
            this.dataListado.Appearance.Row.Options.UseFont = true;
            this.dataListado.Appearance.Row.Options.UseForeColor = true;
            this.dataListado.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dataListado.Appearance.RowSeparator.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListado.Appearance.RowSeparator.BackColor2")));
            this.dataListado.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dataListado.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.dataListado.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.dataListado.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dataListado.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dataListado.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.VertLine.Options.UseBackColor = true;
            this.dataListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrabajador,
            this.colProveedor,
            this.colFecha_Ingreso,
            this.colTipo_Comprobante,
            this.colSerie,
            this.colCorrelativo,
            this.colIGV});
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
            // colTrabajador
            // 
            this.colTrabajador.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colTrabajador.AppearanceCell.Font")));
            this.colTrabajador.AppearanceCell.Options.UseFont = true;
            this.colTrabajador.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colTrabajador.AppearanceHeader.Font")));
            this.colTrabajador.AppearanceHeader.Options.UseFont = true;
            this.colTrabajador.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrabajador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colTrabajador, "colTrabajador");
            this.colTrabajador.FieldName = "IdTrabajador.NombreCompleto";
            this.colTrabajador.Name = "colTrabajador";
            // 
            // colProveedor
            // 
            this.colProveedor.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colProveedor.AppearanceCell.Font")));
            this.colProveedor.AppearanceCell.Options.UseFont = true;
            this.colProveedor.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colProveedor.AppearanceHeader.Font")));
            this.colProveedor.AppearanceHeader.Options.UseFont = true;
            this.colProveedor.AppearanceHeader.Options.UseTextOptions = true;
            this.colProveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProveedor, "colProveedor");
            this.colProveedor.FieldName = "IdProveedor.Razon_Social";
            this.colProveedor.Name = "colProveedor";
            // 
            // colFecha_Ingreso
            // 
            this.colFecha_Ingreso.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colFecha_Ingreso.AppearanceCell.Font")));
            this.colFecha_Ingreso.AppearanceCell.Options.UseFont = true;
            this.colFecha_Ingreso.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colFecha_Ingreso.AppearanceHeader.Font")));
            this.colFecha_Ingreso.AppearanceHeader.Options.UseFont = true;
            this.colFecha_Ingreso.AppearanceHeader.Options.UseTextOptions = true;
            this.colFecha_Ingreso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colFecha_Ingreso, "colFecha_Ingreso");
            this.colFecha_Ingreso.FieldName = "Fecha_Ingreso";
            this.colFecha_Ingreso.Name = "colFecha_Ingreso";
            // 
            // colTipo_Comprobante
            // 
            this.colTipo_Comprobante.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colTipo_Comprobante.AppearanceCell.Font")));
            this.colTipo_Comprobante.AppearanceCell.Options.UseFont = true;
            this.colTipo_Comprobante.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colTipo_Comprobante.AppearanceHeader.Font")));
            this.colTipo_Comprobante.AppearanceHeader.Options.UseFont = true;
            this.colTipo_Comprobante.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipo_Comprobante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colTipo_Comprobante, "colTipo_Comprobante");
            this.colTipo_Comprobante.FieldName = "Tipo_Comprobante";
            this.colTipo_Comprobante.Name = "colTipo_Comprobante";
            // 
            // colSerie
            // 
            this.colSerie.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colSerie.AppearanceCell.Font")));
            this.colSerie.AppearanceCell.Options.UseFont = true;
            this.colSerie.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colSerie.AppearanceHeader.Font")));
            this.colSerie.AppearanceHeader.Options.UseFont = true;
            this.colSerie.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colSerie, "colSerie");
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            // 
            // colCorrelativo
            // 
            this.colCorrelativo.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colCorrelativo.AppearanceCell.Font")));
            this.colCorrelativo.AppearanceCell.Options.UseFont = true;
            this.colCorrelativo.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colCorrelativo.AppearanceHeader.Font")));
            this.colCorrelativo.AppearanceHeader.Options.UseFont = true;
            this.colCorrelativo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCorrelativo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colCorrelativo, "colCorrelativo");
            this.colCorrelativo.FieldName = "Correlativo";
            this.colCorrelativo.Name = "colCorrelativo";
            // 
            // colIGV
            // 
            this.colIGV.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colIGV.AppearanceCell.Font")));
            this.colIGV.AppearanceCell.Options.UseFont = true;
            this.colIGV.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colIGV.AppearanceHeader.Font")));
            this.colIGV.AppearanceHeader.Options.UseFont = true;
            this.colIGV.AppearanceHeader.Options.UseTextOptions = true;
            this.colIGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colIGV, "colIGV");
            this.colIGV.FieldName = "IGV";
            this.colIGV.Name = "colIGV";
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
            this.emptySpaceItem9});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(897, 429);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(877, 345);
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
            this.layoutControlItem8.Location = new System.Drawing.Point(296, 0);
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
            this.emptySpaceItem8.Location = new System.Drawing.Point(247, 385);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(630, 24);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.lblTotal;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 385);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(247, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(247, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(247, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(397, 0);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(480, 40);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.layoutControl3);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.layoutControl3, "layoutControl3");
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl4);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.txtIGV);
            this.layoutControl4.Controls.Add(this.sbTrabajador);
            this.layoutControl4.Controls.Add(this.sbProveedor);
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
            resources.ApplyResources(this.layoutControl4, "layoutControl4");
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 66, 650, 400);
            this.layoutControl4.Root = this.layoutControlGroup3;
            // 
            // txtIGV
            // 
            resources.ApplyResources(this.txtIGV, "txtIGV");
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ValidatingType = typeof(int);
            // 
            // sbTrabajador
            // 
            resources.ApplyResources(this.sbTrabajador, "sbTrabajador");
            this.sbTrabajador.Name = "sbTrabajador";
            this.sbTrabajador.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("sbTrabajador.Properties.Appearance.Font")));
            this.sbTrabajador.Properties.Appearance.Options.UseFont = true;
            this.sbTrabajador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("sbTrabajador.Properties.Buttons"))))});
            this.sbTrabajador.Properties.DataSource = this.xpCollectionTrabajador;
            this.sbTrabajador.Properties.DisplayMember = "NombreCompleto";
            this.sbTrabajador.Properties.PopupView = this.gridView1;
            this.sbTrabajador.Properties.ValueMember = "IdTrabajador";
            this.sbTrabajador.StyleController = this.layoutControl4;
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
            this.NonbreCompleto.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("NonbreCompleto.AppearanceCell.Font")));
            this.NonbreCompleto.AppearanceCell.Options.UseFont = true;
            this.NonbreCompleto.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("NonbreCompleto.AppearanceHeader.Font")));
            this.NonbreCompleto.AppearanceHeader.Options.UseFont = true;
            this.NonbreCompleto.AppearanceHeader.Options.UseTextOptions = true;
            this.NonbreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.NonbreCompleto, "NonbreCompleto");
            this.NonbreCompleto.FieldName = "NombreCompleto";
            this.NonbreCompleto.Name = "NonbreCompleto";
            // 
            // sbProveedor
            // 
            resources.ApplyResources(this.sbProveedor, "sbProveedor");
            this.sbProveedor.Name = "sbProveedor";
            this.sbProveedor.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("sbProveedor.Properties.Appearance.Font")));
            this.sbProveedor.Properties.Appearance.Options.UseFont = true;
            this.sbProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("sbProveedor.Properties.Buttons"))))});
            this.sbProveedor.Properties.DataSource = this.xpCollectionProveedor;
            this.sbProveedor.Properties.DisplayMember = "Razon_Social";
            this.sbProveedor.Properties.PopupView = this.searchLookUpEdit2View;
            this.sbProveedor.Properties.ValueMember = "IdProveedor";
            this.sbProveedor.StyleController = this.layoutControl4;
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
            this.Proveedor.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("Proveedor.AppearanceCell.Font")));
            this.Proveedor.AppearanceCell.Options.UseFont = true;
            this.Proveedor.AppearanceCell.Options.UseTextOptions = true;
            this.Proveedor.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("Proveedor.AppearanceHeader.Font")));
            this.Proveedor.AppearanceHeader.Options.UseFont = true;
            this.Proveedor.AppearanceHeader.Options.UseTextOptions = true;
            this.Proveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.Proveedor, "Proveedor");
            this.Proveedor.FieldName = "Razon_Social";
            this.Proveedor.Name = "Proveedor";
            // 
            // gridControlDetalleIngreso
            // 
            this.gridControlDetalleIngreso.DataSource = this.xpCollectionDetalleIngreso;
            resources.ApplyResources(this.gridControlDetalleIngreso, "gridControlDetalleIngreso");
            this.gridControlDetalleIngreso.MainView = this.dataListadoDetalle;
            this.gridControlDetalleIngreso.Name = "gridControlDetalleIngreso";
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
            this.dataListadoDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.ColumnFilterButton.BackColor2")));
            this.dataListadoDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.ColumnFilterButtonActive.BackColor2")));
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dataListadoDetalle.Appearance.Empty.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataListadoDetalle.Appearance.EvenRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.EvenRow.BackColor2")));
            this.dataListadoDetalle.Appearance.EvenRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.EvenRow.Font")));
            this.dataListadoDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.EvenRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListadoDetalle.Appearance.EvenRow.GradientMode")));
            this.dataListadoDetalle.Appearance.EvenRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.EvenRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.EvenRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListadoDetalle.Appearance.FilterCloseButton.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.FilterCloseButton.BackColor2")));
            this.dataListadoDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListadoDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.FilterCloseButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListadoDetalle.Appearance.FilterCloseButton.GradientMode")));
            this.dataListadoDetalle.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.dataListadoDetalle.Appearance.FilterPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.FilterPanel.BackColor2")));
            this.dataListadoDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.FilterPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListadoDetalle.Appearance.FilterPanel.GradientMode")));
            this.dataListadoDetalle.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dataListadoDetalle.Appearance.FixedLine.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataListadoDetalle.Appearance.FocusedCell.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.FocusedCell.Font")));
            this.dataListadoDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FocusedCell.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.dataListadoDetalle.Appearance.FocusedRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.FocusedRow.BackColor2")));
            this.dataListadoDetalle.Appearance.FocusedRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.FocusedRow.Font")));
            this.dataListadoDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListadoDetalle.Appearance.FocusedRow.GradientMode")));
            this.dataListadoDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FocusedRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.GroupButton.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.GroupButton.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListadoDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataListadoDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.dataListadoDetalle.Appearance.GroupPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.GroupPanel.BackColor2")));
            this.dataListadoDetalle.Appearance.GroupPanel.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.GroupPanel.Font")));
            this.dataListadoDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupPanel.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.LightGray;
            this.dataListadoDetalle.Appearance.GroupRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.GroupRow.Font")));
            this.dataListadoDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.GroupRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.GroupRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.GroupRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataListadoDetalle.Appearance.HeaderPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.HeaderPanel.BackColor2")));
            this.dataListadoDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.HeaderPanel.Font")));
            this.dataListadoDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.dataListadoDetalle.Appearance.HideSelectionRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.HideSelectionRow.Font")));
            this.dataListadoDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dataListadoDetalle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.HideSelectionRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.HorzLine.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.OddRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.OddRow.BackColor2")));
            this.dataListadoDetalle.Appearance.OddRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.OddRow.Font")));
            this.dataListadoDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dataListadoDetalle.Appearance.OddRow.GradientMode")));
            this.dataListadoDetalle.Appearance.OddRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.OddRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.OddRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.Preview.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.Preview.Font")));
            this.dataListadoDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.dataListadoDetalle.Appearance.Preview.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.Preview.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.Preview.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.Row.BackColor = System.Drawing.Color.LightGray;
            this.dataListadoDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dataListadoDetalle.Appearance.Row.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.Row.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.Row.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.RowSeparator.BackColor2 = ((System.Drawing.Color)(resources.GetObject("dataListadoDetalle.Appearance.RowSeparator.BackColor2")));
            this.dataListadoDetalle.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.dataListadoDetalle.Appearance.SelectedRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.SelectedRow.Font")));
            this.dataListadoDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.dataListadoDetalle.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dataListadoDetalle.Appearance.SelectedRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dataListadoDetalle.Appearance.TopNewRow.Font = ((System.Drawing.Font)(resources.GetObject("dataListadoDetalle.Appearance.TopNewRow.Font")));
            this.dataListadoDetalle.Appearance.TopNewRow.Options.UseFont = true;
            this.dataListadoDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.dataListadoDetalle.Appearance.VertLine.Options.UseBackColor = true;
            this.dataListadoDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoArticulo,
            this.ColArticulo,
            this.colUDM,
            this.colCantidad,
            this.colPrecio_Compra,
            this.colPrecio_Venta,
            this.gridColumn3});
            this.dataListadoDetalle.GridControl = this.gridControlDetalleIngreso;
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.OptionsBehavior.Editable = false;
            this.dataListadoDetalle.OptionsFind.AlwaysVisible = true;
            this.dataListadoDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.dataListadoDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.dataListadoDetalle.OptionsView.ShowFooter = true;
            this.dataListadoDetalle.OptionsView.ShowGroupPanel = false;
            this.dataListadoDetalle.PaintStyleName = "Flat";
            // 
            // colCodigoArticulo
            // 
            this.colCodigoArticulo.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colCodigoArticulo.AppearanceCell.Font")));
            this.colCodigoArticulo.AppearanceCell.Options.UseFont = true;
            this.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigoArticulo.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colCodigoArticulo.AppearanceHeader.Font")));
            this.colCodigoArticulo.AppearanceHeader.Options.UseFont = true;
            this.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colCodigoArticulo, "colCodigoArticulo");
            this.colCodigoArticulo.FieldName = "IdArticulo.Codigo";
            this.colCodigoArticulo.Name = "colCodigoArticulo";
            // 
            // ColArticulo
            // 
            this.ColArticulo.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("ColArticulo.AppearanceCell.Font")));
            this.ColArticulo.AppearanceCell.Options.UseFont = true;
            this.ColArticulo.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColArticulo.AppearanceHeader.Font")));
            this.ColArticulo.AppearanceHeader.Options.UseFont = true;
            this.ColArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.ColArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ColArticulo, "ColArticulo");
            this.ColArticulo.FieldName = "IdArticulo.Nombre";
            this.ColArticulo.Name = "ColArticulo";
            // 
            // colUDM
            // 
            this.colUDM.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colUDM.AppearanceCell.Font")));
            this.colUDM.AppearanceCell.Options.UseFont = true;
            this.colUDM.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colUDM.AppearanceHeader.Font")));
            this.colUDM.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colUDM, "colUDM");
            this.colUDM.FieldName = "IdArticulo.IdPresentacion.Nombre";
            this.colUDM.Name = "colUDM";
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colCantidad.AppearanceCell.Font")));
            this.colCantidad.AppearanceCell.Options.UseFont = true;
            this.colCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colCantidad.AppearanceHeader.Font")));
            this.colCantidad.AppearanceHeader.Options.UseFont = true;
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colCantidad, "colCantidad");
            this.colCantidad.FieldName = "Stock_inicial";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio_Compra
            // 
            this.colPrecio_Compra.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colPrecio_Compra.AppearanceCell.Font")));
            this.colPrecio_Compra.AppearanceCell.Options.UseFont = true;
            this.colPrecio_Compra.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecio_Compra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio_Compra.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colPrecio_Compra.AppearanceHeader.Font")));
            this.colPrecio_Compra.AppearanceHeader.Options.UseFont = true;
            this.colPrecio_Compra.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio_Compra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colPrecio_Compra, "colPrecio_Compra");
            this.colPrecio_Compra.FieldName = "Precio_Compra";
            this.colPrecio_Compra.Name = "colPrecio_Compra";
            // 
            // colPrecio_Venta
            // 
            this.colPrecio_Venta.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colPrecio_Venta.AppearanceCell.Font")));
            this.colPrecio_Venta.AppearanceCell.Options.UseFont = true;
            this.colPrecio_Venta.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecio_Venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio_Venta.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colPrecio_Venta.AppearanceHeader.Font")));
            this.colPrecio_Venta.AppearanceHeader.Options.UseFont = true;
            this.colPrecio_Venta.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio_Venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio_Venta.FieldName = "Precio_Venta";
            this.colPrecio_Venta.Name = "colPrecio_Venta";
            resources.ApplyResources(this.colPrecio_Venta, "colPrecio_Venta");
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn3.AppearanceCell.Font")));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn3.AppearanceHeader.Font")));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.FieldName = "Sub_total";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridColumn3.Summary"))), resources.GetString("gridColumn3.Summary1"), resources.GetString("gridColumn3.Summary2"))});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.layoutControl5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // layoutControl5
            // 
            this.layoutControl5.Controls.Add(this.textEdit1);
            this.layoutControl5.Controls.Add(this.btnQuitar);
            this.layoutControl5.Controls.Add(this.sbArticulo);
            this.layoutControl5.Controls.Add(this.txtIdDetalleIngreso);
            this.layoutControl5.Controls.Add(this.txtStockInicial);
            this.layoutControl5.Controls.Add(this.txtPrecioCompra);
            this.layoutControl5.Controls.Add(this.txtPrecioVenta);
            this.layoutControl5.Controls.Add(this.btnAgregar2);
            resources.ApplyResources(this.layoutControl5, "layoutControl5");
            this.layoutControl5.Name = "layoutControl5";
            this.layoutControl5.Root = this.layoutControlGroup4;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnQuitar.Appearance.Font")));
            this.btnQuitar.Appearance.Options.UseFont = true;
            this.btnQuitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.ImageOptions.Image")));
            resources.ApplyResources(this.btnQuitar, "btnQuitar");
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.StyleController = this.layoutControl5;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // sbArticulo
            // 
            resources.ApplyResources(this.sbArticulo, "sbArticulo");
            this.sbArticulo.Name = "sbArticulo";
            this.sbArticulo.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("sbArticulo.Properties.Appearance.Font")));
            this.sbArticulo.Properties.Appearance.Options.UseFont = true;
            this.sbArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("sbArticulo.Properties.Buttons"))))});
            this.sbArticulo.Properties.DataSource = this.xpCollectionArticulos;
            this.sbArticulo.Properties.DisplayMember = "NombreCompleto";
            this.sbArticulo.Properties.PopupView = this.searchLookUpEdit1View;
            this.sbArticulo.Properties.ValueMember = "IdArticulos";
            this.sbArticulo.StyleController = this.layoutControl5;
            // 
            // xpCollectionArticulos
            // 
            this.xpCollectionArticulos.ObjectType = typeof(SisVentaDevExpress.Ventas.Articulo);
            this.xpCollectionArticulos.Session = this.unitOfWorkIngreso;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.colCategoria,
            this.ColPresentacion,
            this.ColDescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.GroupCount = 2;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsCustomization.AllowGroup = false;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoria, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColPresentacion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn12.AppearanceCell.Font")));
            this.gridColumn12.AppearanceCell.Options.UseFont = true;
            this.gridColumn12.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn12.AppearanceHeader.Font")));
            this.gridColumn12.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.gridColumn12, "gridColumn12");
            this.gridColumn12.FieldName = "Nombre";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // colCategoria
            // 
            this.colCategoria.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colCategoria.AppearanceCell.Font")));
            this.colCategoria.AppearanceCell.Options.UseFont = true;
            this.colCategoria.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoria.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colCategoria.AppearanceHeader.Font")));
            this.colCategoria.AppearanceHeader.Options.UseFont = true;
            this.colCategoria.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colCategoria, "colCategoria");
            this.colCategoria.FieldName = "IdCategoria.Nombre";
            this.colCategoria.Name = "colCategoria";
            // 
            // ColPresentacion
            // 
            this.ColPresentacion.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("ColPresentacion.AppearanceCell.Font")));
            this.ColPresentacion.AppearanceCell.Options.UseFont = true;
            this.ColPresentacion.AppearanceCell.Options.UseTextOptions = true;
            this.ColPresentacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColPresentacion.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColPresentacion.AppearanceHeader.Font")));
            this.ColPresentacion.AppearanceHeader.Options.UseFont = true;
            this.ColPresentacion.AppearanceHeader.Options.UseTextOptions = true;
            this.ColPresentacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ColPresentacion, "ColPresentacion");
            this.ColPresentacion.FieldName = "IdPresentacion.Nombre";
            this.ColPresentacion.Name = "ColPresentacion";
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("ColDescripcion.AppearanceCell.Font")));
            this.ColDescripcion.AppearanceCell.Options.UseFont = true;
            this.ColDescripcion.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColDescripcion.AppearanceHeader.Font")));
            this.ColDescripcion.AppearanceHeader.Options.UseFont = true;
            this.ColDescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.ColDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ColDescripcion, "ColDescripcion");
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            // 
            // txtIdDetalleIngreso
            // 
            resources.ApplyResources(this.txtIdDetalleIngreso, "txtIdDetalleIngreso");
            this.txtIdDetalleIngreso.Name = "txtIdDetalleIngreso";
            // 
            // txtStockInicial
            // 
            resources.ApplyResources(this.txtStockInicial, "txtStockInicial");
            this.txtStockInicial.Name = "txtStockInicial";
            // 
            // txtPrecioCompra
            // 
            resources.ApplyResources(this.txtPrecioCompra, "txtPrecioCompra");
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // txtPrecioVenta
            // 
            resources.ApplyResources(this.txtPrecioVenta, "txtPrecioVenta");
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAgregar2.Appearance.Font")));
            this.btnAgregar2.Appearance.Options.UseFont = true;
            this.btnAgregar2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar2.ImageOptions.Image")));
            resources.ApplyResources(this.btnAgregar2, "btnAgregar2");
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.StyleController = this.layoutControl5;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblDetalleIngreso,
            this.lblArticulos,
            this.emptySpaceItem15,
            this.lblPrecioCompra,
            this.lblStockInicial,
            this.emptySpaceItem14,
            this.lblPrecioVenta,
            this.layoutControlItem19,
            this.layoutControlItem18,
            this.emptySpaceItem16,
            this.emptySpaceItem4,
            this.layoutControlItem17});
            this.layoutControlGroup4.Name = "Root";
            this.layoutControlGroup4.Size = new System.Drawing.Size(898, 96);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // lblDetalleIngreso
            // 
            this.lblDetalleIngreso.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblDetalleIngreso.AppearanceItemCaption.Font")));
            this.lblDetalleIngreso.AppearanceItemCaption.Options.UseFont = true;
            this.lblDetalleIngreso.Control = this.txtIdDetalleIngreso;
            this.lblDetalleIngreso.Location = new System.Drawing.Point(0, 0);
            this.lblDetalleIngreso.Name = "lblDetalleIngreso";
            this.lblDetalleIngreso.Size = new System.Drawing.Size(878, 24);
            resources.ApplyResources(this.lblDetalleIngreso, "lblDetalleIngreso");
            this.lblDetalleIngreso.TextSize = new System.Drawing.Size(128, 16);
            this.lblDetalleIngreso.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lblArticulos
            // 
            this.lblArticulos.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblArticulos.AppearanceItemCaption.Font")));
            this.lblArticulos.AppearanceItemCaption.Options.UseFont = true;
            this.lblArticulos.Control = this.sbArticulo;
            this.lblArticulos.Location = new System.Drawing.Point(0, 24);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(115, 26);
            resources.ApplyResources(this.lblArticulos, "lblArticulos");
            this.lblArticulos.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblArticulos.TextSize = new System.Drawing.Size(56, 16);
            this.lblArticulos.TextToControlDistance = 5;
            // 
            // emptySpaceItem15
            // 
            this.emptySpaceItem15.AllowHotTrack = false;
            this.emptySpaceItem15.Location = new System.Drawing.Point(115, 24);
            this.emptySpaceItem15.Name = "emptySpaceItem15";
            this.emptySpaceItem15.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem15.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblPrecioCompra.AppearanceItemCaption.Font")));
            this.lblPrecioCompra.AppearanceItemCaption.Options.UseFont = true;
            this.lblPrecioCompra.Control = this.txtPrecioCompra;
            resources.ApplyResources(this.lblPrecioCompra, "lblPrecioCompra");
            this.lblPrecioCompra.Location = new System.Drawing.Point(125, 24);
            this.lblPrecioCompra.MaxSize = new System.Drawing.Size(211, 24);
            this.lblPrecioCompra.MinSize = new System.Drawing.Size(211, 24);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(211, 24);
            this.lblPrecioCompra.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lblPrecioCompra.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblPrecioCompra.TextSize = new System.Drawing.Size(94, 16);
            this.lblPrecioCompra.TextToControlDistance = 5;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblStockInicial.AppearanceItemCaption.Font")));
            this.lblStockInicial.AppearanceItemCaption.Options.UseFont = true;
            this.lblStockInicial.Control = this.txtStockInicial;
            resources.ApplyResources(this.lblStockInicial, "lblStockInicial");
            this.lblStockInicial.Location = new System.Drawing.Point(0, 50);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(115, 26);
            this.lblStockInicial.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblStockInicial.TextSize = new System.Drawing.Size(82, 16);
            this.lblStockInicial.TextToControlDistance = 5;
            // 
            // emptySpaceItem14
            // 
            this.emptySpaceItem14.AllowHotTrack = false;
            this.emptySpaceItem14.Location = new System.Drawing.Point(115, 52);
            this.emptySpaceItem14.Name = "emptySpaceItem14";
            this.emptySpaceItem14.Size = new System.Drawing.Size(10, 24);
            this.emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblPrecioVenta.AppearanceItemCaption.Font")));
            this.lblPrecioVenta.AppearanceItemCaption.Options.UseFont = true;
            this.lblPrecioVenta.Control = this.txtPrecioVenta;
            resources.ApplyResources(this.lblPrecioVenta, "lblPrecioVenta");
            this.lblPrecioVenta.Location = new System.Drawing.Point(125, 48);
            this.lblPrecioVenta.MaxSize = new System.Drawing.Size(211, 28);
            this.lblPrecioVenta.MinSize = new System.Drawing.Size(211, 28);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(211, 28);
            this.lblPrecioVenta.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lblPrecioVenta.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblPrecioVenta.TextSize = new System.Drawing.Size(88, 16);
            this.lblPrecioVenta.TextToControlDistance = 5;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.btnQuitar;
            this.layoutControlItem19.Location = new System.Drawing.Point(336, 50);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(102, 26);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(102, 26);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(102, 26);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.btnAgregar2;
            this.layoutControlItem18.Location = new System.Drawing.Point(336, 24);
            this.layoutControlItem18.MaxSize = new System.Drawing.Size(102, 26);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(102, 26);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(102, 26);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // emptySpaceItem16
            // 
            this.emptySpaceItem16.AllowHotTrack = false;
            this.emptySpaceItem16.Location = new System.Drawing.Point(623, 24);
            this.emptySpaceItem16.MaxSize = new System.Drawing.Size(255, 26);
            this.emptySpaceItem16.MinSize = new System.Drawing.Size(255, 26);
            this.emptySpaceItem16.Name = "emptySpaceItem16";
            this.emptySpaceItem16.Size = new System.Drawing.Size(255, 26);
            this.emptySpaceItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem16.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(438, 50);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(255, 26);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(255, 26);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(440, 26);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtCorrelativo
            // 
            resources.ApplyResources(this.txtCorrelativo, "txtCorrelativo");
            this.txtCorrelativo.Name = "txtCorrelativo";
            // 
            // cbComprobante
            // 
            resources.ApplyResources(this.cbComprobante, "cbComprobante");
            this.cbComprobante.FormattingEnabled = true;
            this.cbComprobante.Items.AddRange(new object[] {
            resources.GetString("cbComprobante.Items"),
            resources.GetString("cbComprobante.Items1"),
            resources.GetString("cbComprobante.Items2")});
            this.cbComprobante.Name = "cbComprobante";
            // 
            // dtFechaIngreso
            // 
            resources.ApplyResources(this.dtFechaIngreso, "dtFechaIngreso");
            this.dtFechaIngreso.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnCancelar.Appearance.Font")));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.StyleController = this.layoutControl4;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnGuardarCambios.Appearance.Font")));
            this.btnGuardarCambios.Appearance.Options.UseFont = true;
            this.btnGuardarCambios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.ImageOptions.Image")));
            resources.ApplyResources(this.btnGuardarCambios, "btnGuardarCambios");
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.StyleController = this.layoutControl4;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnGuardar.Appearance.Font")));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.StyleController = this.layoutControl4;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSerie
            // 
            resources.ApplyResources(this.txtSerie, "txtSerie");
            this.txtSerie.Name = "txtSerie";
            // 
            // txtidIngresos
            // 
            resources.ApplyResources(this.txtidIngresos, "txtidIngresos");
            this.txtidIngresos.Name = "txtidIngresos";
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
            this.layoutControlGroup3.Size = new System.Drawing.Size(867, 386);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnGuardar;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 326);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(107, 40);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(107, 40);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(107, 40);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnGuardarCambios;
            this.layoutControlItem11.Location = new System.Drawing.Point(107, 326);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(164, 40);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(164, 40);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(164, 40);
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
            this.layoutControlItem3.Size = new System.Drawing.Size(847, 86);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.gridControlDetalleIngreso;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 163);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(847, 163);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblCorrelativo.AppearanceItemCaption.Font")));
            this.lblCorrelativo.AppearanceItemCaption.Options.UseFont = true;
            this.lblCorrelativo.Control = this.txtCorrelativo;
            this.lblCorrelativo.Location = new System.Drawing.Point(476, 52);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(371, 25);
            resources.ApplyResources(this.lblCorrelativo, "lblCorrelativo");
            this.lblCorrelativo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblCorrelativo.TextSize = new System.Drawing.Size(77, 16);
            this.lblCorrelativo.TextToControlDistance = 5;
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblTrabajador.AppearanceItemCaption.Font")));
            this.lblTrabajador.AppearanceItemCaption.Options.UseFont = true;
            this.lblTrabajador.Control = this.sbTrabajador;
            this.lblTrabajador.Location = new System.Drawing.Point(0, 0);
            this.lblTrabajador.MaxSize = new System.Drawing.Size(297, 26);
            this.lblTrabajador.MinSize = new System.Drawing.Size(297, 26);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(297, 26);
            this.lblTrabajador.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.lblTrabajador, "lblTrabajador");
            this.lblTrabajador.TextSize = new System.Drawing.Size(96, 16);
            // 
            // lblComprobante
            // 
            this.lblComprobante.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblComprobante.AppearanceItemCaption.Font")));
            this.lblComprobante.AppearanceItemCaption.Options.UseFont = true;
            this.lblComprobante.Control = this.cbComprobante;
            this.lblComprobante.Location = new System.Drawing.Point(0, 52);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(329, 25);
            resources.ApplyResources(this.lblComprobante, "lblComprobante");
            this.lblComprobante.TextSize = new System.Drawing.Size(96, 16);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblProveedor.AppearanceItemCaption.Font")));
            this.lblProveedor.AppearanceItemCaption.Options.UseFont = true;
            this.lblProveedor.Control = this.sbProveedor;
            this.lblProveedor.Location = new System.Drawing.Point(0, 26);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(297, 26);
            resources.ApplyResources(this.lblProveedor, "lblProveedor");
            this.lblProveedor.TextSize = new System.Drawing.Size(96, 16);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblFechaIngreso.AppearanceItemCaption.Font")));
            this.lblFechaIngreso.AppearanceItemCaption.Options.UseFont = true;
            this.lblFechaIngreso.Control = this.dtFechaIngreso;
            this.lblFechaIngreso.Location = new System.Drawing.Point(316, 26);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(210, 26);
            resources.ApplyResources(this.lblFechaIngreso, "lblFechaIngreso");
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
            this.lblSerie.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblSerie.AppearanceItemCaption.Font")));
            this.lblSerie.AppearanceItemCaption.Options.UseFont = true;
            this.lblSerie.Control = this.txtSerie;
            this.lblSerie.Location = new System.Drawing.Point(329, 52);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(147, 25);
            resources.ApplyResources(this.lblSerie, "lblSerie");
            this.lblSerie.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblSerie.TextSize = new System.Drawing.Size(38, 16);
            this.lblSerie.TextToControlDistance = 5;
            // 
            // lblIGV
            // 
            this.lblIGV.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblIGV.AppearanceItemCaption.Font")));
            this.lblIGV.AppearanceItemCaption.Options.UseFont = true;
            this.lblIGV.Control = this.txtIGV;
            this.lblIGV.Location = new System.Drawing.Point(547, 26);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(203, 26);
            resources.ApplyResources(this.lblIGV, "lblIGV");
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
            this.lblidTrabajador.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("lblidTrabajador.AppearanceItemCaption.Font")));
            this.lblidTrabajador.AppearanceItemCaption.Options.UseFont = true;
            this.lblidTrabajador.Control = this.txtidIngresos;
            this.lblidTrabajador.Location = new System.Drawing.Point(297, 0);
            this.lblidTrabajador.Name = "lblidTrabajador";
            this.lblidTrabajador.Size = new System.Drawing.Size(550, 26);
            resources.ApplyResources(this.lblidTrabajador, "lblidTrabajador");
            this.lblidTrabajador.TextSize = new System.Drawing.Size(96, 16);
            this.lblidTrabajador.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnCancelar;
            this.layoutControlItem12.Location = new System.Drawing.Point(271, 326);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(104, 40);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(104, 40);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(375, 326);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(472, 40);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(897, 429);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.groupBox1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(877, 409);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloIngresos
            // 
            resources.ApplyResources(this.lblTituloIngresos, "lblTituloIngresos");
            this.lblTituloIngresos.ForeColor = System.Drawing.Color.Blue;
            this.lblTituloIngresos.Name = "lblTituloIngresos";
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem14,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem6,
            this.emptySpaceItem13,
            this.layoutControlItem16});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(935, 554);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.tabControl1;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(915, 465);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(367, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(521, 59);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblTituloIngresos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(263, 59);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pictureBox1;
            this.layoutControlItem2.Location = new System.Drawing.Point(263, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 59);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 59);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(915, 10);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(888, 26);
            this.emptySpaceItem13.MaxSize = new System.Drawing.Size(27, 33);
            this.emptySpaceItem13.MinSize = new System.Drawing.Size(27, 33);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(27, 33);
            this.emptySpaceItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.btnSalir;
            this.layoutControlItem16.Location = new System.Drawing.Point(888, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(27, 26);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // btnAgregar1
            // 
            resources.ApplyResources(this.btnAgregar1, "btnAgregar1");
            this.btnAgregar1.Name = "btnAgregar1";
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // textEdit1
            // 
            resources.ApplyResources(this.textEdit1, "textEdit1");
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = resources.GetString("textEdit1.Properties.Mask.EditMask");
            this.textEdit1.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("textEdit1.Properties.Mask.MaskType")));
            this.textEdit1.StyleController = this.layoutControl5;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.textEdit1;
            this.layoutControlItem17.Location = new System.Drawing.Point(438, 24);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(185, 26);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(128, 13);
            // 
            // frm_Ingresos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Ingresos";
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkDetalleIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private DevExpress.XtraLayout.LayoutControlItem lblPrecioCompra;
        private DevExpress.XtraLayout.LayoutControlItem lblPrecioVenta;
        private DevExpress.XtraEditors.SearchLookUpEdit sbProveedor;
        private DevExpress.Xpo.XPCollection xpCollectionProveedor;
        private DevExpress.Xpo.UnitOfWork unitOfWorkIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.GridControl gridControlDetalleIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView dataListadoDetalle;
        private DevExpress.Xpo.XPCollection xpCollectionArticulos;
        private DevExpress.Xpo.UnitOfWork unitOfWorkDetalleIngreso;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
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
        private DevExpress.Xpo.XPCollection xpCollectionDetalleIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn ColArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Compra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Venta;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn ColPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colUDM;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraEditors.SimpleButton btnAgregar1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
    }
}