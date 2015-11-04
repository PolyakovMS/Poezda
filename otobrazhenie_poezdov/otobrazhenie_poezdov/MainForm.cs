using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace otobrazhenie_poezdov
{
    public partial class MainForm : Form
    {
        View view;
        Model model;

        Thread modelPlay;



        public MainForm() : this(300) { }
        public MainForm(int sizeField) : this(sizeField, 5) { }
        public MainForm(int sizeField, int amountTrains) : this (sizeField, amountTrains, 5) { }
        public MainForm(int sizeField, int amountTrains, int amountStations) : this(sizeField, amountTrains, amountStations, 40) { }
        public MainForm (int sizeField, int amountTrains, int amountStations, int speed)
        {
            InitializeComponent();

            model = new Model(sizeField, amountTrains, amountStations, speed);


            view = new View(model);
            this.Controls.Add(view);


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void StartStop_btn_Click(object sender, EventArgs e)
        {
            modelPlay = new Thread(model.Play);
            modelPlay.Start();


        }
    }
}
