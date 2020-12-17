using System;

namespace SimpleFraction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            char chooser;
            Fraction firstFraction = new Fraction(2, 6);
            Fraction secondFraction = new Fraction(1, 4);

            while (isWorking)
            {
                Console.WriteLine
                    (
                    "\n" +
                    "1. Enter numbers for fisrtFraction \n" +
                    "2. Enter numbers for secondFraction \n" +
                    "3. Add secondFraction to firstFraction \n" +
                    "4. Substract secondFraction from firstFraction \n" +
                    "5. Multiply fractions \n" +
                    "6. Divide firstFraction by secondFraction \n" +
                    "7. Increment firstFraction by 1 \n" +
                    "8. Decrement 1 from secondFraction \n" +
                    "9. Quit \n"
                    );
                chooser = Convert.ToChar(Console.ReadLine());
                switch (chooser)
                {
                    case '1':
                        firstFraction.FillFraction();
                        break;
                    case '2':
                        secondFraction.FillFraction();
                        break;
                    case '3':
                        firstFraction.AddFraction(secondFraction);
                        break;
                    case '4':
                        firstFraction.SubtractFraction(secondFraction);
                        break;
                    case '5':
                        firstFraction.MultiplyFraction(secondFraction);
                        break;
                    case '6':
                        firstFraction.DivideFraction(secondFraction);
                        break;
                    case '7':
                        firstFraction++;
                        break;
                    case '8':
                        secondFraction--;
                        break;
                    case '9':
                        isWorking = false;
                        break;

                }
            }
        }
    }
}
