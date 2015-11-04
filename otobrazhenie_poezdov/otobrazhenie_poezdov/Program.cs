using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobrazhenie_poezdov
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            MainForm m;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            switch (arg.Length)
            {
                case 0: m = new MainForm (); break;
                case 1: m = new MainForm(Convert.ToInt32(arg[0])); break;
                case 2: m = new MainForm(Convert.ToInt32(arg[0]), Convert.ToInt32(arg[1])); break;
                case 3: m = new MainForm (Convert.ToInt32(arg[0]), Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2])); break;
                case 4: m = new MainForm(Convert.ToInt32(arg[0]), Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3])); break;
                default: m = m = new MainForm(); break;


            }

            Application.Run(new MainForm());
        }
    }
}
