//Conditional Statement => IF and SWITCH

using Csharp.Conditional.Statement;

int a = -1;

if (a > 5 && a < 10 && a % 2 == 0)
{
    Console.WriteLine($"a > 5 and < 10 and chia het 2 {a}");
}
else if (a > 10)
{
    Console.WriteLine($"a > {a} and a < 20");
}
else if (a > 20)
{
    Console.WriteLine($"a > {a}");
}
else
{
    //Console.WriteLine("a is another case");
}


string msg = a > 5 && a < 10 && a % 2 == 0 ? $"a > 5 and < 10 and chia het 2 {a}"
                                           : a > 10 ? $"a > {a} and a < 20"
                                                      : a > 20 ? $"a > {a}" 
                                                                : "a is another case";

//Console.WriteLine(msg);


//ternary operator

int GetTotalNumber(List<int> numbers)
{

    //if (numbers is null) return default;

    //if(numbers is not null)
    //{
    //    //do something
    //    return numbers.Sum();
    //}

    return numbers is not null ? numbers.Sum() : default;

    // dk ? cv1 : cv2;

    //return default;
}


//int GetTotalNumber(List<int> numbers) => numbers is not null ? numbers.Sum() : default;


List<int> list = null;

var value = GetTotalNumber(list);

//Console.WriteLine(value);   

SwitchStatement SwitchStatement = new SwitchStatement();