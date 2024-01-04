using System;
using DeveloperSample.Container; 

class Program
{
    static void Main(string[] args)
    {
        
        Container container = new Container();

        
        container.Bind(typeof(IService), typeof(ServiceImpl));

        
        IService serviceInstance = container.Get<IService>();

        
        if (serviceInstance != null)
        {
            Console.WriteLine("Successfully retrieved an instance of IService.");
            
        }
        else
        {
            Console.WriteLine("Failed to retrieve an instance of IService.");
        }
    }
}


public interface IService
{
    void Execute();
}

public class ServiceImpl : IService
{
    public void Execute()
    {
        Console.WriteLine("Service Executed");
    }
}
