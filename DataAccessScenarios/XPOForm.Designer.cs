namespace DataAccessScenarios {
  partial class XPOForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose( );
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( ) {
      this.components = new System.ComponentModel.Container();
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.xpCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl1
      // 
      this.gridControl1.DataSource = this.xpCollection;
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.gridControl1.Location = new System.Drawing.Point(0, 0);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.ShowOnlyPredefinedDetails = true;
      this.gridControl1.Size = new System.Drawing.Size(1298, 689);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // xpCollection
      // 
      this.xpCollection.ObjectType = typeof(EventsDB.Customer);
      this.xpCollection.Session = this.unitOfWork1;
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colName,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
      this.gridView1.DetailHeight = 646;
      this.gridView1.FixedLineWidth = 4;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      // 
      // colOid
      // 
      this.colOid.FieldName = "Oid";
      this.colOid.MinWidth = 37;
      this.colOid.Name = "colOid";
      this.colOid.Visible = true;
      this.colOid.VisibleIndex = 0;
      this.colOid.Width = 137;
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.MinWidth = 37;
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 1;
      this.colName.Width = 137;
      // 
      // gridColumn1
      // 
      this.gridColumn1.FieldName = "InvoiceContact!";
      this.gridColumn1.MinWidth = 37;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 2;
      this.gridColumn1.Width = 137;
      // 
      // gridColumn2
      // 
      this.gridColumn2.FieldName = "InvoiceContact!Key";
      this.gridColumn2.MinWidth = 37;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 3;
      this.gridColumn2.Width = 137;
      // 
      // gridColumn3
      // 
      this.gridColumn3.FieldName = "InvoiceAddress!";
      this.gridColumn3.MinWidth = 37;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 4;
      this.gridColumn3.Width = 137;
      // 
      // gridColumn4
      // 
      this.gridColumn4.FieldName = "InvoiceAddress!Key";
      this.gridColumn4.MinWidth = 37;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 5;
      this.gridColumn4.Width = 137;
      // 
      // XPOForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1298, 689);
      this.Controls.Add(this.gridControl1);
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "XPOForm";
      this.Text = "XPO";
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.Xpo.XPCollection xpCollection;
    private DevExpress.XtraGrid.Columns.GridColumn colOid;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    private DevExpress.Xpo.UnitOfWork unitOfWork1;
  }
}