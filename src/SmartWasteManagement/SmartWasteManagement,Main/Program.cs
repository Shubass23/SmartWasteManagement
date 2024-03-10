using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartWasteManagement.Main.View;
using SmartWasteManagement.Main.Database;

namespace SmartWasteManagement.Main
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MongoDBHandler db_handler = new MongoDBHandler();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage(db_handler));
        }
    }
}
