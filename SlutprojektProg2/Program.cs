using System;

Console.WriteLine("Start");
Console.ReadLine();

Console.Clear();

Hero h1 = new Hero();




Console.Clear();
Console.WriteLine();
Console.WriteLine("Choose a hero:");
Console.WriteLine("a) Arthur");
Console.WriteLine("b) Jacob");
Console.WriteLine("c) Henry");
Console.WriteLine();
Console.WriteLine("Write the letter corresponding to the hero.");


//While-funktion som begränsar spelarens framsteg tills den har fyllt in ett tillåtet svar.
while (h1.name != "a" && h1.name != "A" && h1.name != "b" && h1.name != "B" && h1.name != "c" && h1.name != "C"){
Console.Clear();
Console.WriteLine();
Console.WriteLine("Choose a hero:");
Console.WriteLine("a) Arthur");
Console.WriteLine("b) Jacob");
Console.WriteLine("c) Henry");
Console.WriteLine();
Console.WriteLine("Write the letter corresponding to the hero.");

h1.name = Console.ReadLine();
}

if (h1.name == "a" || h1.name == "A") {
    h1.name = "Arthur";
}
if (h1.name == "b" || h1.name == "B") {
    h1.name = "Jacob";
}
if (h1.name == "c" || h1.name == "C") {
    h1.name = "Henry";
}


Console.WriteLine($"Your hero's name is [{h1.name}].");

while (h1.GetHeroAlive() == true)
{
    Console.Clear();
    h1.HeroStatus();
}
Console.ReadLine();
