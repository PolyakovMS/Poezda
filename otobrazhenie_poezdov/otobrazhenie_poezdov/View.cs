using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobrazhenie_poezdov
{
    partial class View : UserControl
    {
        Model model;

        public View(Model model)
        {
            InitializeComponent();

            this.model = model;
            
        }

        private void View_Paint(object sender, PaintEventArgs e)
        {
            //Graphics gr = CreateGraphics();
            e.Graphics.DrawImage(model.trains.img, new Point(model.trains.x, model.trains.y));
        }
    }
}
