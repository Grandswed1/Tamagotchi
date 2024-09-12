Console.WriteLine("Welcome!");
Console.WriteLine("Try to take good care of this thing.");

littlething myThing = new littlething();

Console.WriteLine("Write what you would like to name it.");
myThing.name = Console.ReadLine();

Console.WriteLine($"Coolio! {myThing.name} is a really coolio name!");

while (myThing.GetAlive() == true)
{

}