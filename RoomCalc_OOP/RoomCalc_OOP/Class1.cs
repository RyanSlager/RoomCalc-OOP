using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalc_OOP
{
    class Room
    {
        private double width;
        public double length;

        public Room(double w, double l)
        {
            this.width = w;
            this.length = l;
        }

        public double Area()
        {
            return width * length;
        }

        public double Perimeter()
        {
            return (2 * width) + (2 * length);
        }
    }
}
