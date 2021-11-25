
namespace SisVentaDevExpress.Formularios
{
    partial class frm_Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Articulos));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionArticulos = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWorkArticulos = new DevExpress.Xpo.UnitOfWork(this.components);
            this.dataListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombrePresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnEliminar1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoVenta = new DevExpress.XtraEditors.TextEdit();
            this.sbxPresentacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionPresentacion = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbxCategoria = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollectionCategoria = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardarCambios = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblCodigo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblPresentacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblCodigoDeVenta = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCategoria = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDescripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_Articulos = new System.Windows.Forms.Label();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbxPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbxCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCodigoDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tabControl1);
            this.layoutControl1.Controls.Add(this.lbl_Articulos);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(730, 403);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.layoutControl2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.lblTotal);
            this.layoutControl2.Controls.Add(this.gridSplitContainer1);
            this.layoutControl2.Controls.Add(this.btnEliminar1);
            this.layoutControl2.Controls.Add(this.btnImprimir1);
            this.layoutControl2.Controls.Add(this.btnAgregar);
            this.layoutControl2.Controls.Add(this.btnEditar1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(692, 301);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // lblTotal
            // 
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(12, 269);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(332, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label2";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl2;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 52);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl2);
            this.gridSplitContainer1.Size = new System.Drawing.Size(668, 213);
            this.gridSplitContainer1.TabIndex = 5;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.xpCollectionArticulos;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.dataListado;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl2.Size = new System.Drawing.Size(668, 213);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataListado});
            this.gridControl2.DoubleClick += new System.EventHandler(this.btnEditar1_Click);
            // 
            // xpCollectionArticulos
            // 
            this.xpCollectionArticulos.ObjectType = typeof(SisVentaDevExpress.Ventas.Articulo);
            this.xpCollectionArticulos.Session = this.unitOfWorkArticulos;
            // 
            // dataListado
            // 
            this.dataListado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataListado.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.dataListado.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.dataListado.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dataListado.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
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
            this.dataListado.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colCodigo,
            this.colNombre,
            this.colDescripcion,
            this.colNombreCategoria,
            this.colNombrePresentacion});
            this.dataListado.GridControl = this.gridControl2;
            this.dataListado.GroupCount = 1;
            this.dataListado.Name = "dataListado";
            this.dataListado.OptionsBehavior.Editable = false;
            this.dataListado.OptionsFind.AlwaysVisible = true;
            this.dataListado.OptionsSelection.MultiSelect = true;
            this.dataListado.OptionsView.EnableAppearanceEvenRow = true;
            this.dataListado.OptionsView.EnableAppearanceOddRow = true;
            this.dataListado.OptionsView.ShowGroupPanel = false;
            this.dataListado.PaintStyleName = "Flat";
            this.dataListado.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNombreCategoria, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigo.AppearanceCell.Options.UseFont = true;
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigo.AppearanceHeader.Options.UseFont = true;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
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
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescripcion.AppearanceCell.Options.UseFont = true;
            this.colDescripcion.AppearanceCell.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescripcion.AppearanceHeader.Options.UseFont = true;
            this.colDescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // colNombreCategoria
            // 
            this.colNombreCategoria.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombreCategoria.AppearanceCell.Options.UseFont = true;
            this.colNombreCategoria.AppearanceCell.Options.UseTextOptions = true;
            this.colNombreCategoria.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombreCategoria.AppearanceHeader.Options.UseFont = true;
            this.colNombreCategoria.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombreCategoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombreCategoria.Caption = "Categoria";
            this.colNombreCategoria.FieldName = "IdCategoria.Nombre";
            this.colNombreCategoria.Name = "colNombreCategoria";
            this.colNombreCategoria.Visible = true;
            this.colNombreCategoria.VisibleIndex = 3;
            // 
            // colNombrePresentacion
            // 
            this.colNombrePresentacion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombrePresentacion.AppearanceCell.Options.UseFont = true;
            this.colNombrePresentacion.AppearanceCell.Options.UseTextOptions = true;
            this.colNombrePresentacion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombrePresentacion.AppearanceHeader.Options.UseFont = true;
            this.colNombrePresentacion.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombrePresentacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombrePresentacion.Caption = "Presentacion";
            this.colNombrePresentacion.FieldName = "IdPresentacion.Nombre";
            this.colNombrePresentacion.Name = "colNombrePresentacion";
            this.colNombrePresentacion.Visible = true;
            this.colNombrePresentacion.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar1.Appearance.Options.UseFont = true;
            this.btnEliminar1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar1.ImageOptions.Image")));
            this.btnEliminar1.Location = new System.Drawing.Point(295, 12);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(102, 36);
            this.btnEliminar1.StyleController = this.layoutControl2;
            this.btnEliminar1.TabIndex = 4;
            this.btnEliminar1.Text = "E&liminar";
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir1.Appearance.Options.UseFont = true;
            this.btnImprimir1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir1.ImageOptions.Image")));
            this.btnImprimir1.Location = new System.Drawing.Point(196, 12);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(95, 36);
            this.btnImprimir1.StyleController = this.layoutControl2;
            this.btnImprimir1.TabIndex = 3;
            this.btnImprimir1.Text = "Imprimir";
            this.btnImprimir1.Click += new System.EventHandler(this.btnImprimir1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnEditar1
            // 
            this.btnEditar1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar1.Appearance.Options.UseFont = true;
            this.btnEditar1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar1.ImageOptions.Image")));
            this.btnEditar1.Location = new System.Drawing.Point(112, 12);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(80, 36);
            this.btnEditar1.StyleController = this.layoutControl2;
            this.btnEditar1.TabIndex = 2;
            this.btnEditar1.Text = "Editar";
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.BackgroundImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup1.BackgroundImageOptions.Image")));
            this.layoutControlGroup1.BackgroundImageOptions.Visible = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem3,
            this.layoutControlItem13,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(692, 301);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAgregar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(100, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(100, 40);
            this.layoutControlItem3.Name = "layoutControlItem2";
            this.layoutControlItem3.Size = new System.Drawing.Size(100, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnEditar1;
            this.layoutControlItem4.Location = new System.Drawing.Point(100, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(84, 40);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(84, 40);
            this.layoutControlItem4.Name = "layoutControlItem3";
            this.layoutControlItem4.Size = new System.Drawing.Size(84, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnImprimir1;
            this.layoutControlItem5.Location = new System.Drawing.Point(184, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(99, 40);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(99, 40);
            this.layoutControlItem5.Name = "layoutControlItem4";
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEliminar1;
            this.layoutControlItem6.Location = new System.Drawing.Point(283, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(106, 40);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(106, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(106, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridSplitContainer1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(672, 217);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(336, 257);
            this.emptySpaceItem3.Name = "emptySpaceItem1";
            this.emptySpaceItem3.Size = new System.Drawing.Size(336, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.lblTotal;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 257);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(336, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(336, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(336, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(389, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(283, 40);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.layoutControl3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(698, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.groupBox1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(3, 3);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(597, 167, 650, 400);
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(692, 301);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.layoutControl4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulos";
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.txtDescripcion);
            this.layoutControl4.Controls.Add(this.txtNombre);
            this.layoutControl4.Controls.Add(this.txtCodigoVenta);
            this.layoutControl4.Controls.Add(this.sbxPresentacion);
            this.layoutControl4.Controls.Add(this.sbxCategoria);
            this.layoutControl4.Controls.Add(this.txtCodigo);
            this.layoutControl4.Controls.Add(this.btnGuardarCambios);
            this.layoutControl4.Controls.Add(this.btnGuardar);
            this.layoutControl4.Controls.Add(this.btnCancelar);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(3, 16);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(640, 124, 650, 400);
            this.layoutControl4.Root = this.layoutControlGroup3;
            this.layoutControl4.Size = new System.Drawing.Size(662, 258);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(251, 94);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtDescripcion.Size = new System.Drawing.Size(399, 24);
            this.txtDescripcion.StyleController = this.layoutControl4;
            this.txtDescripcion.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(243, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtNombre.Size = new System.Drawing.Size(182, 24);
            this.txtNombre.StyleController = this.layoutControl4;
            this.txtNombre.TabIndex = 16;
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Location = new System.Drawing.Point(244, 38);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoVenta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVenta.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigoVenta.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtCodigoVenta.Size = new System.Drawing.Size(185, 24);
            this.txtCodigoVenta.StyleController = this.layoutControl4;
            this.txtCodigoVenta.TabIndex = 15;
            // 
            // sbxPresentacion
            // 
            this.sbxPresentacion.Location = new System.Drawing.Point(510, 66);
            this.sbxPresentacion.Name = "sbxPresentacion";
            this.sbxPresentacion.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sbxPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbxPresentacion.Properties.Appearance.Options.UseBackColor = true;
            this.sbxPresentacion.Properties.Appearance.Options.UseFont = true;
            this.sbxPresentacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbxPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbxPresentacion.Properties.DataSource = this.xpCollectionPresentacion;
            this.sbxPresentacion.Properties.DisplayMember = "Nombre";
            this.sbxPresentacion.Properties.PopupView = this.searchLookUpEdit2View;
            this.sbxPresentacion.Properties.ValueMember = "IdPresentacion";
            this.sbxPresentacion.Size = new System.Drawing.Size(140, 24);
            this.sbxPresentacion.StyleController = this.layoutControl4;
            this.sbxPresentacion.TabIndex = 14;
            // 
            // xpCollectionPresentacion
            // 
            this.xpCollectionPresentacion.ObjectType = typeof(SisVentaDevExpress.Ventas.Presentacion);
            this.xpCollectionPresentacion.Session = this.unitOfWorkArticulos;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPresentacion});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colPresentacion
            // 
            this.colPresentacion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPresentacion.AppearanceCell.Options.UseFont = true;
            this.colPresentacion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPresentacion.AppearanceHeader.Options.UseFont = true;
            this.colPresentacion.AppearanceHeader.Options.UseTextOptions = true;
            this.colPresentacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPresentacion.Caption = "Presentacion";
            this.colPresentacion.FieldName = "Nombre";
            this.colPresentacion.Name = "colPresentacion";
            this.colPresentacion.Visible = true;
            this.colPresentacion.VisibleIndex = 0;
            // 
            // sbxCategoria
            // 
            this.sbxCategoria.Location = new System.Drawing.Point(504, 38);
            this.sbxCategoria.Name = "sbxCategoria";
            this.sbxCategoria.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sbxCategoria.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbxCategoria.Properties.Appearance.Options.UseBackColor = true;
            this.sbxCategoria.Properties.Appearance.Options.UseFont = true;
            this.sbxCategoria.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbxCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbxCategoria.Properties.DataSource = this.xpCollectionCategoria;
            this.sbxCategoria.Properties.DisplayMember = "Nombre";
            this.sbxCategoria.Properties.PopupView = this.searchLookUpEdit1View;
            this.sbxCategoria.Properties.ValueMember = "IdCategoria";
            this.sbxCategoria.Size = new System.Drawing.Size(146, 24);
            this.sbxCategoria.StyleController = this.layoutControl4;
            this.sbxCategoria.TabIndex = 13;
            this.sbxCategoria.EditValueChanged += new System.EventHandler(this.sbxCategoria_EditValueChanged);
            // 
            // xpCollectionCategoria
            // 
            this.xpCollectionCategoria.ObjectType = typeof(SisVentaDevExpress.Ventas.Categoria);
            this.xpCollectionCategoria.Session = this.unitOfWorkArticulos;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoria});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCategoria
            // 
            this.colCategoria.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria.AppearanceCell.Options.UseFont = true;
            this.colCategoria.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria.AppearanceHeader.Options.UseFont = true;
            this.colCategoria.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoria.Caption = "Categoria";
            this.colCategoria.FieldName = "Nombre";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.Location = new System.Drawing.Point(238, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(412, 22);
            this.txtCodigo.StyleController = this.layoutControl4;
            this.txtCodigo.TabIndex = 4;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGuardarCambios.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Appearance.Options.UseBackColor = true;
            this.btnGuardarCambios.Appearance.Options.UseFont = true;
            this.btnGuardarCambios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.ImageOptions.Image")));
            this.btnGuardarCambios.Location = new System.Drawing.Point(12, 52);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(151, 36);
            this.btnGuardarCambios.StyleController = this.layoutControl4;
            this.btnGuardarCambios.TabIndex = 11;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(12, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 36);
            this.btnGuardar.StyleController = this.layoutControl4;
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(12, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 36);
            this.btnCancelar.StyleController = this.layoutControl4;
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblCodigo,
            this.lblPresentacion,
            this.emptySpaceItem9,
            this.lblCodigoDeVenta,
            this.lblNombre,
            this.lblCategoria,
            this.lblDescripcion,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.emptySpaceItem10,
            this.emptySpaceItem1,
            this.emptySpaceItem7});
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(662, 258);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.AppearanceItemCaption.Options.UseFont = true;
            this.lblCodigo.Control = this.txtCodigo;
            this.lblCodigo.Location = new System.Drawing.Point(155, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(487, 26);
            this.lblCodigo.Text = "Codigo:";
            this.lblCodigo.TextSize = new System.Drawing.Size(68, 16);
            this.lblCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.AppearanceItemCaption.Options.UseFont = true;
            this.lblPresentacion.Control = this.sbxPresentacion;
            this.lblPresentacion.Location = new System.Drawing.Point(427, 54);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(215, 28);
            this.lblPresentacion.Text = "U/M:";
            this.lblPresentacion.TextSize = new System.Drawing.Size(68, 16);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(417, 54);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblCodigoDeVenta
            // 
            this.lblCodigoDeVenta.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeVenta.AppearanceItemCaption.Options.UseFont = true;
            this.lblCodigoDeVenta.Control = this.txtCodigoVenta;
            this.lblCodigoDeVenta.Location = new System.Drawing.Point(155, 26);
            this.lblCodigoDeVenta.Name = "lblCodigoDeVenta";
            this.lblCodigoDeVenta.Size = new System.Drawing.Size(266, 28);
            this.lblCodigoDeVenta.Text = "Cod Venta:";
            this.lblCodigoDeVenta.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblCodigoDeVenta.TextSize = new System.Drawing.Size(72, 16);
            this.lblCodigoDeVenta.TextToControlDistance = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.AppearanceItemCaption.Options.UseFont = true;
            this.lblNombre.Control = this.txtNombre;
            this.lblNombre.Location = new System.Drawing.Point(172, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(245, 28);
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblNombre.TextSize = new System.Drawing.Size(54, 16);
            this.lblNombre.TextToControlDistance = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.AppearanceItemCaption.Options.UseFont = true;
            this.lblCategoria.Control = this.sbxCategoria;
            this.lblCategoria.Location = new System.Drawing.Point(421, 26);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(221, 28);
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextSize = new System.Drawing.Size(68, 16);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.AppearanceItemCaption.Options.UseFont = true;
            this.lblDescripcion.Control = this.txtDescripcion;
            this.lblDescripcion.Location = new System.Drawing.Point(155, 82);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(487, 38);
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblDescripcion.TextSize = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TextToControlDistance = 5;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnGuardar;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(109, 40);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(155, 40);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "layoutControlItem9";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnGuardarCambios;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(155, 40);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(155, 40);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnCancelar;
            this.layoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(102, 40);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(155, 40);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "layoutControlItem9";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(155, 118);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(155, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(487, 118);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(155, 54);
            this.emptySpaceItem7.Name = "emptySpaceItem2";
            this.emptySpaceItem7.Size = new System.Drawing.Size(17, 28);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.BackgroundImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup2.BackgroundImageOptions.Image")));
            this.layoutControlGroup2.BackgroundImageOptions.Visible = true;
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(692, 301);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.groupBox1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(672, 281);
            this.layoutControlItem8.Text = "GrupBoxCategoria";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // lbl_Articulos
            // 
            this.lbl_Articulos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Articulos.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Articulos.Location = new System.Drawing.Point(12, 12);
            this.lbl_Articulos.Name = "lbl_Articulos";
            this.lbl_Articulos.Size = new System.Drawing.Size(153, 42);
            this.lbl_Articulos.TabIndex = 4;
            this.lbl_Articulos.Text = "Articulos";
            this.lbl_Articulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Root
            // 
            this.Root.BackgroundImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Root.BackgroundImageOptions.Image")));
            this.Root.BackgroundImageOptions.Visible = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem12});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(730, 403);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(157, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(553, 46);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lbl_Articulos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(157, 46);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.tabControl1;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(710, 337);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // frm_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 403);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Articulos";
            this.Text = "frm_Arliculos";
            this.Load += new System.EventHandler(this.frm_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbxPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbxCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCodigoDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Label lbl_Articulos;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.Label lblTotal;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView dataListado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar1;
        private DevExpress.XtraEditors.SimpleButton btnImprimir1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnEditar1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCambios;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem lblCodigo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.ToolTip ttMensaje;
        private DevExpress.Xpo.UnitOfWork unitOfWorkArticulos;
        private DevExpress.Xpo.XPCollection xpCollectionArticulos;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colNombrePresentacion;
        private DevExpress.Xpo.XPCollection xpCollectionCategoria;
        private DevExpress.Xpo.XPCollection xpCollectionPresentacion;
        private DevExpress.XtraEditors.SearchLookUpEdit sbxPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit sbxCategoria;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem lblCategoria;
        private DevExpress.XtraLayout.LayoutControlItem lblPresentacion;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.TextEdit txtCodigoVenta;
        private DevExpress.XtraLayout.LayoutControlItem lblCodigoDeVenta;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraLayout.LayoutControlItem lblNombre;
        private DevExpress.XtraLayout.LayoutControlItem lblDescripcion;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}