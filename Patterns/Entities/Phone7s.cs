using Patterns.Enums;
using Patterns.Entities.AbstractClasses;

namespace Patterns.Entities
{
    // <summary>
    /// Сущность телефона IPhone7s
    /// </summary>
    public class Phone7s : BaseIPhone
    {
        public Phone7s()
        {
            Model = PhoneModel.IPhone7s;
            EarPodsConnection = EarPodsConnection.Lightning;
            CableConnection = CableConnection.Lightning;
            AdapterAmperage = AdapterAmperage.PointFiveAmpere;
        }

        private Phone7s(Phone7s phone)
            : base(phone) { }
    
        public override object Clone()
        {
            return new Phone7s(this);
        }

        public override Phone7s MyClone()
        {
            return new Phone7s(this);
        }
    }
}
