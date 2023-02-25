using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void math(int a, int b);
    
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter symbol acording to opration + - / *");
                string c = Console.ReadLine();
                Console.Write("enter number 1 :");
                int a = int.Parse(Console.ReadLine());
                Console.Write("enter number 2 :");
                int b = int.Parse(Console.ReadLine());


                char check = c[0];
                switch (check)
                {
                    case '+':
                        math obj = new math(Delegates.add);
                        obj.Invoke(a, b);

                        break;

                    case '-':
                        obj = new math(Delegates.substraction);
                        obj.Invoke(a, b);
                        break;

                    case '*':
                        obj = new math(Delegates.multiplication);
                        obj.Invoke(a, b);

                        break;

                    case '/':
                        obj = new math(Delegates.division);
                        obj.Invoke(a, b);

                        break;

                    default:
                        Console.WriteLine("enter right input");
                        break;

                }
            }
        }
    }
}
