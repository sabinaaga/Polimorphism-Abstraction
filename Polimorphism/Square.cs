using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Square : Figure
    {
        public Square(int side)
        {
           this.side=side ;

        }
        private int _side;

        public int side
        {
            get { return _side; }
            set
            {
                if (_side >= 0)
                {


                    _side = value;
                }
            }
        }

        public override int CalcArea()
        {
            return side * side; 
        }
    }
}
