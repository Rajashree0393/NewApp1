using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static int FNum = 5;
        public static int SNum = 5;
        static string A ="B";
        static string C = A + "X";
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine("value of C is:{0}", C);
            Console.WriteLine("calling method1 :{0}",p1.method1(FNum,SNum));
            Program p2 = new Program();
            p2.method2();
            Console.ReadLine();
        }
        public int method1(int FNum, int SNum)
        {
            FNum += 10;
            return FNum + SNum;
        }
        public void method2()
        {
            FNum += 20;
            Console.WriteLine(FNum + SNum);
        }
    }
    //abstract class x
    //{
    //    public abstract void eat();
    //    //{
    //    //    Console.WriteLine("i am in X class..");
    //    //}

    //}
    //class Y : x {
    //    public override void eat()
    //    {
    //        Console.WriteLine("I am in Y Class..");
    //    }
    //}

}
