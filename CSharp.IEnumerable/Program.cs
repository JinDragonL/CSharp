// See https://aka.ms/new-console-template for more information

var ls = new int[] { 1, 2, 3 };

IEnumerable<int> ints = ls;

var test = ints.GetEnumerator();

int i = 0;

while (test.MoveNext())
{
    Console.WriteLine(test.MoveNext());
    Console.WriteLine(test.Current);
}