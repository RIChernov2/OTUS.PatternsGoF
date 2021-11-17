using Patterns.Enums;
using Patterns.Entities.AbstractClasses;

namespace Patterns.Entities
{
    // <summary>
    /// Сущность телефона IPhoneXS
    /// </summary>
    public class PhoneXS : BaseIPhone
    {
        public PhoneXS()
            : base() 
        {
            Model = PhoneModel.IPhoneXS;
            EarPodsConnection = EarPodsConnection.Lightning;
            CableConnection = CableConnection.Lightning;
            AdapterAmperage = AdapterAmperage.TwoPoinFourAmpere;
        }

        private PhoneXS(PhoneXS phone)
            : base(phone) { }
    
        public override object Clone()
        {
            return new PhoneXS(this);
        }

        public override PhoneXS MyClone()
        {
            return new PhoneXS(this);
        }
    }
}
