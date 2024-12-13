using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class MyComplex: IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        double re, im;
        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public MyComplex(string complex)
        {
            try
            {
                string[] data = complex.Trim().Split('+');
                re = double.Parse(data[0]);
                im = double.Parse(data[1].Replace("i", "").Trim());
            }
            catch
            {
                throw new ArgumentException("Wrong input");
            }
        }
        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(this.re + that.re, this.im + that.im);
        }
    }
}
