using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace otobrazhenie_poezdov
{
    class Model
    {
        int sizeField;
        int amountTrains;
        int amountStations;
        public int speed;

        public Status status;


        public Trains trains;

        public Model(int sizeField, int amountTrains, int amountStations, int speed)
        {
            this.sizeField = sizeField;
            this.amountTrains = amountTrains;
            this.amountStations = amountStations;
            this.speed = speed;

            trains = new Trains();

            status = Status.stoping; 

        }

        public void Play()
        {
            while(status == Status.starting)
            {
                Thread.Sleep(speed);
                trains.Run();
            }
        }
    }
}
