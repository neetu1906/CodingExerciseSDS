using System;
using DeveloperSample.ClassRefactoring;  

class Program
{
    static void Main(string[] args)
    {
        
        SwallowFactory factory = new SwallowFactory();

        
        var africanSwallow = factory.GetSwallow(SwallowType.African);
        Console.WriteLine($"African Swallow Airspeed Velocity: {africanSwallow.GetAirspeedVelocity()}");

        
        africanSwallow.ApplyLoad(SwallowLoad.Coconut);
        Console.WriteLine($"Laden African Swallow Airspeed Velocity: {africanSwallow.GetAirspeedVelocity()}");

        
        var europeanSwallow = factory.GetSwallow(SwallowType.European);
        Console.WriteLine($"European Swallow Airspeed Velocity: {europeanSwallow.GetAirspeedVelocity()}");

        
        europeanSwallow.ApplyLoad(SwallowLoad.Coconut);
        Console.WriteLine($"Laden European Swallow Airspeed Velocity: {europeanSwallow.GetAirspeedVelocity()}");
    }
}
