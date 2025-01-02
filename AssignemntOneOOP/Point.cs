using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignemntOneOOP
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double _x,double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public double Calcdistance( Point p)
        {
            double partOne = p.x-this.x;
            double partTwo = p.y - this.y;

            double result = Math.Pow(partOne, 2) + Math.Pow(partTwo, 2);



            return Math.Sqrt(result);


        }

    }
}
