using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otobrazhenie_poezdov
{
    class Model
    {
        int sizeField;
        int amountTrains;
        int amountStations;
        int speed;

        public Trains trains;

        public Model(int sizeField, int amountTrains, int amountStations, int speed)
        {
            this.sizeField = sizeField;
            this.amountTrains = amountTrains;
            this.amountStations = amountStations;
            this.speed = speed;

            trains = new Trains();

        }

        public void Play()
        {
            while(true)
            {
                trains.Run();
            }
        }
    }
}
