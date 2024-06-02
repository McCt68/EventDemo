// See https://aka.ms/new-console-template for more information
using EventDemo;
using System.Reflection.Metadata;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hero event Program\n");

        // Subscriber
        // The subscriber is any class that :

        // Subscribes to the Event: It attaches event handler methods to the event using the += syntax.
        // Handles the Event: It defines methods that match the event's delegate signature to handle the event when it is raised.

        Hero myFirstHero = new Hero
        {
            Id = 1,
            Name = "Egon",
            Health = 100
        };

        Hero mySecondHero = new Hero
        {
            Id = 2,
            Name = "Benny",
            Health = 80
        };

        myFirstHero.OnHealthChanged += HeroOnHealthChanged;  
        mySecondHero.OnHealthChanged += HeroOnDeath;  
        
        myFirstHero.Health = 55;
        mySecondHero.Health = mySecondHero.Health - 100;
    }

    private static void HeroOnDeath(object? sender, int e)
    {
        var hero = (Hero)sender;
        Console.WriteLine($"Hero {hero.Name} faldt ned fra en klippe");
        Console.WriteLine($"Hero {hero.Name} og har nu {hero.Health} liv points og er død\n");
    }

    public static void HeroOnHealthChanged(object? sender, int e)
    {
        // sender er den instans der notificerer mig at dens state der representerer health er ændret
        var hero = (Hero)sender;
        Console.WriteLine($"Hero {hero.Name} Fik et slag i maven");
        Console.WriteLine($"Hero {hero.Name} har nu {hero.Health} livpoints\n");
    }
}