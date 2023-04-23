using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesaurus
{
    internal static class Program
    {
        /// <summary>
        /// Путь к файлу базы данных
        /// </summary>
        public const string databasePath = @"C:\Arslan\Study\4-course\8-semester\Final-qualifying-work\Database\Женская консультация.accdb";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Thesaurus());
        }
    }
}
