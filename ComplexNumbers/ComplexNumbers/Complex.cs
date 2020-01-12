using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbers
{
    public class Complex
    {
        private long materialPart;
        public long MaterialPart
        {
            get { return materialPart; }
            set { materialPart = value; }
        }

        private long floatPart;
        public long FloatPart
        {
            get { return floatPart; }
            set { floatPart = value; }
        }
        public Complex(long materialPart,  long floatPart)
        {
            MaterialPart = materialPart;
            FloatPart = floatPart;
        }

        public Complex Plus(Complex numb)
        {
            Complex result = new Complex(this.materialPart, this.floatPart);
            result.materialPart += numb.materialPart;
            result.floatPart += numb.floatPart;

            return result;
        }
        public Complex Minus(Complex numb)
        {
            Complex result = new Complex(this.materialPart, this.floatPart);
            result.materialPart -= numb.materialPart;
            result.floatPart -= numb.floatPart;

            return result;
        }



    }
}
