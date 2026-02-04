namespace LumoakatemiaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SuurinLuku();
            //SuurinKolmesta();
            //tehtava3();
            //tehtava4();
            //tehtava5();
            //tehtava6();
            //tehtava7();
            //tehtava8();
            //tehtava9();
            //tehtava10();
            //tehtava11();
            //tehtava12();
            //tehtava13();
            //tehtava14();
            //tehtava15();
            //tehtava16();
            //tehtava17();
            tehtava18();
        }
        static void SuurinLuku()
        {
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            int eka = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            int toka = int.Parse(Console.ReadLine());
            if (eka > toka)
            {
                Console.WriteLine("{0} on suurempi kuin {1}", eka, toka);
            }
            else
            {
                Console.WriteLine("{0} on suurempi kuin {1}", toka, eka);
            }
        }
        static void SuurinKolmesta()
        {
            int[] luvut = new int[3];

            Console.Write("Anna ensimmäinen kokonaisluku: ");
            luvut[0] = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku: ");
            luvut[1] = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas kokonaisluku: ");
            luvut[2] = int.Parse(Console.ReadLine());

            int suurin = luvut.Max();
            Console.WriteLine("Suurin luku on: " + suurin);
        }

        static void tehtava3()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("Positive");
            else if (num < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }
        static void tehtava4()
        {
            int num;

            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 || num % 11 == 0)
            {
                Console.WriteLine("The number is divisible by 5 or 11.");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 5 or 11.");
            }
        }
        static void tehtava5()
        {
            int year;
            Console.WriteLine("Enter a year: ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine(year + " is a leap year.");
            else
                Console.WriteLine(year + " is not a leap year.");
        }
        static void tehtava6()
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " is even.");
            else
                Console.WriteLine(num + " is odd.");
        }
        static void tehtava7()
        {
            Console.WriteLine("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            if (Char.IsLetter(input))
            {
                Console.WriteLine("\nThe input is a letter.");
            }
            else
            {
                Console.WriteLine("\nThe input is not a letter.");
            }
        }
        static void tehtava8()
        {
            Console.WriteLine("Enter a letter: ");
            char input = char.ToLower(Console.ReadKey().KeyChar);
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("\nThe input is a vowel.");
            }
            else
            {
                Console.WriteLine("\nThe input is a consonant.");
            }
        }
        static void tehtava9()
        {
            Console.WriteLine("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            if (Char.IsLetter(input))
            {
                Console.WriteLine("\nThe input is a letter.");
            }
            else if (Char.IsNumber(input))
            {
                Console.WriteLine("\nThe input is a number.");
            }
            else
            {
                Console.WriteLine("\nThe input is other.");
            }
        }
        static void tehtava10()
        {
            Console.WriteLine("Enter a letter: ");
            char input = Console.ReadKey().KeyChar;
            if (Char.IsUpper(input))
            {
                Console.WriteLine("\nThe input is an upper case letter.");
            }
            else if (Char.IsLower(input))
            {
                Console.WriteLine("\nThe input is a lower case letter.");
            }
            else
            {
                Console.WriteLine("\nThe input is not a letter.");
            }
        }
        static void tehtava11()
        {
            Console.WriteLine("Enter the buying price: ");
            double buyingPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the selling price: ");
            double sellingPrice = double.Parse(Console.ReadLine());

            if (sellingPrice > buyingPrice)
            {
                double profit = sellingPrice - buyingPrice;
                Console.WriteLine("Profit of {0} can be made.", profit);
            }
            else
            {
                Console.WriteLine("No profit can be made.");
            }
        }
        static void tehtava12()
        {
            int[] testPoints = new int[5];
            string[] testNames = { "Math", "Physics", "English", "Spanish", "Literature" };

            for (int i = 0; i < testPoints.Length; i++)
            {
                Console.Write("Enter points for " + testNames[i] + " test: ");
                testPoints[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < testPoints.Length; i++)
            {
                if (testPoints[i] >= 90)
                    Console.WriteLine(testNames[i] + " test grade: K5");
                else if (testPoints[i] >= 80)
                    Console.WriteLine(testNames[i] + " test grade: H4");
                else if (testPoints[i] >= 70)
                    Console.WriteLine(testNames[i] + " test grade: H3");
                else if (testPoints[i] >= 60)
                    Console.WriteLine(testNames[i] + " test grade: T2");
                else if (testPoints[i] >= 50)
                    Console.WriteLine(testNames[i] + " test grade: T1");
                else
                    Console.WriteLine(testNames[i] + " test grade: Failed");
            }
        }
        static void tehtava13()
        {
            Console.Write("Enter week number (1-7): ");
            int week = int.Parse(Console.ReadLine());

            switch (week)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                    break;
            }
        }
        static void tehtava14()
        {
            int num1, num2;

            Console.WriteLine("Input the values for Number1 and Number2 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Number1 and Number2 are equal\n");
            }

            else
            {
                Console.WriteLine("Number1 and Number2 are not equal\n");
            }
        }
        static void tehtava15()
        {
            int Candiateage;

            Console.WriteLine("Input the age of the candidate : ");
            Candiateage = Convert.ToInt32(Console.ReadLine());

            if (Candiateage < 18)
            {
                Console.WriteLine("Sorry, You are not eligible to caste your vote.\n");
                Console.WriteLine(18 - Candiateage + "You would be able to caste your vote after %d year.\n");
            }

            else
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.\n");
            }
        }
        static void tehtava16()
        {
            string[] monthNames =
            {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    };

            string[] monthDays =
            {
        "31 days", "28 or 29 days", "31 days", "30 days", "31 days", "30 days",
        "31 days", "31 days", "30 days", "31 days", "30 days", "31 days"
    };

            Console.Write("Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            if (month >= 1 && month <= 12)
            {
                Console.WriteLine("Enter month : " + monthNames[month - 1]);
                Console.WriteLine("No. of days : " + monthDays[month - 1]);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter month number between (1-12).");
            }
        }
        static void tehtava17()
        {
            Console.Write("Enter amount: ");
            int amount = int.Parse(Console.ReadLine());

            int[] notes = { 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] counts = new int[notes.Length];

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    counts[i] = amount / notes[i];
                    amount -= counts[i] * notes[i];
                }
            }

            Console.WriteLine("\nTotal number of notes:\n");

            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine(notes[i] + " = " + counts[i]);
            }
        }
        static void tehtava18()
        {
            int anglea, angleb, anglec, sum;

            Console.WriteLine("Input three angles of triangle : ");
            anglea = Convert.ToInt32(Console.ReadLine());
            angleb = Convert.ToInt32(Console.ReadLine());
            anglec = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of all angles of triangle
            sum = anglea + angleb + anglec;

            // Check whether sum=180 then its a valid triangle otherwise invalid triangle
            if (sum == 180)
            {
                Console.WriteLine("It is a valid triangle.\n");
            }
            else
            {
                Console.WriteLine("It is a invalid triangle.\n");
            }

            Console.ReadLine();
        }
    }
}
 
