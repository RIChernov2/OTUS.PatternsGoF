using Patterns.Entities;
using Patterns.Factories.Interfaces;
using Patterns.Entities.AbstractClasses;

namespace Patterns.Factories
{
    /// <summary>
    /// Фабрика, создающая телефон IPnone4s
    /// </summary>
    public class Phone4sFactory : IPhoneFactory
    {
        public BaseIPhone CreatePhone() => new Phone4s();
    }
}
