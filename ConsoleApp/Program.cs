using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {

            B b = new B();
            
            try
            {
                
                C b1= b as C;
                if (b is C)
                {

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
    class A
    {

    }
    class B : A
    {

    }
    class C : B
    {

    }
}
