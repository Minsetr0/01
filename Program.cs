Console.WriteLine("Что вы хотите написать?");
string message = Console.ReadLine();
Console.WriteLine("Сколько раз?");
int repeats = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < repeats; i++)

{
    Console.WriteLine(message);
}