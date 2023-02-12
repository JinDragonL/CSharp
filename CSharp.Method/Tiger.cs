using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Method
{
    public class Tiger
    {
        private string _color = "black-yellow";


        public void Run()  //private
        {
            //parameter (tham số) - argument (đối số)

            int x = 5;
            int y = 10;

            int total = GetTotal(x, y);

            Console.WriteLine(total);
        }


        private int GetTotal(int a, int b) => a + b;
 
        public string Climb()
        {
            //do something

            Console.WriteLine("Tiger can climb tree");

            return "stop";

            Console.WriteLine("***********");

            Console.WriteLine("Tiger's color {0}", _color);

            return string.Empty;
        }

        public string Sleep() => "at night";

        public (int, string) GetColorAndHeight()
        {
            string color = "black";

            int height = 50;

            return (height, color);
        }


    }

}
