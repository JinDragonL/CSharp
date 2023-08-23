using System.Linq;


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

foreach (KeyValuePair<int,int> number in result2)
{
    Console.WriteLine(number.Value);
}