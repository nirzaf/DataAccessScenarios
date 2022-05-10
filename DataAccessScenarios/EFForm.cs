using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataAccessScenarios {
  public partial class EFForm : Form {
    public EFForm( ) {
      InitializeComponent( );
    }

    private void EFForm_Load(object sender, EventArgs e) {
      var context = new EventsDBEntities1();
      context.Customers.Load();
      bindingSource.DataSource = context.Customers.Local;
    }
  }
}
