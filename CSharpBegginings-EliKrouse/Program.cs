

/*This is just me testing syntax in C#, as a certified Java dev... I feel like some things could be
written diffrernetly, so this isnt like a perfect program or anything. I do say, I kinda love being
deep in code more than building apps, but I also really love the aesthetic building section of apps UGH,
but enoguh about me. Here is the random code:
*/

string str1 = "Eli Krouse";
int age = 20;
double height = 69.87; //not true I dont think.

Console.WriteLine(str1);
Console.WriteLine($"Yes my name is {str1}"); //C# version of swift's internal variable?
Console.WriteLine(age + " is my age"); //Classic Java concatination
Console.Write("I think my height it ");// print vs println
Console.WriteLine(height);

Console.WriteLine();
Console.WriteLine($"After my birthday Ill be {++age}");//question: does it increment while inside quotes? Answer: yes

Console.WriteLine("How old are you?");
string? input = Console.ReadLine();//scanner moment, much more simple too huh

if (int.TryParse(input, out int number)) //Parse also exists, but you should always practice saftey. Does Try-Catch exist?
{
    Console.WriteLine("Ohh, so you're " + number);
}
else
{
    Console.WriteLine("That's not an integer...");
}

try // try catch or try parse? what's the point?
{
    int number2 = int.Parse(input);
    Console.WriteLine("Test 2 = " + number2);
}
catch
{
    Console.WriteLine("Didnt work either");
}