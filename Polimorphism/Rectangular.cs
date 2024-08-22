using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Rectangular : Figure
    {
        public Rectangular(int width, int length)
        {

            this.width = width;
            this.length = length;
            
        }
        private int _length;

        public int length
        {
            get { return _length; }

            set 
            {
                if (_length >= 0)
                {
                    _length = value;

                }
            }
        }

        private int _widthr;

        public int width
        {
            get { return _widthr; }

            set
            {
                if (_widthr >= 0)
                {
                    _widthr = value;
                }
            }

        }

        public override int CalcArea()
        {
            return width* length;
        }
    }
}