using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Assignment
{
    public struct names
    {
        public string fname;
        public string lname;
        public string inter;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(160, 40);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] Finalll = new string[1];
            string[] Finalists = new string[10];
            string[] Finaly = new string[10];
            names[] Lastname = new names[30];
            //finalists[] final = new finalists[10];
            welcome();
            read(Lastname);
            sort(Lastname);
            Greeting();
            options();
            menu(Lastname, Finalists,Finalll);
            Lotto(Lastname);
            Console.ReadLine();
        }
        public static void welcome()
        {


            Console.WriteLine("                            ___  _                       _____      _       _            _           _      ");
            Console.WriteLine("                           / __\\ | |                    |  __ \\    | |     | |          | |         (_)     ");
            Console.WriteLine("                          | |  | | |_ __ _  __ _  ___   | |__) |__ | |_   _| |_ ___  ___| |__  _ __  _  ___ ");
            Console.WriteLine("                          | |  | | __/ _` |/ _` |/ _ \\  |  ___/ _ \\| | | | | __/ _ \\/ __| '_ \\| '_ \\| |/ __|");
            Console.WriteLine("                          | |__| | || (_| | (_| | (_) | | |  | (_) | | |_| | ||  __/ (__| | | | | | | | (__ ");
            Console.WriteLine("                           \\____/ \\__\\__,_|\\__, |\\___/  |_|   \\___/|_|\\__, |\\__\\___|\\___|_| |_|_| |_|_|\\___|");
            Console.WriteLine("                                            __/ |                      __/ |                                ");
            Console.WriteLine("                                           |___/                      |___/                                 ");
            Console.WriteLine("");
            Console.WriteLine("                   _____ _   _ _____ __  ___                                     _                                  _   ");
            Console.WriteLine("                  |_   _| \\ | | ____/_ |/ _ \\                      /\\           (_)                                | |  ");
            Console.WriteLine("                    | | |  \\| | |__  | | | | |                    /  \\   ___ ___ _  __ _ _ __  _ __ ___   ___ _ __ | |_ ");
            Console.WriteLine("                    | | | . ` |___ \\ | | | | |                   / /\\ \\ / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __|");
            Console.WriteLine("                   _| |_| |\\  |___) || | |_| |                  / ____ \\__ \\__ \\ | (_| | | | | | | | | |  __/| | | |_ ");
            Console.WriteLine("                  |_____|_| \\_|____/ |_|\\___/                  /_/    \\_\\___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__|");
            Console.WriteLine("                                                                                      __/ |                               ");
            Console.WriteLine("                                                                                     |___/                                ");
            Console.WriteLine("");
            Console.WriteLine(" __          ___                                 _         _          _                    __  __ _ _ _ _                   _            ___  ");
            Console.WriteLine(" \\ \\        / / |                               | |       | |        | |                  |  \\/  (_) | (_)                 (_)          |__ \\ ");
            Console.WriteLine("  \\ \\  /\\  / /| |__   ___   __      ____ _ _ __ | |_ ___  | |_ ___   | |__   ___    __ _  | \\  / |_| | |_  ___  _ __   __ _ _ _ __ ___     ) |");
            Console.WriteLine("   \\ \\/  \\/ / | '_ \\ / _ \\  \\ \\ /\\ / / _` | '_ \\| __/ __| | __/ _ \\  | '_ \\ / _ \\  / _` | | |\\/| | | | | |/ _ \\| '_ \\ / _` | | '__/ _ \\   / / ");
            Console.WriteLine("    \\  /\\  /  | | | | (_) |  \\ V  V / (_| | | | | |_\\__ \\ | || (_) | | |_) |  __/ | (_| | | |  | | | | | | (_) | | | | (_| | | | |  __/  |_|  ");
            Console.WriteLine("     \\/  \\/   |_| |_|\\___/    \\_/\\_/ \\__,_|_| |_|\\__|___/  \\__\\___/  |_.__/ \\___|  \\__,_| |_|  |_|_|_|_|_|\\___/|_| |_|\\__,_|_|_|  \\___|  (_)  ");
            Thread.Sleep(1);
            Console.Clear();
        }
        public static void read(names[] Lastname)
        {
            StreamReader sr = new StreamReader(@"millionaire.txt");
            int count = 0;
            while (!sr.EndOfStream)
            {
                Lastname[count].fname = sr.ReadLine();
                Lastname[count].lname = sr.ReadLine();
                Lastname[count].inter = sr.ReadLine();
                count++;
            }
            sr.Close();
        }
        public static void sort(names[] Lastname)
        {
            for (int i = 0; i < Lastname.Length - 1; i++)
            {
                for (int pos = 0; pos < Lastname.Length - 1; pos++)
                {
                    if (Lastname[pos + 1].lname.CompareTo(Lastname[pos].lname) < 0)
                    {
                        names temp = Lastname[pos + 1];
                        Lastname[pos + 1] = Lastname[pos];
                        Lastname[pos] = temp;
                    }
                }
            }
        }
        public static void display(names[] Lastname)
        {
            for (int i = 0; i < Lastname.Length; i++)
            {
                Console.Write($" {Lastname[i].lname.PadRight(30)}");
                Console.Write($"{Lastname[i].fname.PadRight(20)}");
                Console.WriteLine($"{Lastname[i].inter}");
            }
        }
        public static void edit(names[] Lastname)
        {
            bool found = false;
            while (found == false)
            {
                Console.Clear();
                display(Lastname);

                Console.WriteLine("Who's interests would you like to change?");
                string edit = Console.ReadLine();
                for (int i = 0; i < Lastname.Length; i++)
                {
                    if (Lastname[i].lname == edit)
                    {
                        Console.WriteLine("What would you like to change it to?:");
                        Lastname[i].inter = Console.ReadLine();
                        found = true;
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("Person not found");
                    Console.ReadLine();
                }
                Console.Clear();
            }

        }
        public static void display2(names[] Lastname)
        {
            for (int i = 0; i < Lastname.Length; i++)
            {
                Console.Write($" {Lastname[i].lname.PadRight(30)}");
                Console.Write($"{Lastname[i].fname.PadRight(20)}");
                Console.WriteLine($"{Lastname[i].inter}");
            }
        }

        public static void Greeting()
        {
            Console.WriteLine("Welcome to the menu");

        }
        public static void Contestants(names[] Lastname)
        {
            Console.WriteLine("Contestants Names");
            display(Lastname);
            Console.ReadLine();
        }
        public static void Edit(names[] Lastname)
        {
            Console.WriteLine("Edit Contestants");
            display(Lastname);
            edit(Lastname);
            display2(Lastname);
            Console.ReadLine();
        }
        public static void Insructions()
        {
            Instructions();
            Console.ReadLine();
        }
        public static void Game(names[] Lastname, string[] Finalists, string[] Finalll)
        {
            //Finaly(Lastname, Finalists);
            Console.WriteLine("These are your top 10 finalists");
            Lotto(Lastname);
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("\tAnd your finalist is");
            Finallll(Lastname, Finalists);
            Questions(Lastname, Finalists, Finalll);
            Console.ReadLine();
        }
        public static void exit()
        {
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
        public static void options()
        {
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t   1)  Contestants\n");
            //Console.WriteLine("");
            Console.WriteLine("\t\t\t\t   2)  Edit Contestants");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t   3)  Instructions");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t   4)  Play Game");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t   0)  Exit Game");
            Console.Write("\n\t\t\t\t  :");
        }
        public static void menu(names[] Lastname, string[] Finalists, string[] Finalll)
        {
            int intt, count = 0;
            string temp;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\tWho wants to be a millionare\n");
                options();
                temp = Console.ReadLine();
                intt = Convert.ToInt32(temp);
                Console.Clear();
                switch (intt)
                {
                    case 1:
                        Contestants(Lastname);
                        break;
                    case 2:
                        Edit(Lastname);
                        break;
                    case 3:
                        Insructions();
                        break;
                    case 4:
                        Game(Lastname, Finalists, Finalll);
                        break;
                    case 0:
                        Console.WriteLine("Thank you for playing");
                        Thread.Sleep(2500);
                        Environment.Exit(-1);
                        break;
                }
            } while (count != 1);
            Console.ReadLine();
        }
        public static void Finallll(names[] Lastname, string[] Finalists)
        {
            Random Rand = new Random();
            int[] finalists = new int[1];
            for (int i = 0; i < finalists.Length; i++)
            {
                finalists[i] = -1;
            }
            int lot;
            for (int i = 0; i < finalists.Length; i++)
            {
                lot = Rand.Next(0, 30);
                while (finalists.Contains(lot))
                {
                    lot = Rand.Next(0, 30);
                }
                finalists[i] = lot;
            }
            for (int i = 0; i < finalists.Length; i++)
            {
                Console.WriteLine($"\t{Lastname[finalists[i]].fname} {Lastname[finalists[i]].lname} ");
            }
        }
        public static void Lotto(names[] Lastname)
        {
            Random Rand = new Random();
            int[] finalists = new int[10];
            for (int i = 0; i < finalists.Length; i++)
            {
                finalists[i] = -1;
            }
            int lot;
            for (int i = 0; i < finalists.Length; i++)
            {
                lot = Rand.Next(0, 30);
                while (finalists.Contains(lot))
                {
                    lot = Rand.Next(0, 30);
                }
                finalists[i] = lot;
            }
            for (int i = 0; i < finalists.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"\t{Lastname[finalists[i]].fname} {Lastname[finalists[i]].lname} ");
            }
        }
        public static void Questions(names[] Lastname, string[] Finalists, string[] Finalll)
        {
            //Console.WriteLine(" A \n B \n C \n D \n");
            int count = 0;
            string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12;
            
                Console.WriteLine("");
                Console.WriteLine("\tQuestion 1");
                Console.WriteLine("\tWho won the FIFA World Cup in 2010\n");
                Console.WriteLine("\tA Spain \n\n \tB Germany \n\n \tC Brazil \n\n \tD England \n");
                Console.Write("       :");
                q1 = Console.ReadLine();
                q1=q1.ToUpper();           // what ever the user inputs converts to and Upper case
            if (q1.Contains("B"))      // if users input is correct then displays next question
            {
                Console.WriteLine("\n\tCorrect answer");
                count = 50;
                Console.WriteLine($"\tYour have just won ${count}");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("\tQuestion 2");
                Console.WriteLine("\tIn what year was the Burj Khalifa officially open\n");
                Console.WriteLine("\tA 2011 \n\n \tB 2010 \n\n \tC 2009 \n\n \tD 2008 \n");
                Console.Write("       :");
                q2 = Console.ReadLine();
                q2 = q2.ToLower();


                if (q2.Contains("b"))
                {
                    Console.WriteLine("\n\tCorrect answer");
                    count = 100;
                    Console.WriteLine($"\tYour have just won ${count}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("\tQuestion 3");
                    Console.WriteLine("\tWhich of these symptoms can happen if you’re depressed?\n");
                    Console.WriteLine("\tA Don’t feel hungry \n\n \tB Hungry all the time \n\n \tC Always tired \n\n \tD Any of above \n");
                    Console.Write("       :");
                    q3 = Console.ReadLine();
                    q3 = q3.ToLower();
                    if (q3.Contains("d"))
                    {
                        Console.WriteLine("\n\tCorrect answer");
                        count = 200;
                        Console.WriteLine($"\tYour have just won ${count}");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\tQuestion 4");
                        Console.WriteLine("\tIn early 1998, an American tourist couple mysteriously disappeared after being left behind where?\n");
                        Console.WriteLine("\tA New Zealand \n\n \tB Hanging Rock \n\n \tC Great Barrier Reef \n\n \tD Uluru \n");
                        Console.Write("       :");
                        q4 = Console.ReadLine();
                        q4 = q4.ToLower();
                        if (q4.Contains("c"))
                        {
                            Console.WriteLine("\n\tCorrect answer");
                            count = 500;
                            Console.WriteLine($"\tYour have just won ${count}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("\tQuestion 5");
                            Console.WriteLine("\tOn which river does the Austrian city of Vienna stand?\n");
                            Console.WriteLine(" \tA Danube \n\n \tB Rhine \n\n \tC Rhone \n\n \tD Weser \n");
                            Console.Write("       :");
                            q5 = Console.ReadLine();
                            q5 = q5.ToLower();
                            if (q5.Contains("a"))
                            {
                                Console.WriteLine("\n\tCorrect answer");
                                count = 1000;
                                Console.WriteLine($"\tYour have just won ${count}");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine(" Question 6");
                                Console.WriteLine(" What Poisitive electrode called, in an electrolytic cell?\n");
                                Console.WriteLine(" \tA cathode \n\n \tB triode \n\n \tC diode \n\n \tD anode  \n");
                                Console.Write("       :");
                                q6 = Console.ReadLine();
                                q6 = q6.ToLower();
                                if (q6.Contains("d"))
                                {
                                    Console.WriteLine("\n\tCorrect answer");
                                    count = 2500;
                                    Console.WriteLine($"\tYour have just won ${count}");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("\tQuestion 7");
                                    Console.WriteLine("\tWhich of these colours does not appear on the national flag of Lithuania?\n");
                                    Console.WriteLine("\tA blue \n\n \tB red \n\n \tC yellow \n\n \tD green \n");
                                    Console.Write("       :");
                                    q7 = Console.ReadLine();
                                    q7 = q7.ToLower();      // what ever the user inputs converts to and Upper case
                                    if (q7.Contains("b")) // if users input is correct then displays next question
                                    {
                                        Console.WriteLine("\n\tCorrect answer");
                                        count = 10000;
                                        Console.WriteLine($"\tYour have just won ${count}");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                    }
                                }
                            }

                        }

                    }
                }
            }
                    
            
        }
        public static void Instructions()
        {
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("*\tThe rules for this game are simple                                           *");
            Console.WriteLine("*\tTo earn the million dollars you must answer 12 questions.                    *");
            Console.WriteLine("*\tYou will be given a choice to either continue the game or take the money     *");
            Console.WriteLine("*\tthat you have won at the end of question 7                                   *");
            Console.WriteLine("*\tGoodluck                                                                     *");
            Console.WriteLine("**************************************************************************************");
        }
    }
}
