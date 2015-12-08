using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarCsharp
{
    class Point
    {
        int y;
        int x;
        public int Y { get; set; }
        public int X { get; set; }

        public Point()
        {
            Y = 4;
            X = 5;
        }
        public Point(int x, int y)
        {
            Y = y;
            X = x;
        }

        public int GetX()
        {
            return x;
        }
        public void SetX(int x)
        {
            if (y < 50 && y > 50)
                Console.WriteLine("Något gick fel");
            this.x = x;
        }

        public int GetY()
        {
            return y;
        }
        public void SetY(int y)
        {
            if (y < 50 && y > 50)
                Console.WriteLine("Något gick fel");
            this.y = y;
        }
    }
}
