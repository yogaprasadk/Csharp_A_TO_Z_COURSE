// loop through an array using foreach



string[] str = { "ravana", "raman" };
foreach (String name in str)
{
    Console.WriteLine(name);
}
 
// sum 
int sum = 0;
int[] inventory = { 420, 450, 678 };
foreach (int ans in inventory)
{
    sum += ans;
}

Console.WriteLine(sum);

string nam = "Bob";
if (nam.StartsWith("B"))
{
    Console.WriteLine("start with B");

}

//Equality Operator
Console.WriteLine("a" == "a");

string myValue = "a";
Console.WriteLine("A" == myValue);

//Improve the check for string equality using the string's built-in helper methods

Console.WriteLine("A" == "A ");

string ansV = " A";
string ansW = "A ";
Console.WriteLine(ansV.Trim().ToLower() == ansW.Trim().ToLower());

// Logical NEgation Operator
string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine($"Boolean: {!pangram.Contains("fox")}");

// Conditiona; operator
int salesAmount = 435;
Console.WriteLine($"Discount: {(salesAmount > 34 ? true : false)}");


int[] numbers = { 4, 86, 25, 234, 23, 42 };
int total = 0;
bool flag = false;
foreach (var item in numbers)
{

    total = total + item;
    if (item == 42)
    {
        flag = true;
    }
}

if (flag)
{
    Console.WriteLine("set contains 42");
}
Console.WriteLine(total);

int devel = 100;
string ename = "John Smith";

string j = "";

switch (devel)
{
    case 100:
    case 200:
        j = "senior";
        break;
    case 300:
        j = "junior";
        break;
    default:
        break;
}
Console.WriteLine($"{ename},{j}");

