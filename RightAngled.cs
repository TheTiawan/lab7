using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class RightAngled : Pair
    {
        //private int _first;
        //private int _second;

        public RightAngled(int first, int second) : base (first, second)
        {
            First = first;
            Second = second;
        }

        //public int First
        //{
        //    get { return _first; }
        //    set
        //    {
        //        if (value % 2 != 0) throw new ArgumentException("Число должно быть четным");
        //        _first = value;
        //    }
        //}
        //
        //public int Second
        //{
        //    get { return _second; }
        //    set
        //    {
        //        if (value % 2 != 0) throw new ArgumentException("Число должно быть четным");
        //        _second = value;
        //    }
        //}

        public double Hypotenuse(RightAngled cathets)
        {
            double gip = Math.Sqrt(cathets.First * 2 + cathets.Second * 2);
            return gip;
        }

        public double Square(RightAngled cathets, int third)
        {
            double p = (cathets.First + cathets.Second + third) / 2;
            double s = Math.Sqrt(p * (p - cathets.First) * (p - cathets.Second) * (p - third));
            return s;
        }


    }
}
