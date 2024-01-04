using System;
using DeveloperSample.Container;  // Replace with the actual namespace of Container.cs

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Container
        Container container = new Container();

        // Assuming you have some interfaces and their implementations
        // For example, let's say you have an IService interface and a ServiceImpl class

        // Bind the interface to the implementation
        container.Bind(typeof(IService), typeof(ServiceImpl));

        // Retrieve an instance of IService
        IService serviceInstance = container.Get<IService>();

        // Use the service instance for demonstration
        if (serviceInstance != null)
        {
            Console.WriteLine("Successfully retrieved an instance of IService.");
            // Add any additional logic to use the serviceInstance
        }
        else
        {
            Console.WriteLine("Failed to retrieve an instance of IService.");
        }
    }
}

// Example interface and class
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
