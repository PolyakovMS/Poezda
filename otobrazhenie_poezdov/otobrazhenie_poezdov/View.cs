using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


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

        void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.trains.img, new Point(model.trains.x, model.trains.y));
            if (model.status != Status.starting)
                return;



            Thread.Sleep(model.speed);
            Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);

        }

        /*private void View_Paint(object sender, PaintEventArgs e)
        {
            //Graphics gr = CreateGraphics();
            
        }*/
    }
}
