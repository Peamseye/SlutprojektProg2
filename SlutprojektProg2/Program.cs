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



//While-funktion som begränsar spelarens framsteg tills den har fyllt in ett tillåtet svar.
while (h1.name != "a" && h1.name != "A" && h1.name != "b" && h1.name != "B" && h1.name != "c" && h1.name != "C"){
Console.Clear();
Console.WriteLine("WRITE THE LETTER CORRESPONDING TO THE HERO");
Console.WriteLine("A, B or C");

Console.WriteLine();
Console.WriteLine("Choose a hero:");
Console.WriteLine("a) Arthur");
Console.WriteLine("b) Edward");
Console.WriteLine("c) Henry");
Console.WriteLine();

h1.name = Console.ReadLine();
}

if (h1.name == "a" || h1.name == "A") {
    h1.name = "ARTHUR";
    
}
if (h1.name == "b" || h1.name == "B") {
    h1.name = "EDWARD";
}
if (h1.name == "c" || h1.name == "C") {
    h1.name = "HENRY";
}

Console.Clear();
Console.WriteLine($"Your hero's name is [{h1.name}].");

Console.Clear();
Console.WriteLine("You face an enemy!");
Console.ReadLine();

Console.Clear();
Console.WriteLine();
Console.WriteLine($"What will [{h1.name}] do?");
Console.WriteLine();
Console.WriteLine();


while (h1.GetHeroAlive() == false){

//While-funktion som begränsar spelarens framsteg tills den har fyllt in ett tillåtet svar.
while (h1.PlayerMove != "a" && h1.PlayerMove != "A" && h1.PlayerMove != "b" && h1.PlayerMove != "B" && h1.PlayerMove != "c" && h1.PlayerMove != "C"){
Console.Clear();

Console.WriteLine();
Console.WriteLine("Choose an Action:");
Console.WriteLine("a) ATTACK");
Console.WriteLine("b) HEAL");
Console.WriteLine("c) REST");
Console.WriteLine();
Console.WriteLine("Write the letter corresponding to the Action.");

h1.HeroStatus();

h1.PlayerMove = Console.ReadLine();
}

if (h1.PlayerMove == "a" || h1.PlayerMove == "A") {
    h1.Attack();
    h1.PlayerMove = ".";
    Console.ReadLine();
    
    
}
if (h1.PlayerMove == "b" || h1.PlayerMove == "B") {
    h1.Heal();
    h1.PlayerMove = ".";
    Console.ReadLine();
    
}
if (h1.PlayerMove == "c" || h1.PlayerMove == "C") {
    h1.Rest();
    h1.PlayerMove = ".";
    Console.ReadLine();
    
}

h1.Round();
}


Console.WriteLine($"{h1.name} died!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();