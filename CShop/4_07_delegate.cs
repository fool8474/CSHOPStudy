using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mathmatics
{
    delegate int CalcDelegate(int x, int y);
    delegate void CalcDelegate_2(int x, int y);

    static int Add(int x, int y) { return x + y; }
    static int Sub(int x, int y) { return x - y; }
    static int Mul(int x, int y) { return x * y; }
    static int Div(int x, int y) { return x / y; }

    static void Add_2(int x, int y) { Console.WriteLine(x + y); }
    static void Sub_2(int x, int y) { Console.WriteLine(x - y); }
    static void Mul_2(int x, int y) { Console.WriteLine(x * y); }
    static void Div_2(int x, int y) { Console.WriteLine(x / y); }

    CalcDelegate[] methods;
       
    public Mathmatics()
    {
        methods = new CalcDelegate[] { Mathmatics.Add, Mathmatics.Sub, Mathmatics.Mul, Mathmatics.Div };
    }

    public void Calculate(char opCode, int operand1, int operand2)
    {
        switch (opCode)
        {
            case '+':
                Console.WriteLine(methods[0](operand1, operand2));
                break;

            case '-':
                Console.WriteLine(methods[1](operand1, operand2));
                break;

            case '*':
                Console.WriteLine(methods[2](operand1, operand2));
                break;

            case '/':
                Console.WriteLine(methods[3](operand1, operand2));
                break;
        }
    }

    public void CalculateAll(int operand1, int operand2)
    {
        CalcDelegate_2 calc = Add_2;
        calc += Sub_2;
        calc += Mul_2;
        calc += Div_2;

        calc(operand1, operand2);
    }
}

namespace CShop
{
    class _4_07_delegate
    {
        
        public _4_07_delegate()
        {
            Mathmatics math = new Mathmatics();
            math.Calculate('+', 6, 3);
            math.Calculate('-', 6, 3);
            math.Calculate('*', 6, 3);
            math.Calculate('/', 6, 3);

            math.CalculateAll(10, 5);
        }
    }
}
