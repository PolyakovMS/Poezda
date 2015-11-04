using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace otobrazhenie_poezdov
{
    class Trains
    {
        public Image img = Properties.Resources.Train;

        public int x, y;

        public void Run()
        {
            x = ++y;

        }

    }
}
