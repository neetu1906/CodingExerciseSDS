using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        private readonly AirspeedVelocityCalculator _airspeedCalculator;

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
            _airspeedCalculator = new AirspeedVelocityCalculator();
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            return _airspeedCalculator.CalculateAirspeed(Type, Load);
        }
    }

    public class AirspeedVelocityCalculator
    {
        public double CalculateAirspeed(SwallowType type, SwallowLoad load)
        {
            // Logic can be extended or modified independently
            if (type == SwallowType.African)
            {
                return load == SwallowLoad.None ? 22 : 18;
            }
            else if (type == SwallowType.European)
            {
                return load == SwallowLoad.None ? 20 : 16;
            }

            throw new InvalidOperationException("Unknown airspeed for this type of swallow.");
        }
    }
}
