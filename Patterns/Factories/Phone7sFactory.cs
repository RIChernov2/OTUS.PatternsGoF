using Patterns.Entities;
using Patterns.Factories.Interfaces;
using Patterns.Entities.AbstractClasses;

namespace Patterns.Factories
{
    /// <summary>
    /// Фабрика, создающая телефон IPnone7s
    /// </summary>
    public class Phone7sFactory : IPhoneFactory
    {
        public BaseIPhone CreatePhone() => new Phone7s();
    }
}
