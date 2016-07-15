using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {


        public int Width { get; set; }
        public int Heidth { get; set; }
        public int Position1 { get; set; }
        public int Position2 { get; set; }
        public char Symbol { get; set; }
        public string Message { get; set; }


        Box()
        {
        }

        public Box(int wid, int hei, int pos, int pos2, char sym, string mes)
        {
            if (mes.Length < wid - 1)
            {
                Width = wid;
                Heidth = hei;

                Position1 = pos + Console.CursorLeft;
                Position2 = pos2 + Console.CursorTop;
                Symbol = sym;
                Message = mes;
            }
            else
            {
                Console.WriteLine("error");
            }
        }




        public void Draw()
        {
            Console.SetCursorPosition(Position1, Position2);
            draw(Width, Heidth, Symbol, Message);




        }

        private void draw(int wid, int hei, char sym, string mes)
        {
            bool fl = true;
            for (int j = 0; j <= Heidth; j++)
            {
                if (j == 0 || j == Heidth )
                    for (int i = 0; i < wid; i++)
                    {
                        Console.Write(sym);
                    }
                else
                {
                    drawBorder(Position1, Position2 + j, Position1 + wid-1, Position2 + j);
                }

                if (fl && (j == (Heidth/2)))
                {
                    Console.SetCursorPosition(Position1 + ((wid - 2 - mes.Length) / 2) + 1, Console.CursorTop);
                    Console.Write(mes);
                    fl = !fl;
                }
                
                Console.SetCursorPosition(Position1, Position2 + j);



            }
            Console.WriteLine();

        }
        void drawBorder(int pos1,int pos2,int pos3,int pos4)
        {
            Console.SetCursorPosition(pos1, pos2);
            Console.Write(Symbol);
            Console.SetCursorPosition(pos3, pos4);
            Console.Write(Symbol);


        }


        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use draw() to draw the box with message

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary


    }
}
