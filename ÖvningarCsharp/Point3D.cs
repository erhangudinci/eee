using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarCsharp
{
    class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D()
        {
            X = 6;
            Y = 43;
            Z = 4;
        }
        public Point3D(int x, int y, int z) : base(x,y)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
