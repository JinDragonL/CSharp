using CSharp.LINQ;
using CSharp.LINQ.Model;
using Microsoft.AspNetCore.WebUtilities;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("LINQ - Language-Integrated Query");

//LINQ to Objects (Collections: Array, List, Dictionary...)
//LINQ to XML
//LINQ to Dataset (ADO.NET Framework)

//LINQ to SQL/LINQ to Entity

//IEnumerable<T> vs IQueryable<T>



//Query expression vs Lambda expression

Dictionary<int, int> numbers = new Dictionary<int, int>() {
    { 1, 100 },
    { 5 , 50 },
    { 10 , 1000 },
    { 18 , 1800 },
};

var result =    from number in numbers
                where number.Value > 1000
                select number;

//foreach (var number in result)
//{
//    Console.WriteLine(number.Value);
//}

//Lambda

var result2 = numbers.Where(number => number.Value > 1000);

//foreach (KeyValuePair<int,int> number in result2)
//{
//    Console.WriteLine(number.Value);
//}




var datasource = new string[] 
{
    "Hello",
    "World",
    "C#",
    "Programming",
    "Arrays",
    "Strings"
};


//Where
var resultSQL = from item in datasource
                where item == "Programming"
                select item;

//foreach (var item in resultSQL)
//{
//    Console.WriteLine(item);
//}


var resultSQL2 = datasource.Where(x => x.Length < 6);

//foreach (var item in resultSQL2)
//{
//    Console.WriteLine(item);
//}


var students = Student.GetAll();

//var year2001 = (from student in students
//               where student.DateOfBirth.Year == 2001 && student.Email == "emily.brown@example.com"
//               select student).SingleOrDefault();

//var year2001 = students.FirstOrDefault(x => x.DateOfBirth.Year == 2001);

//foreach (var student in year2001)
//{
//    Console.WriteLine($"{student.FirstName} - {student.LastName} - {student.DateOfBirth.ToString("yyyy/MM/dd")}");
//}

//FIRST             /       SINGLE    --> retrieve one element
//return first              throw exception

//var operators = new Operator();
////operators.OrderBy(Student.GetAll());

//var groupLinq = new JoiningAndGroup();
//groupLinq.ExecuteGroupBy();

XML xML = new XML();


Console.Read();

