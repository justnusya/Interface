using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class MyComplex: IMyNumber<MyFrac>
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
        public MyComplex Substruct(MyComplex that)
        {
            return new MyComplex(this.re - that.re, this.im - that.im);
        }
        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(this.re * that.re - this.im*that.im, this.re * that.im + this.im *that.re);
        }
        public MyComplex Divide(MyComplex that)
        {
            double denomin = that.re * that.re + that.im * that.im;
            double real = (this.re * that.re + this.im * that.im) / denomin;
            double imag = (this.im * that.re - this.re * that.im) / denomin;
            return new MyComplex(real, imag);
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
}
