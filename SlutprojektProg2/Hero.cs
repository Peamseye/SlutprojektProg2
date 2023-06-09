using System;
using System.Collections.Generic;


public class Hero 
{
    //Int som håller koll på hjältens hälsa.
    protected int health { get; set; }

    //Int som håller koll på hjältens stamina.
    protected int stamina { get; set; }

    //Int som håller koll på hjältens attackstyrka.
    protected int damage { get; set; }

    //public List<string> weapons = new List<string>() {""};

    //String som innehåller hjältens namn.
    public string name;

    //String som sparar spelarens beslut under en runda.
    public string PlayerMove;

    private Random generator;

    //Bool som innehåller information om hjälten är död eller inte.
    public bool isAlive;

    //Slumpgenerator för specifikt klassen "Hero". Kollar även om boolen "isDead" är sant eller falsk, vilket används i koden för att kolla om spelaren har dött eller inte.
    public Hero()
    {
        generator = new Random();
        isAlive = false;
    }

    //Funktion som minskar motståndarens hp med samma mängd som hjältens attackstyrka, samt tar bort en del av hjältens stamina.
    public void Attack()
    {
        if (stamina >= 15)
        {
        stamina -= 15;
        
        Console.WriteLine($"[{name}] attacks!");
        }
        
    }
    
    //Funktion som återställer en bit av hjältens hälsa samt tar bort en del av hjältens stamina. Funktionen fungerar endast om tillräckligt med stamina finns.
    public void Heal()
    {
        if (stamina >= 10)
        {
        stamina -= 10;
        
        Console.WriteLine($"[{name}] is healed.");
        health += 30;
        if (health > 100)
        {
            health = 100;
        }
        }
        else 
        {
            Console.WriteLine($"[{name}] is too exhausted and cannot heal.");
        }
        
    }

    //Funktion som kollar om spelaren har tillräckligt med stamina för att fortsätta. Om spelaren inte har någon stamina kvar, så ändras isDead till true och spelet tar slut.
    public void Round()
    {
        stamina+= 5;
        health-= 20;
        if (health <= 0)
        {
            isAlive = true;
        }

        if (stamina < 0)
        {
            stamina = 0;
        }
    }

    public void HeroStatus()
    {
        Console.WriteLine($"Hero: {name} | Health: {health} | Stamina: {stamina}");
        
    }

    //Funktion som spelaren kan använda för att öka värdet på stamina under en runda. 
    public void Rest()
    {
        Console.WriteLine($"[{name}] calms down and regains some stamina.");
        stamina += 40;
        if (stamina > 100)
        {
            stamina = 100;
        }
        
    }

    public bool GetHeroAlive()
    {
        return isAlive;
    }

}