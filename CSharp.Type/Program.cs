//Type

//Value-Type
// int, float, double, char, bool, datetime .... (System.ValueType)
//
// Reference-Type
// string, object, array, list, class, dynamic ... (System.String/System.Object)

int a = 100;

bool isActive = true;

double b = 1500.0;

float c = 100;

int d = a;

d++;

Console.WriteLine(d);
Console.WriteLine(a);

int[] arr = new int[] { 1, 44, 100 };

int[] arr2 = arr;

arr2[1] = 55;

Console.WriteLine(string.Join(",", arr2));
Console.WriteLine(string.Join(",", arr));

//*******************************

int number = 30;

IncreaseValue(number);

Console.WriteLine(number);

void IncreaseValue(int a)
{
    a++;
}

List<int> ls = new() { 13, 42, 108 };

AddValue(ls);

Console.WriteLine(string.Join(",", ls));

void AddValue(List<int> list)
{
    list.Add(700);
}