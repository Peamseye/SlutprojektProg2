using System;

Console.WriteLine("Start");
Console.ReadLine();

Console.Clear();

Hero h1 = new Hero();

Console.WriteLine("What is the name of your hero?");
h1.name = Console.ReadLine();

Console.WriteLine($"Your hero's name is [{h1.name}].");

while (h1.GetHeroAlive() == true)
{
    Console.Clear();
    h1.HeroStatus();
}