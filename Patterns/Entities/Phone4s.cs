using Patterns.Enums;
using Patterns.Entities.AbstractClasses;

namespace Patterns.Entities
{
    // <summary>
    /// Сущность телефона IPhone4s
    /// </summary>
    public class Phone4s : BaseIPhone
    {
        public Phone4s()
            : base() 
        {
            Model = PhoneModel.IPhone4s;
            EarPodsConnection = EarPodsConnection.MiniJack;
            CableConnection = CableConnection.DXP30Pin;
            AdapterAmperage = AdapterAmperage.PointFiveAmpere;
        }

        public Phone4s(Phone4s phone)
            : base(phone) { }
    
        public override object Clone()
        {
            return new Phone4s(this);
        }

        public override Phone4s MyClone()
        {
            return new Phone4s(this);
        }
    }
}
