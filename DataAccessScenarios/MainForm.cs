// Copyright (C) 2009-2014 Oliver Sturm <oliver@oliversturm.com> All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataAccessScenarios {
  public partial class MainForm : Form {
    public MainForm( ) {
      InitializeComponent( );
    }

    private void btADO_Click(object sender, EventArgs e) {
      new ADONETForm().Show( );
    }

    private void btEF_Click(object sender, EventArgs e) {
      new EFForm().Show( );
    }

    private void btXPO_Click(object sender, EventArgs e) {
      new XPOForm().Show( );
    }
  }
}
