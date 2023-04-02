using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp.Conditional.Statement
{
    public class SwitchStatement
    {
        public SwitchStatement() {

            //IF --> if(expression)


            //Switch --> switch(value of expression)  //number, string, boolean, ...

            int a = 10;

            switch (a)
            {
                case 5:
                case 10:
                case 20:
                    Console.WriteLine("is 5 or 10 or 20");
                    break;
                case 50:
                    Console.WriteLine("is 50");
                    break;
                default:
                    Console.WriteLine("is number");
                    break;
            }

            //Console.WriteLine(CheckDayOfWeek(3));


            // Constant pattern - Relative pattern (<, <=, >, >=, ==)

            int number = 300;

            string result = number == 2 ? "correct" : "incorrect";  //ternary operator


           string day = number switch
            {
                > 0 and < 20 => "Sunday",
                < 100 or < 200 => "Monday",
                1000  => "Tuesday", // => ==
                _ => "Saturday"  //discard
            };


            //IF vs Switch


            Console.WriteLine(day);

        }

        private string CheckDayOfWeek(int number)
        {
            switch (number)
            {
                case 0: 
                    return "Sunday";
                case 1:
                    return "Mondy";
                case 2: 
                    return "Tuesday";
                case 3: 
                    return "Wednsday";
                case 4: 
                    return "Thursday";
                default: return string.Empty;
            }
        }


    }
}
