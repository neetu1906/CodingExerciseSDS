using System;
using DeveloperSample.ClassRefactoring;  // Adjust the namespace if needed

class Program
{
    static void Main(string[] args)
    {
        // Create a swallow factory
        SwallowFactory factory = new SwallowFactory();

        // Create an African swallow with no load
        var africanSwallow = factory.GetSwallow(SwallowType.African);
        Console.WriteLine($"African Swallow Airspeed Velocity: {africanSwallow.GetAirspeedVelocity()}");

        // Apply load to the African swallow
        africanSwallow.ApplyLoad(SwallowLoad.Coconut);
        Console.WriteLine($"Laden African Swallow Airspeed Velocity: {africanSwallow.GetAirspeedVelocity()}");

        // Create a European swallow
        var europeanSwallow = factory.GetSwallow(SwallowType.European);
        Console.WriteLine($"European Swallow Airspeed Velocity: {europeanSwallow.GetAirspeedVelocity()}");

        // Apply load to the European swallow
        europeanSwallow.ApplyLoad(SwallowLoad.Coconut);
        Console.WriteLine($"Laden European Swallow Airspeed Velocity: {europeanSwallow.GetAirspeedVelocity()}");
    }
}
