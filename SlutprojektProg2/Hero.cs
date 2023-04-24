using System;
using System.Collections.Generic;


public class Hero 
{
    private int health;
    //Int som håller koll på hjältens hälsa.

    private int stamina;
    //Int som håller koll på hjältens stamina.

    private int damage;
    //Int som håller koll på hjältens attackstyrka.

    //public List<string> weapons = new List<string>() {""};

    public string name;
    //String som innehåller hjältens namn.

    private Random generator;

    private bool isDead;
    //Bool som innehåller information om hjälten är död eller inte.

    public Hero()
    {
        generator = new Random();
        isDead = false;
    }

    public void Attack()
    {
        if (stamina >= 15)
        {
        stamina -= 15;
        
        Console.WriteLine($"[{name}] attacks!");
        }
    }
    //Funktion som minskar motståndarens hp med samma mängd som hjältens attackstyrka, samt tar bort en del av hjältens stamina.
    
    public void Heal()
    {
        if (stamina >= 10)
        {
        stamina -= 10;
        
        Console.WriteLine($"[{name}] is healed.");
        health += 20;
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
    //Funktion som återställer en bit av hjältens hälsa samt tar bort en del av hjältens stamina. Funktionen fungerar endast om tillräckligt med stamina finns.

    public void Round()
    {
        stamina+= 5;
        if (health <= 0)
        {
            isDead = true;
        }

        if (stamina < 0)
        {
            stamina = 0;
        }
    }

    public void Resting()
    {
        Console.WriteLine($"[{name}] calms down and regains some stamina.");
        stamina += 20;
        if (stamina > 100)
        {
            stamina = 100;
        }
    }
    

}