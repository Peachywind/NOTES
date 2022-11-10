using System.Diagnostics;
using System.Security.Cryptography;

namespace notes
{
    class Program
    {
        static public int PositionLimit = 1;
        static public int SecondPostionLimit;
        static public int Position = 1;
        static public ConsoleKeyInfo key;
        static public int Position_ = 0;

        static void Main()
        {
            switch_();
        }

        static void switch_()
        {
            List();
            do
            {
                Strlka();
            } while (true);
            
        }

        static void List()
            {
                List<string> notes = new List<string>();
                notes.Add("Выбрана дата 25.02.2019");
                notes.Add("------------------------------------------");
                notes.Add("------------------------------------------");
                notes.Add("   1. Помыть посуду");
                notes.Add("   2. Помыть стекла");
                foreach (string item in notes)
                    Console.WriteLine(item);
                ConsoleKeyInfo key = Console.ReadKey();
                int positoin = 4;
                
            }

            static void List1()
            {
                Console.Clear();
                List<string> notes = new List<string>();
                notes.Add("Выбрана дата 26.02.2019");
                notes.Add("------------------------------------------");
                notes.Add("------------------------------------------");
                notes.Add("   1. Пропылесосить");
                notes.Add("   2. Протереть пыль");
                foreach (string item in notes)
                    Console.WriteLine(item);
                int positoin = 3;
                if (key.Key == ConsoleKey.Enter)
                {
                    if (positoin == 3)
                    {
                        Console.Clear();
                        liset_for_questions_2();
                    }

                    if (positoin == 4)
                    {
                        Console.Clear();
                        liset_for_questions_3();
                    }
                }
            }

            static void List2()
            {
                List<string> notes = new List<string>();
                notes.Add("Выбрана дата 27.02.2019");
                notes.Add("------------------------------------------");
                notes.Add("------------------------------------------");
                notes.Add("   1. Сходить по магазинам");

                foreach (string item in notes)
                    Console.WriteLine(item);
                int positoin = 3;
                if (key.Key == ConsoleKey.Enter)
                {
                    if (positoin == 3)
                    {
                        liset_for_questions_4();
                    }
                }
            }

            static void liset_for_questions()
            {
                Console.Clear();
                List<string> notes = new List<string>();
                notes.Add("Помыть посуду");
                notes.Add("------------------------------------------");
                notes.Add("------------------------------------------");
                notes.Add("Описание: Помыть посуду до вечера");
                notes.Add("Дата: 25.02.2019");
                foreach (string item in notes)
                    Console.WriteLine(item);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    List();
                    Strlka();
                }

            }

            static void liset_for_questions_1()
            {
                Console.Clear();
                List<string> notes_2 = new List<string>();
                notes_2.Add("Помыть стекла");
                notes_2.Add("------------------------------------------");
                notes_2.Add("Описание: Помыть стекла в коридоре");
                notes_2.Add("Дата: 25.02.2019");
                foreach (string item in notes_2)
                    Console.WriteLine(item);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    List();
                    Strlka();
                }

            }

            static void liset_for_questions_2()
            {
                List<string> notes_2 = new List<string>();
                notes_2.Add("Пропылесосить");
                notes_2.Add("------------------------------------------");
                notes_2.Add("Описание: Пропылесосить во всей квартире");
                notes_2.Add("Дата: 26.02.2019");
                foreach (string item in notes_2)
                    Console.WriteLine(item);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    List1();
                    Strlka();
                }
            }

            static void liset_for_questions_3()
            {
                List<string> notes_2 = new List<string>();
                notes_2.Add("Протереть пыль");
                notes_2.Add("------------------------------------------");
                notes_2.Add("Описание: ППротереть пыль у себя в комнате");
                notes_2.Add("Дата: 26.02.2019");
                foreach (string item in notes_2)
                    Console.WriteLine(item);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    List1();
                    Strlka();
                }
            }

            static void liset_for_questions_4()
            {
                List<string> notes_2 = new List<string>();
                notes_2.Add("  1. Сходить по магазинам");
                notes_2.Add("------------------------------------------");
                notes_2.Add("Описание: П  1. Сходить по магазинам");
                notes_2.Add("Дата: 27.02.2019");
                foreach (string item in notes_2)
                    Console.WriteLine(item);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    List2();
                    Strlka();
                }
            }
            static void Strlka()
            {
                ConsoleKeyInfo key = Console.ReadKey();
                int Position = 4;
                int Position_ = 0;
                do
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (Position == 3) // не дает уйти в отрицательно значение
                        {
                            Position++;
                        }

                        Console.SetCursorPosition(0, Position--);
                        Console.Write("->");
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        if (SecondPostionLimit == 5 && Position == 5)
                        {
                            Position--;
                        }

                        Console.SetCursorPosition(0, Position++);
                        Console.Write("->");
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        Position_++;
                        if (Position_ == 4)
                        {
                            Position_--;
                        }

                        if (Position_ == 1)
                        {
                            Console.Clear();
                            List1();
                        }

                        if (Position_ == 2)
                        {
                            Console.Clear();
                            List2();
                        }
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                            Position_--;
                            if (Position_ == -1)
                            {
                                Position_++;
                            }

                            if (Position_ == 0)
                            {
                                Console.Clear();
                                List();
                            }

                            if (Position_ == 1)
                            {
                                Console.Clear();
                                List1();
                            }

                            if (Position_ == 2)
                            {
                                Console.Clear();
                                List2();
                            }
                            
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        if (Position_ == 0)
                        {
                            if (Position == 3)
                            {
                                Console.Clear();
                                liset_for_questions();
                            }
                            else if (Position == 4)
                            {
                                Console.Clear();
                                liset_for_questions_1();
                            }
                        }
                        if (Position_ == 1)
                        {
                            if (Position == 3)
                            {
                                Console.Clear();
                                liset_for_questions_2();
                            }
                            else if (Position == 4)
                            {
                                Console.Clear();
                                liset_for_questions_3();
                            }
                        }
                        if (Position_ == 2)
                        {
                            if (Position == 3)
                            {
                                Console.Clear();
                                liset_for_questions_4();
                            }
                           
                        }
                    }
                    Console.Write("\r" + new string(' ', 2)); // удаляет это надоедливую стрелочку
                    Console.SetCursorPosition(0, Position);
                    Console.Write("->");
                    key = Console.ReadKey();
                }while (true) ;
            }
        }
    }

