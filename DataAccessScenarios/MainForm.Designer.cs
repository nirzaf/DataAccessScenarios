namespace DataAccessScenarios {
  partial class MainForm {
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
      this.btADO = new System.Windows.Forms.Button();
      this.btEF = new System.Windows.Forms.Button();
      this.btXPO = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btADO
      // 
      this.btADO.Location = new System.Drawing.Point(12, 12);
      this.btADO.Name = "btADO";
      this.btADO.Size = new System.Drawing.Size(212, 23);
      this.btADO.TabIndex = 0;
      this.btADO.Text = "ADO.NET";
      this.btADO.UseVisualStyleBackColor = true;
      this.btADO.Click += new System.EventHandler(this.btADO_Click);
      // 
      // btEF
      // 
      this.btEF.Location = new System.Drawing.Point(12, 41);
      this.btEF.Name = "btEF";
      this.btEF.Size = new System.Drawing.Size(212, 23);
      this.btEF.TabIndex = 2;
      this.btEF.Text = "Entity Framework";
      this.btEF.UseVisualStyleBackColor = true;
      this.btEF.Click += new System.EventHandler(this.btEF_Click);
      // 
      // btXPO
      // 
      this.btXPO.Location = new System.Drawing.Point(12, 70);
      this.btXPO.Name = "btXPO";
      this.btXPO.Size = new System.Drawing.Size(212, 23);
      this.btXPO.TabIndex = 3;
      this.btXPO.Text = "XPO";
      this.btXPO.UseVisualStyleBackColor = true;
      this.btXPO.Click += new System.EventHandler(this.btXPO_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(239, 106);
      this.Controls.Add(this.btXPO);
      this.Controls.Add(this.btEF);
      this.Controls.Add(this.btADO);
      this.Name = "MainForm";
      this.Text = "Data Access Scenarios";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btADO;
    private System.Windows.Forms.Button btEF;
    private System.Windows.Forms.Button btXPO;
  }
}

