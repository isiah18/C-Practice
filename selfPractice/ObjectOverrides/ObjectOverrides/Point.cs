using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Point other = (Point) obj;
            return (this.x == other.x) && (this.y == other.y);
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", x, y);
        }
    }
}
