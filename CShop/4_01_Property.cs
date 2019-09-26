using System;

class Circle
{
    double pi = 3.14;
    public double Pi
    {
        get { return pi; }
        set { pi = value; }
    }

}

namespace CShop
{
    class Property
    {
        public Property()
        {
            Circle o = new Circle();
            o.Pi = 3.141592;
            double piValue = o.Pi;
            Console.WriteLine(piValue);
        }
    }
}
