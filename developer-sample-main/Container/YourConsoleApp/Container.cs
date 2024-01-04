using System;
using System.Collections.Generic;
using System.Reflection;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> _typeBindings = new Dictionary<Type, Type>();

        public void Bind(Type interfaceType, Type implementationType)
        {
            if (interfaceType == null || implementationType == null)
                throw new ArgumentNullException("Interface or Implementation type cannot be null");

            if (!interfaceType.IsAssignableFrom(implementationType))
                throw new InvalidOperationException("The implementation type must be assignable to the interface type");

            _typeBindings[interfaceType] = implementationType;
        }

        public T Get<T>()
        {
            return (T)Get(typeof(T));
        }

        private object Get(Type type)
        {
            if (!_typeBindings.TryGetValue(type, out var implementationType))
                throw new InvalidOperationException("No binding found for the requested type");

            var constructorInfo = implementationType.GetConstructors().FirstOrDefault();

            if (constructorInfo == null)
                throw new InvalidOperationException("No suitable constructor found for the implementation type");

            var parameters = constructorInfo.GetParameters();
            if (parameters.Length == 0)
            {
                return Activator.CreateInstance(implementationType);
            }

            var parameterInstances = parameters.Select(param => Get(param.ParameterType)).ToArray();
            return constructorInfo.Invoke(parameterInstances);
        }
    }
}
