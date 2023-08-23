//Iteration Statement

int[] numbers = new int[] { 4, 19, 100, 50, 250 };

for (int i = 0; i < numbers.Length; i++)
{
    //do something
    //Console.WriteLine("Value of number:");
    //Console.WriteLine(numbers[i]);

    //i++
}

List<int> numbers2 = new List<int>() { 100, 200, 300, 400, 500 };


//while (a < 5)
//{
//    int b = 10;
//    Console.WriteLine(a + b);
//    a++;
//}

int a = 0;
do
{
    var element = numbers2[a];

    int b = 10;

    Console.WriteLine(a + b);

    a++;

} while (a < 5);



//Parallel

int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine($"Foreach");
foreach (int i in values)
{
    // do something
    Console.WriteLine($"value: {i}");
}

Console.WriteLine($"Parallel.ForEach:");
//Parallel.ForEach(values, x =>
//    Console.WriteLine(x)
//);

Parallel.For(0, values.Length, x =>
    Console.WriteLine(values[x])
);
