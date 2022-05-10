using EventsDB.Populate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataAccessScenarios {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main( ) {
      Application.EnableVisualStyles( );
      Application.SetCompatibleTextRenderingDefault(false);

      DemoDatabase.Populate();

      Application.Run(new MainForm( ));
    }
  }
}
