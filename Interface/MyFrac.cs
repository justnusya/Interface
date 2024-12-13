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

        public MyFrac Divide(MyFrac b)
        {
            throw new NotImplementedException();
        }

        public MyFrac Multiply(MyFrac b)
        {
            throw new NotImplementedException();
        }

        public MyFrac Subtract(MyFrac b)
        {
            throw new NotImplementedException();
        }

        MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);
        }
    }
}
