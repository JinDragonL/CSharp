// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// COLLECTION

string name = "Robot";

int number = 100;

double quantity = 50;

DateTime date = new DateTime(2022, 10, 10);


//Array


int[] numbers = new int[5]; //0[20], 1, 2, 3[30], 4

numbers[0] = 20;

numbers[3] = 30;

int maxArray = numbers.Length;

//number[10] = 38;

int value = numbers[3];

string[] names = new { }; //0,1,2

Console.WriteLine(names.Length);

//names[2] = "A";

//names[4] = "B";

int[,] array = new int[3, 2];


array[0, 1] = 70;
//array[3, 7] = 70;

Console.WriteLine(array[2, 1]);

int[,] array2 = new int[,] { { 3, 6 }, { 67, 20 }, { 15, 92 } };

Console.WriteLine(array2[2, 0]);

//jagged array

int[][] jagged = new int[2][]; //0,1

jagged[1] = new int[] { 56, 100, 855 };
jagged[3] = new int[] { 56, 100, 855 };

Console.WriteLine(string.Join(" ", jagged[1]));

//advantage
// - easy and fast
//disadvantage
// - size 
// - small -> throw exception, too large

