using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarCsharp
{

    class Car
    {
        private string label;
        private int numberOfGears;
        private string color;
        private string carType;

        public int Label { get; set; }
        public int NumberOfGears { get; set; }
        public int Color { get; set; }
        public string Cartype
        {
            get { return carType; }
            set
            {
                var validCarType = value == "kupe" || value == "kombi";
                if (validCarType)
                {
                    carType = value;
                }
                else
                    Console.WriteLine("Något gick fel.");
            }
        }

        public void Drive()
        {
            Console.WriteLine("brum brum");
        }
    }
}
