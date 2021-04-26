using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using Minauppgift;


namespace Minauppgifter
{

    
   public class Program
         
    {
        personaldata prd;

        static void Main(string[] args)
        {
            bool finished = false;
            do
            {

                Console.WriteLine("1  - Skriva ut Hello World." + " \n" + "2  - SKriva ut Förnamn, Efternamn, Ålder." + " \n" + "3  - Ändra Färgen på Texten." + "\n" + "4  - Skriva ut Dagens Datum." + "\n" +
                                    "5  - Skriva ut största input värden" + " \n" + "6  - Användaren ska gissa talet." + " \n" + "7  - Sparas fil på hårddisken" + " \n" +
                                   "8  - Läsa fil från hårddisken" + " \n" + "9  - Skickar in ett decimaltal och får tillbaka roten ur, upphöjt till 2 och upphöjt till 10" + " \n" + "10 -  Skriva ut Multiplikationstabell 1 till 10" + " \n"
                                   + "11 - Skapar två arrayer" + " \n" + "12 - Om input är en palindrom eller inte" + " \n" + "13 - Skriva ut alla siffror som är mellan de två inputsen" + " \n" +
                                  "14 - antal komma-separerade siffror som sedan sorteras och skrivs ut efter udda och jämna värden" + " \n" + "15 - Användaren skickar in ett antal värden som kan adderas"
                                 + " \n" + "16 - Slumpmässiga värden för Hälsa, Styrka och Tur");


                Console.WriteLine("Select any Number To Perform Respective Action");

                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Hello();
                }
                else if (option == 2)
                {
                    firstname();
                }
                else if (option == 3)
                {
                    changecolour();
                }
                else if (option == 4)
                {
                                        
                    var todaydate = DateTime.Today;
                    Console.WriteLine(todaydate);
                }
                else if(option == 5)
                {
                    greaternumber();
                }
                else if(option == 6)
                {
                    guessnumber();
                }
                else if( option == 7)
                {
                    writemyfile();
                    
                }
                else if(option == 8)
                {
                    readmyfile();
                }
                else if(option == 9)
                {
                    square();
                }
                else if(option == 10)
                {
                    mymultiplication();
                }
                else if(option == 11)
                {
                    arraycreating();
                                     
                }
                else if(option == 12)
                {
                    checkpalindrome();
                }
                else if(option == 13)
                {
                    betweendigits();
                }
                else if(option == 14)
                {
                    oddevennumber();
                }
                else if(option == 15)
                {
                    sepratecomma();
                }
                else if (option == 16)
                {
                    perosalaninfo();
                }
                else
                {
                    Console.WriteLine("You did't select Right Option Select one option from given above");
                }

                Console.WriteLine("Press To Restart (y/n)");
                char a = char.Parse(Console.ReadLine());

                if (a == 'y')
                {
                    finished = false;
                }
                else
                {
                    finished = true;

                }
                Console.Clear();
            }

            while (!finished);


        }

        static void Hello()
        {
            Console.WriteLine("Hello World");
        }
        static void firstname()
        {
            Console.WriteLine("Enter Förnamn");
            string Förnamn = Console.ReadLine();
            Console.WriteLine("Enter Efternamn");
            string Efternamn = Console.ReadLine();
            Console.WriteLine("Enter Ålden");
            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Förnamn:" + "" + Förnamn + " " + " Efternamn:" + " " + Efternamn + "" + " Ålden:" + " " + Age);
        }
        static void changecolour()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Colour is Red now");
            Console.WriteLine("Change to Default Colour enter m");

            char b = char.Parse(Console.ReadLine());
            if (b == 'm')
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("The colour is Back to Default Colour");

            }
            else
            {
                Console.WriteLine("Please enter the right option");
                //Console.Clear();
            }
        }
        static void greaternumber()
        {
            Console.WriteLine("Enter the 1st Value");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Value");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("First Value is greater then Second");
            }
            else
            {
                Console.WriteLine("The Second value is greater then first value");
            }
        }
        static void guessnumber()
        {
            Random rand = new Random();
            int randomnumber = rand.Next(1, 101);
            int guess;
            int numberofguess = 3;
            bool gameover = false;
            Console.WriteLine("I am thinking of a Number between 1 and 100");
            Console.WriteLine(" Now Enter your number and You have three attempts to guess the right number");

            while(gameover == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberofguess--;
                if(guess != randomnumber && numberofguess == 0)
                {
                    Console.WriteLine("You have tried three times and did't get the correct number: You loss");
                    gameover = true;
                }
                else if (guess == randomnumber)
                {
                    Console.WriteLine("You guess the right number: You Win");
                    gameover = true;
                }
                else if(guess > randomnumber)
                {
                    Console.WriteLine("Yor number is too high");
                }
                else if(guess < randomnumber)
                {
                    Console.WriteLine("Your number is too low");
                }
            }
        }

        static void writemyfile()
        {
            using (StreamWriter sw = File.CreateText(@"E:\Test\mytext.txt"))
            {
                Console.WriteLine("Enter your text");

                string mintext = Console.ReadLine();
                sw.WriteLine(mintext);

            }
        }
        static void readmyfile()
        {
            using (StreamReader sr = File.OpenText(@"E:\Test\mytext.txt"))
            {
                string s; 
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        static void square()
        {
            Console.WriteLine("Enter a Decimal number");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Sqrt(x);
            double z = Math.Pow(x, 2);
            double w = Math.Pow(x, 10);
            Console.WriteLine("Square root of entered number is:" + " " + y);
            Console.WriteLine("The entered number is raised upto 2 and is:" + " " + z);
            Console.WriteLine("The entered number is raised upto 10 and is:" + " " + w);
        }
        static void mymultiplication()
        {
            int x;
            int y;
            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("Multiplication Table of" + " " + x + ":");
                for (y = 1; y <= 10; y++)
                    Console.WriteLine("{0} x {1} = {2}", x, y, x * y);

            }
        }
        static void arraycreating()
        {
            Console.WriteLine("Press enter to Create a random number Array");
            Console.ReadLine();
            int[] myarray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < myarray.Length; ++i)
            {
                myarray[i] = rnd.Next(10);
            }
            foreach (var item in myarray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press enter to create second Array in ascending order");
            Console.ReadLine();
            Array.Sort(myarray);
            int[] mysecondarray = new int[myarray.Length];
            for (int i = 0; i < myarray.Length; i++)
            {
                mysecondarray[i] = myarray[i];
            }

            foreach (var item1 in mysecondarray)
            {
                Console.WriteLine(item1 + "");
            }
            Console.WriteLine("Press enter to Sort Array in Descending order");
            Console.ReadLine();
            Array.Reverse(mysecondarray);
            foreach (var item2 in mysecondarray)
            {
                Console.WriteLine(item2 + "");
            }
        }

        static void checkpalindrome()
        {
            string firstword = null;
            string secondword = null;
            Console.WriteLine("Write a word");
            firstword = Console.ReadLine();
            if (firstword != null)
            {
                for (int i = firstword.Length - 1; i >= 0; i--)
                {
                    secondword += firstword[i].ToString();

                }
                if (secondword == firstword)
                {
                    Console.WriteLine("The word you entered is Palindrome");
                }
                else
                {
                    Console.WriteLine("The word you entered is not Palindrome");
                }
            }
        }
        static void betweendigits()
        {
            Console.WriteLine("Enter the First Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int y = Convert.ToInt32(Console.ReadLine());
            List<int> mylist = new List<int>();
            for (int i = x + 1; i < y; i++)
            {
                mylist.Add(i);
            }
            Console.WriteLine("The Number between these two inputs are:");
            foreach (var item in mylist)
            {
                Console.WriteLine(item + "");
            }
        }
        static void oddevennumber()
        {
            Console.WriteLine("Enter the comma separated values");
            string value = Console.ReadLine();
            string[] splitarray = value.Split(",");
            int length = splitarray.Length;
            int[] intArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                intArray[i] = Convert.ToInt32(splitarray[i]);

            }
            Array.Sort(intArray);
            foreach (var values in intArray)
            {
                Console.WriteLine(values + "");
            }
            Console.WriteLine("Press enter to seprate odd and even number");
            Console.ReadLine();
            List<int> evennumber = new List<int>();
            List<int> oddnumber = new List<int>();

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {

                    evennumber.Add(intArray[i]);

                }
                else
                {
                    oddnumber.Add(intArray[i]);

                }
            }
            Console.WriteLine("The even numbers are:");
            foreach (var item in evennumber)
            {
                Console.WriteLine(item + "");
            }
            Console.WriteLine("The odd numbers are:");
            foreach (var item2 in oddnumber)
            {
                Console.WriteLine(item2 + "");
            }
        }
        static void sepratecomma()
        {
            Console.WriteLine("Enter comma seprateed values");
            string values = Console.ReadLine();
            string[] splitvalues = values.Split(",");
            int length = splitvalues.Length;
            int[] myarray = new int[length];
            for(int i = 0; i<length; i++)
            {
                myarray[i] = Convert.ToInt32(splitvalues[i]);
            }
            Console.WriteLine("Press enter to add the values");
            Console.ReadLine();
            int sum = myarray.Sum();
            Console.WriteLine(sum);

        }
        static void perosalaninfo()
        {
            Console.WriteLine("Enter the name of Character");
            var prd = new personaldata(Console.ReadLine());
            Console.WriteLine("Enter the Name of opponent");
            prd.opponentName = Console.ReadLine();
            Console.WriteLine("Character Name is:" + " " + prd.characterName + "\n" + "Opponent Name is:" + "" + prd.opponentName);
            Random rnd = new Random();
            string[] rndperson = { prd.characterName, prd.opponentName };
            int index = rnd.Next(rndperson.Length);
            string[] healthvalue = { "Feeling Fine", "Feeling Good", "Feeling not good", "Feeling sick" };
            int healthindex = rnd.Next(healthvalue.Length);
            string[] strengthvalue = { "Feeling strong", "Feeling average", "Feeling weak" };
            int strengthindex = rnd.Next(strengthvalue.Length);

            prd.turn = DateTime.Now.AddDays(90).ToString("MM/dd/yyyy");
            Console.WriteLine("The health position of " + rndperson[index] + " " + " is " + healthvalue[healthindex] + " \n" +
                               "and his strength is" + " " + strengthvalue[strengthindex] + "\n" + "and his turn is on" + " " + prd.turn);
        }

    }
}
