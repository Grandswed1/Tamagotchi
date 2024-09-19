Console.WriteLine("Welcome!");
Console.WriteLine("Try to take good care of this thing.");

littlething myThing = new littlething();

Console.WriteLine("Write what you would like to name it.");
myThing.name = Console.ReadLine();

Console.WriteLine($"Coolio! {myThing.name} is a really coolio name!");

while (myThing.GetAlive() == true)
{
    Console.Clear();
    myThing.PrintStats();
    Console.WriteLine("How would you lke to proceed?");
    Console.WriteLine($"1. Try to teach {myThing.name} a new little word");
    Console.WriteLine($"2. Try to talk to {myThing.name}");
    Console.WriteLine($"3. Try to make {myThing.name} starve less");
    Console.WriteLine($"4. Don't do anything");

    string doWhat = Console.ReadLine();
    if (doWhat == "1")
    {
        Console.WriteLine("What word would you like to teach it?");
        string word = Console.ReadLine();
        myThing.Teach(word);
    }

    if (doWhat == "2")
    {
        myThing.Hi();
    }

    if (doWhat == "3")
    {
        myThing.Feed();
    }
    else
    {
        Console.WriteLine("Doing nothing...");
    } 

    myThing.Tick();
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();

}

Console.WriteLine($"SHIT!! {myThing.name} died!");
Console.WriteLine("Press enter to exit");
Console.ReadLine();