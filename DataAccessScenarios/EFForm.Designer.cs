namespace DataAccessScenarios {
  partial class EFForm {
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
      this.bindingSource = new System.Windows.Forms.BindingSource();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colOID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colOptimisticLockField = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCustomerContact = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCustomerAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCustomerContact1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colEvent = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl1
      // 
      this.gridControl1.DataSource = this.bindingSource;
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.Location = new System.Drawing.Point(0, 0);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.ShowOnlyPredefinedDetails = true;
      this.gridControl1.Size = new System.Drawing.Size(658, 373);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // bindingSource
      // 
      this.bindingSource.DataSource = typeof(DataAccessScenarios.Customer);
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOID,
            this.colName,
            this.colOptimisticLockField,
            this.colCustomerAddress,
            this.colCustomerContact,
            this.colCustomerAddress1,
            this.colCustomerContact1,
            this.colEvent});
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
      // colOptimisticLockField
      // 
      this.colOptimisticLockField.FieldName = "OptimisticLockField";
      this.colOptimisticLockField.Name = "colOptimisticLockField";
      this.colOptimisticLockField.Visible = true;
      this.colOptimisticLockField.VisibleIndex = 2;
      // 
      // colCustomerAddress
      // 
      this.colCustomerAddress.FieldName = "CustomerAddress";
      this.colCustomerAddress.Name = "colCustomerAddress";
      this.colCustomerAddress.Visible = true;
      this.colCustomerAddress.VisibleIndex = 3;
      // 
      // colCustomerContact
      // 
      this.colCustomerContact.FieldName = "CustomerContact";
      this.colCustomerContact.Name = "colCustomerContact";
      this.colCustomerContact.Visible = true;
      this.colCustomerContact.VisibleIndex = 4;
      // 
      // colCustomerAddress1
      // 
      this.colCustomerAddress1.FieldName = "CustomerAddress1";
      this.colCustomerAddress1.Name = "colCustomerAddress1";
      this.colCustomerAddress1.Visible = true;
      this.colCustomerAddress1.VisibleIndex = 5;
      // 
      // colCustomerContact1
      // 
      this.colCustomerContact1.FieldName = "CustomerContact1";
      this.colCustomerContact1.Name = "colCustomerContact1";
      this.colCustomerContact1.Visible = true;
      this.colCustomerContact1.VisibleIndex = 6;
      // 
      // colEvent
      // 
      this.colEvent.FieldName = "Event";
      this.colEvent.Name = "colEvent";
      this.colEvent.Visible = true;
      this.colEvent.VisibleIndex = 7;
      // 
      // EFForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(658, 373);
      this.Controls.Add(this.gridControl1);
      this.Name = "EFForm";
      this.Text = "Entity Framework";
      this.Load += new System.EventHandler(this.EFForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private System.Windows.Forms.BindingSource bindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colOID;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colOptimisticLockField;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerContact;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress1;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerContact1;
    private DevExpress.XtraGrid.Columns.GridColumn colEvent;
  }
}