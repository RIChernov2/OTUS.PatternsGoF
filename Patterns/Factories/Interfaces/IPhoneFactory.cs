using Patterns.Entities.AbstractClasses;

namespace Patterns.Factories.Interfaces
{
    /// <summary>
    /// Интерфейс фабрики, создающей телефон
    /// </summary>
    public interface IPhoneFactory
    {
        public BaseIPhone CreatePhone();
    }
}
