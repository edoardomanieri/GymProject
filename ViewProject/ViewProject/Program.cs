using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.View;

namespace ViewProject
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainPersistanceManager mpm = new MainPersistanceManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // if (!mpm.ThereIsASavedAccount())
                Application.Run(new MainForm());
           // else
             //   Application.Run(new MainFormAlreadyRegistered());
        }
    }
}
