using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Property
{
    public class Rectangle
    {
        private int _value = 2;
        private int _value2;

        public int Length { get; private set; } = 20;
        public int Breadth { get; set; }

        public int Area
        {
            get => Length * Breadth;
            set { }
        }

        public int Perimeter
        {
            get
            {
                int result = (Length + Breadth) * _value;
                //do something
                return result;
            }
            set
            {

            }
        }

        public Rectangle()
        {

        }

        // set accessors for property by get/set 
        // set default value
        // write logic code 
        // keyword value of SET
        // static


    }
}
