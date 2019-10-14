using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotepadSharpBusinessLogic;

namespace NotepadSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            FileManager fileManager = new FileManager();
            Presenter presenter = new Presenter(fileManager, mainForm);

            Application.Run(mainForm);
        }
    }
}
