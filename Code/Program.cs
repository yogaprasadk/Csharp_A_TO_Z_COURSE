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