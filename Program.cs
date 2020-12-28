using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _7._2
{



    



    class Program
    {






        public static void strartg2()
        {

            char[,] laber =                 {
                { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X','X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
                { 'X', 'X', '1', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X' },
                { 'X', 'X', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ',' ', 'X', ' ', 'X', ' ', 'X', ' ', ' ', ' ', 'X'},
                { 'X', 'X', ' ', 'X', ' ', ' ', 'X', ' ', 'X', 'X' ,' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X'},
                { 'X', 'X', ' ', 'X', 'X', ' ', 'X', ' ', ' ', 'X' ,'X', 'X', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', ' ', 'X', ' ', ' ', 'X', 'X', 'X', 'X',' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', ' ', ' ', 'X', ' ', 'X', ' ', ' ', ' ' ,' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', ' ', 'X'},
                { 'X', 'X', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', ' ', 'X'},
                { 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X' },
                { 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X' },
                { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', ' ', 'X'},
                { 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' ,' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', ' ', 'X', 'X'},
                { 'X', 'X', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                { 'X', 'X', '1', ' ', ' ', ' ', 'M', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'}
            };


            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    Console.Write(laber[i,j]);
                    Console.SetCursorPosition(i, j);

                    
                }
            }





        }

        public static void MoveCursor2(ref int i, ref int j, ConsoleKeyInfo key)
        {
            


            char[,] laber =                 {
                {  'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X','X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
                {  'X', '1', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X' , 'X'},
                {  'X', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ',' ', 'X', ' ', 'X', ' ', 'X', ' ', ' ', ' ', 'X', 'X'},
                {  'X', ' ', 'X', ' ', ' ', 'X', ' ', 'X', 'X' ,' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X'},
                {  'X', ' ', 'X', 'X', ' ', 'X', ' ', ' ', 'X' ,'X', 'X', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', ' ', 'X', ' ', ' ', 'X', 'X', 'X', 'X',' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', ' ', ' ', 'X', ' ', 'X', ' ', ' ', ' ' ,' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X'},
                { 'X', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X'},
                {  'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X' , 'X'},
                {  'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X' , 'X'},
                {  'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X'},
                {  'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' ,' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', ' ', 'X', 'X', 'X'},
                {  'X', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {  'X', '1', ' ', ' ', ' ', 'M', ' ', ' ', ' ' ,' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X'},
                {  'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' ,'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'}
            };




            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (laber[i, j] == 'X')
                        j++;

                    break;
                case ConsoleKey.DownArrow:
                    if (laber[i, j] == 'X')
                        j--;
                    break;
                case ConsoleKey.LeftArrow:
                    if (laber[i, j] == 'X')
                        i++;
                    break;
                



            }

            


                Console.SetCursorPosition(i, j);

            if (laber[i, j] == '1')
            { Console.Clear();
                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Вы выиграли");
                Console.SetCursorPosition(10, 14);
                Console.WriteLine("ESC-выход");

                Console.SetCursorPosition(10, 17);
                Console.WriteLine("Q-Вернуться в главное меню");
            }



        }








        public static void MoveCursor(ref int left, ref int top)
        {
            if (left < 1)
                left = 1;
            if (top < 1)
                top = 1;
            if (left > 52)
                left = 52;
            if (top > 22)
                top = 22;
            Console.SetCursorPosition(left, top);

        }


        public static void strartg()
        {
            for (int i=0; i< 54; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    if (i == 54 - 1)
                        if (j < 24)
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write('X');
                        }

                    if (i < 1)
                        if (j < 24)
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write('X');
                        }


                    if (i < 54)
                        if (j < 1)
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write('X');
                        }

                    if (i < 54)
                        if (j == 23)
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write('X');
                        }
                }
            }

            

        }


        public static void menu(ConsoleKeyInfo key)
        {

            
                if (key.Key == ConsoleKey.D1 )
            {

                game1(key);


            }

            if(key.Key == ConsoleKey.D2)
            {

                game2(key);


            }



            if (key.Key == ConsoleKey.Escape)
            { Environment.Exit(0); }

        }

        public static void game1(ConsoleKeyInfo key)
        {

            Console.Clear();

            strartg();

            int cursorPosLeft = 1;
            int cursorPosTop = 1;
            Console.SetCursorPosition(cursorPosLeft, cursorPosTop);
            Console.Write('*');
            Console.SetCursorPosition(cursorPosLeft, cursorPosTop);

            Random random = new Random();

            char[] chs = {'*','@','#','$', '+', '&' };
            char chd = '+';

            ConsoleColor[] mColor = { ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.Gray, ConsoleColor.Green };

            


            while (key.Key != ConsoleKey.Q)
            {
                Console.ForegroundColor = mColor[random.Next(0, 6)];
                char ch = chs[random.Next(0, 6)];
                

                switch (key.Key)
                {

                    

                    case ConsoleKey.UpArrow:
                        Console.Write(chd);
                        cursorPosTop--;
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        Console.Write(ch);
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Write(chd);
                        cursorPosTop++;
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        Console.Write(ch);
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Write(chd);
                        cursorPosLeft--;
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        Console.Write(ch);
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Write(chd);
                        cursorPosLeft++;
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        Console.Write(ch);
                        MoveCursor(ref cursorPosLeft, ref cursorPosTop);
                        break;
                }
                key = Console.ReadKey(true);
                 chd = ch;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            menu(key);




        }






        public static void game2(ConsoleKeyInfo key)
        {

            Console.Clear();

            strartg2();

            int cursorPosLeft = 20;
            int cursorPosTop = 10;
            Console.SetCursorPosition(cursorPosLeft, cursorPosTop);
            Console.Write('*');
            Console.SetCursorPosition(cursorPosLeft, cursorPosTop);

            char ch = ' ';


            while (key.Key != ConsoleKey.Q)
            {
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Write(' ');
                        cursorPosTop--;
                        MoveCursor2(ref cursorPosLeft, ref cursorPosTop, key);
                        Console.Write('*');
                        MoveCursor2(ref cursorPosLeft, ref cursorPosTop, key);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Write(ch);
                        cursorPosTop++;
                        MoveCursor2(ref cursorPosLeft, ref cursorPosTop, key);
                        Console.Write('*');
                        MoveCursor2(ref cursorPosLeft, ref cursorPosTop, key);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Write(ch);
                        cursorPosLeft--;
                        MoveCursor2(ref cursorPosLeft, ref cursorPosTop, key);
                        Console.Write('*');
                        MoveCursor2(ref cursorPosLeft, ref cursorPosTop, key);
                        break;

                    case ConsoleKey.RightArrow:
                        MoveCursor2(ref cursorPosLeft, ref cursorPosTop, key);
                        break;

                }
                key = Console.ReadKey(true);
            }

            Console.Clear();
            menu(key);




        }








        public static void Main(string[] args)
        {
            
            do
            {
                Console.SetCursorPosition(10, 10);
                Console.WriteLine("1-Трон ");
                Console.SetCursorPosition(10, 12);
                Console.WriteLine("2-Лаберинт");
                Console.SetCursorPosition(10, 14);
                Console.WriteLine("ESC-выход");

                Console.SetCursorPosition(10, 17);
                Console.WriteLine("Q-Вернуться в главное меню");


                ConsoleKeyInfo key = Console.ReadKey(true);

                menu(key);

                Console.Clear();
            }
            while (true);


        }
    }
}
