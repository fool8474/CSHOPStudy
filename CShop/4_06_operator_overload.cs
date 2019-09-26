using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop
{
    class Gram
    {
        double mass;

        public Gram(double value)
        {
            this.mass = value;
        }

        public override string ToString()
        {
            return this.mass + "g";
        }

        public static Gram operator +(Gram op1, Gram op2)
        {
            return new Gram(op1.mass + op2.mass);
        }

        public static implicit operator Kilogram(Gram gram)
        {
            return new Kilogram(gram.mass / 1000);
        }
    }

    class Kilogram
    {
        double mass;

        public Kilogram(double value)
        {
            this.mass = value;
        }

        public Kilogram Add(Kilogram target)
        {
            return new Kilogram(this.mass + target.mass);
        }

        public override string ToString()
        {
            return mass + "kg";
        }

        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }

        public static implicit operator Gram(Kilogram kilogram)
        {
            return new Gram(kilogram.mass * 1000);
        }
    }

    class _4_06_operator_overload
    {
        public _4_06_operator_overload()
        {
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1 + kg2;

            Console.WriteLine(kg3);

            Gram g1 = kg1;
            Console.WriteLine(g1);

            kg2 = g1;
            Console.WriteLine(kg2);
        }
    }
}
