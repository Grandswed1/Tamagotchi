using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Xml;

public class littlething
{
    private int starvation;
    private int boredom;
    public bool isAlive;
    private List<string> words = new List<string>() { "Idiot" };
    public string name;

    public littlething()
    {
        isAlive = true;
    }


    public void Feed()
    {
        Console.WriteLine($"[{name}] eats and is not hungry");
        starvation -= 2;
        if (starvation < 0)
        {
            starvation = 0;
        }
    }

    public void Hi()
    {
        int wordNum = Random.Shared.Next(words.Count);
        Console.WriteLine($" [{name}] says: {words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine("I am learning " + word);
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        starvation++;
        boredom++;
        if (starvation > 5 || boredom > 5)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine("My name is " + name);
        Console.WriteLine("My hunger is " + starvation);
        Console.WriteLine("My boredome is "+ boredom);
        Console.WriteLine("I know " + words.Count + " words");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void ReduceBoredom()
    {
        Console.WriteLine($" [{name}] is now a little less bored");
        boredom -=2;
        if (boredom < 0)
        {
            boredom = 0;
        } 
    }

}
