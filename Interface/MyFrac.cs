using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Interface
{
    public class MyFrac: IMyNumber<MyFrac>, IComparable<MyFrac>
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
        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(nom * that.nom, denom * that.denom);
        }
        public MyFrac Divide(MyFrac that)
        {
            if (this.denom == 0 || that.denom==0)
            {
                throw new DivideByZeroException("Impossible to divide by zero");
            }
            return new MyFrac(nom * that.denom, denom * that.nom);
        }
        public int CompareTo(MyFrac that)
        {
            BigInteger currentValue = nom * that.denom;
            return currentValue.CompareTo(that.nom * denom);
        }
        public override string ToString()
        {
            return $"{nom}/{denom}";
        }
    }
}
