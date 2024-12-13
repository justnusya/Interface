using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Interface
{
    public class MyFrac: IMyNumber<MyFrac>
    {
        public BigInteger nom, denom;
        public MyFrac (BigInteger nom, BigInteger denom)
        {
            this.nom = nom;
            this.denom = denom;
        }
        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);
        }
        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(nom * that.denom - that.nom * denom, denom * that.denom);
        }
        public MyFrac Multiply(MyFrac b)
        {
            return new MyFrac(nom * b.nom, denom * b.denom);
        }
    }
}
