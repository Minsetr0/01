Console.WriteLine("Что вы хотите написать?");
string message = Console.ReadLine();
Console.WriteLine("Сколько раз?");
int howManyTimes = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < howManyTimes; i++)
{
    Console.WriteLine(message);
}