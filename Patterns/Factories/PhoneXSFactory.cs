using Patterns.Entities;
using Patterns.Factories.Interfaces;
using Patterns.Entities.AbstractClasses;

namespace Patterns.Factories
{
    /// <summary>
    /// Фабрика, создающая телефон IPnoneXS
    /// </summary>
    public class PhoneXSFactory : IPhoneFactory
    {
        public BaseIPhone CreatePhone() => new PhoneXS();
    }
}
