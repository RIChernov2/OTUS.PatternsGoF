using Patterns.AbstractFactories.Interfaces;
using Patterns.Entities;
using Patterns.Entities.AbstractClasses;
using Patterns.Enums;

namespace Patterns.AbstractFactories
{
    /// <summary>
    /// Фабрика, создающая комплектующие телефона IPnone4s
    /// </summary>
    public class Phone4sPackFactory: IPnonePackFactory
    {
        public BaseIPhone CreatePhone() => new Phone4s();
        public Charger CreateCharger() 
            => new Charger()
            .SetAdapter(new Adapter(AdapterAmperage.PointFiveAmpere))
            .SetCable(new Cable(CableConnection.DXP30Pin));
        public EarPods CreateEarPods()
            => new EarPods(EarPodsConnection.MiniJack);
    }
}
