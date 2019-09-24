using System;

namespace Anonymous_Methods
{
    class Program
    {
        delegate int TotalInt(int x);
        delegate void HelloWorld(string s);
        delegate void StandardDelegate();
        static void Count()
        {
            for(int i = 0; i <4; i ++)
            {
                System.Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            TotalInt total = delegate(int x)
            {
                int tt = 0;
                for(int i = 0; i<x; i ++)
                { 
                    tt += i;
                }
                return tt;
            };
            Console.WriteLine(total(5));
           HelloWorld hw = delegate(string s)
           {
              
               Console.WriteLine("Well well well " +s);
           };
               hw(" Hello world anonymously ");
            hw = new HelloWorld(PrintSomething);
           //from pre c# 2.0 days hw(" from pre c# 2.0 days");
            /////////////////////////////////////////////////////////////
            StandardDelegate standard = Count;
            standard();
            //////////////////////////////////
            
        }
        static void PrintSomething(string s)
        {
            System.Console.WriteLine("s");
        }
    }
}
