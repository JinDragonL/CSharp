// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

LinkedList<string> list = new LinkedList<string>();

list.AddFirst("A");
list.AddLast("C");
list.AddLast("D");
list.AddLast("E");
list.AddLast("F");
list.AddLast("G");
list.AddLast("H");

Node element = list.FirstOrDefault(x => x == "E");

Console.WriteLine(element);


foreach (var item in list)
{
    Console.WriteLine($"{item}");
}