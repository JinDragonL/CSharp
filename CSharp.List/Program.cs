// See https://aka.ms/new-console-template for more information
using CSharp.List;

Console.WriteLine("Hello, World!");

//List --> Dynamic Collection

List<string> list = new List<string>(); //0, 1

list.Add("a");
list.Add("b");


list[1] = "abc";

Console.WriteLine(list[1]);


List<int> numbers = new List<int>() { 13, 100, 84, 30 };

Console.WriteLine(numbers[2]);



List<People> peoples = new List<People>();

peoples.Add(new People { Name = "Nguyen A", Age = 20 });
peoples.Add(new People { Name = "Nguyen B", Age = 25 });


List<People> peoples1 = new List<People>() //0,1,2
{
    new People(){ Name = "Nguyen C", Age = 18 }
};

peoples1.AddRange(peoples);

Console.WriteLine(peoples1.Count);

Console.WriteLine($"{peoples1[2].Name} - {peoples1[2].Age}");



List<DateTime> dates = new List<DateTime>() //0, 1, 2
{
    DateTime.Now,
    new DateTime(2022, 10, 10)
};

dates.Insert(1, new DateTime(2022, 12, 25));

dates.Clear();

//dates.Remove(dates[1]);

// Array vs List
// size cố định vs size List động
// perfomance chậm hơn array

// 4 - 8 - 16 - 32 - 64 -....

List<int> values = new List<int>() { 14, 80, 100, 89, 0, 50 };

Console.WriteLine(values.Capacity);

values.Add(38);
values.Add(290);
values.Add(356);

Console.WriteLine(values.Capacity);

List<int> ls; // null

List<int> ls2 = new List<int>(); //ls empty

List<int> ls3 = new(); //ls empty

Console.WriteLine(ls2.Count); //0

