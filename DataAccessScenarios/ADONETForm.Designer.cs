namespace DataAccessScenarios {
  partial class ADONETForm {
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
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.dataSet = new DataAccessScenarios.DataSet1();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colOID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colInvoiceContact = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colInvoiceAddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colOptimisticLockField = new DevExpress.XtraGrid.Columns.GridColumn();
      this.customerTableAdapter = new DataAccessScenarios.DataSet1TableAdapters.CustomerTableAdapter();
      this.eventTableAdapter = new DataAccessScenarios.DataSet1TableAdapters.EventTableAdapter();
      this.capacityRequirementTableAdapter = new DataAccessScenarios.DataSet1TableAdapters.CapacityRequirementTableAdapter();
      this.roomBookingTableAdapter = new DataAccessScenarios.DataSet1TableAdapters.RoomBookingTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl1
      // 
      this.gridControl1.DataMember = "Customer";
      this.gridControl1.DataSource = this.dataSet;
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.Location = new System.Drawing.Point(0, 0);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.ShowOnlyPredefinedDetails = true;
      this.gridControl1.Size = new System.Drawing.Size(700, 373);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // dataSet
      // 
      this.dataSet.DataSetName = "DataSet";
      this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOID,
            this.colName,
            this.colInvoiceContact,
            this.colInvoiceAddress,
            this.colOptimisticLockField});
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      // 
      // colOID
      // 
      this.colOID.FieldName = "OID";
      this.colOID.Name = "colOID";
      this.colOID.Visible = true;
      this.colOID.VisibleIndex = 0;
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 1;
      // 
      // colInvoiceContact
      // 
      this.colInvoiceContact.FieldName = "InvoiceContact";
      this.colInvoiceContact.Name = "colInvoiceContact";
      this.colInvoiceContact.Visible = true;
      this.colInvoiceContact.VisibleIndex = 2;
      // 
      // colInvoiceAddress
      // 
      this.colInvoiceAddress.FieldName = "InvoiceAddress";
      this.colInvoiceAddress.Name = "colInvoiceAddress";
      this.colInvoiceAddress.Visible = true;
      this.colInvoiceAddress.VisibleIndex = 3;
      // 
      // colOptimisticLockField
      // 
      this.colOptimisticLockField.FieldName = "OptimisticLockField";
      this.colOptimisticLockField.Name = "colOptimisticLockField";
      this.colOptimisticLockField.Visible = true;
      this.colOptimisticLockField.VisibleIndex = 4;
      // 
      // customerTableAdapter
      // 
      this.customerTableAdapter.ClearBeforeFill = true;
      // 
      // eventTableAdapter
      // 
      this.eventTableAdapter.ClearBeforeFill = true;
      // 
      // capacityRequirementTableAdapter
      // 
      this.capacityRequirementTableAdapter.ClearBeforeFill = true;
      // 
      // roomBookingTableAdapter
      // 
      this.roomBookingTableAdapter.ClearBeforeFill = true;
      // 
      // ADONETForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(700, 373);
      this.Controls.Add(this.gridControl1);
      this.Name = "ADONETForm";
      this.Text = "ADO.NET Dataset";
      this.Load += new System.EventHandler(this.ADONETForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DataSet1 dataSet;
    private DevExpress.XtraGrid.Columns.GridColumn colOID;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colInvoiceContact;
    private DevExpress.XtraGrid.Columns.GridColumn colInvoiceAddress;
    private DevExpress.XtraGrid.Columns.GridColumn colOptimisticLockField;
    private DataAccessScenarios.DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
    private DataAccessScenarios.DataSet1TableAdapters.EventTableAdapter eventTableAdapter;
    private DataAccessScenarios.DataSet1TableAdapters.CapacityRequirementTableAdapter capacityRequirementTableAdapter;
    private DataAccessScenarios.DataSet1TableAdapters.RoomBookingTableAdapter roomBookingTableAdapter;
  }
}