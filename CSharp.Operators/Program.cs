// Operators

// +, -, *, /, %

//Console.WriteLine(10 % 3);

//++, -- ---> 1

using System.Text;
using System.Text.RegularExpressions;

//Console.WriteLine(Regex.Replace("adcvc。sewfsd(、、)", @"。|\(、、\)", ""));


int a = 2;

//Console.WriteLine(a--); //2

//Console.WriteLine(--a); //1 -1 = 0

//==, !=, >, >=, <, <=


int x = 100,
    y = 120;

string str = "hello",
       str1 = "Hello";

//Console.WriteLine("x == y: {0}", x == y);  //true/false

//Console.WriteLine("str == str1: {0}", str.Equals(str1));

//Console.WriteLine(2 > 5);

//Console.WriteLine(5 >= 5);

//Console.WriteLine(5 < 5);

//Console.WriteLine(2 <= 5);

Console.WriteLine("****************************************");

//Equals vs ==

object chuoi = "abc";

object chuoi2 = string.Join("", new char[] { 'a','b','c' });

//Console.WriteLine(chuoi == chuoi2);

//Console.WriteLine(chuoi.Equals(chuoi2));


//string, object

//Compound Assigment

int z = 10;

z += 1; // z++ or ++z or z = z + 1
//Console.WriteLine(z);

z /= 2;  //z = z / 2;
//Console.WriteLine(z);

z %= 3;
//Console.WriteLine(z);

// AND && - OR || operator

// AND tất cả đk = true -> true. ngược lại --> false    --> tất cả cùng
Console.WriteLine(15 > 10 && 10 > 5 && true);
Console.WriteLine(15 > 10 && 10 > 5 && false);
Console.WriteLine(15 < 10 && 10 > 5 && true);
Console.WriteLine(5 < 10 && 10 > 5 && false);

//OR --> chỉ cần 1 đk true --> true.                    --> chỉ 1 đơn lẻ

//true      true    true
Console.WriteLine(15 > 10 || 10 > 5 || true);
                   //true      false    false
Console.WriteLine(15 > 10 || 10 < 5 || false);
                  //false    true     true
Console.WriteLine(15 < 10 || 10 > 5 || true);
                   //false    false    false
Console.WriteLine(15 < 10 || 10 > 15 || false);


// &, |, ^, << (shift left), >> (shift right) ...  --> bit  01001  --> low level programing


int k = 35; //10001100   = 1*2^7 + 0*2^6 + 0*2^5 +  0*2^4 +  1*2^3 +  1*2^2 +  0*2^1 +  0*2^0 

Console.WriteLine(Convert.ToString(k, 2));
//Console.WriteLine(k >> 2); //1000 --> 35

bool b = true;  //hexadecimal 

Console.WriteLine(!b);




