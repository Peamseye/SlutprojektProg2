using System;

Console.WriteLine("Start");
Console.ReadLine();

Console.Clear();

Hero h1 = new Hero();

bool playername = true;

while (playername == true) {
Console.WriteLine("What is the name of your hero?");
Console.Clear();
Console.WriteLine("ENTER NAME");
h1.name = Console.ReadLine();

playername = false;
}

Console.WriteLine($"Your hero's name is [{h1.name}].");

while (h1.GetHeroAlive() == true)
{
    Console.Clear();
    h1.HeroStatus();
}
Console.ReadLine();
