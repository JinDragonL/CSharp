using CSharp.LINQ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LINQ
{
    public class Operator
    {
        public void OrderBy(List<Student> students)
        {
            //ORDER BY
            var query = from student in students
                        orderby student.Class descending
                        select student;

            var lambda = students.OrderByDescending(x => x.Class);

            foreach (var student in lambda)
            {
                Console.WriteLine($"name: {student.FirstName} {student.LastName} - class: {student.Class}");
            }

            //PARTITION

            //Skip, Take, SkipWhile, TakeWhile

            var studentTake = students.Skip(2).Take(10);

            int total = studentTake.Count();

            int pageIndex = 1, pageSize = 5;

            students.Skip((pageIndex - 1) * pageSize).Take(pageSize * pageIndex); //1-5

            pageIndex = 2; pageSize = 5;

            students.Skip((pageIndex - 1) * pageSize).Take(pageSize * pageIndex); //6-10


            students.TakeLast(3); //6 -  7 - 8

            Console.WriteLine($"Total: {total}");

            int[] numbers = new int[] { 1, 23, 30, 73, 100, 12, 80, 5 };

            var lastNumbers = numbers.SkipWhile(x => x < 30);

            Console.WriteLine(string.Join(";", lastNumbers));

            //foreach (var item in lastNumbers)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
