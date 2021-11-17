using Patterns.Entities;
using Patterns.Entities.AbstractClasses;

namespace Patterns.AbstractFactories.Interfaces
{
    /// <summary>
    /// Интерфейс абстрактной фабрики, создающей комплектующие телефонов
    /// </summary
    public interface IPnonePackFactory
    {
        BaseIPhone CreatePhone();
        Charger CreateCharger();
        EarPods CreateEarPods();
    }
}
