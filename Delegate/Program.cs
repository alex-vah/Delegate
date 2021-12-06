using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void Message();
    internal class Program
    {
        delegate int Operation(int x, int y);
        delegate void GetMessage();
        static void Main(string[] args)
        {
            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvening;
            }
            Operation op1 = Add;
            Operation op2 = Subtract;
            op1(1, 2);
            op2(1, 3);
            if (DateTime.Now.Hour < 12)
            {
                ShowMessage(GoodMorning);
            }
            else
            {
                ShowMessage(GoodEvening);
            }
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Subtract(int x, int y)
        {
            return x - y;
        }
        private static void ShowMessage(GetMessage del)
        {
            del?.Invoke();
        }
    }
}
