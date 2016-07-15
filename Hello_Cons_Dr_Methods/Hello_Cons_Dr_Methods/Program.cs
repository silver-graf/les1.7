using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
            int wid =0, hei =0, pos=0,pos2 =0;
            char sym;
            try
            {
                Console.WriteLine("enter the width");
                wid =int.Parse(Console.ReadLine());
                Console.WriteLine("enter the heidth");
                hei = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the start position");
                pos = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the start position");
                pos2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the symbol");
                sym = Console.ReadLine()[0];
                Console.WriteLine("enter the message");


                mes = Console.ReadLine();
                Box b = new Box(wid, hei, pos, pos2, sym, mes);
                b.Draw();
                //Implement start position, width and height, symbol, message input

                //Create Box class instance

                //Use  Box.Draw() method

                Console.WriteLine("Press any key...");
            Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
