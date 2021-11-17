using Patterns.AbstractFactories.Interfaces;
using Patterns.Entities;
using Patterns.Entities.AbstractClasses;
using Patterns.Enums;

namespace Patterns.AbstractFactories
{
    /// <summary>
    /// Фабрика, создающая комплектующие телефона IPnoneXS
    /// </summary
    public class PhoneXSPackFactory: IPnonePackFactory
    {
        public BaseIPhone CreatePhone() => new PhoneXS();
        public Charger CreateCharger() 
            => new Charger()
            .SetAdapter(new Adapter(AdapterAmperage.TwoPoinFourAmpere))
            .SetCable(new Cable(CableConnection.Lightning));

        public EarPods CreateEarPods()
            => new EarPods(EarPodsConnection.Lightning);
    }
}
