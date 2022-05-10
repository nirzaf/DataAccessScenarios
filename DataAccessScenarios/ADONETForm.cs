using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataAccessScenarios {
  public partial class ADONETForm : Form {
    public ADONETForm( ) {
      InitializeComponent( );
    }

    private void ADONETForm_Load(object sender, EventArgs e) {
      customerTableAdapter.Fill(dataSet.Customer);
      eventTableAdapter.Fill(dataSet.Event);
      capacityRequirementTableAdapter.Fill(dataSet.CapacityRequirement);
      roomBookingTableAdapter.Fill(dataSet.RoomBooking);
    }
  }
}
