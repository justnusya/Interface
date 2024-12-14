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
        public MyFrac(string nomNdenom)
        {
            try
            {
                string[] data = nomNdenom.Trim().Split('/');
                nom = BigInteger.Parse(data[0]);
                denom = BigInteger.Parse(data[1]);
            }
            catch
            {
                throw new ArgumentException("Wrong input");
            }
        }
        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom).Simplify();
        }
        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(nom * that.denom - that.nom * denom, denom * that.denom).Simplify();
        }
        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(nom * that.nom, denom * that.denom).Simplify();
        }
        public MyFrac Divide(MyFrac that)
        {
            if (this.denom == 0 || that.denom==0)
            {
                throw new DivideByZeroException("Impossible to divide by zero");
            }
            return new MyFrac(nom * that.denom, denom * that.nom).Simplify();
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
        public MyFrac Simplify()
        {
            BigInteger greatDiv = BigInteger.GreatestCommonDivisor(nom, denom);

            nom /= greatDiv;
            denom /= greatDiv;

            if (denom < 0)
            {
                nom = (-1)*nom;
                denom = (-1)*denom;
            }

            return this; 
        }
    }
}
