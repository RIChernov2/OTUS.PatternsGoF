using Patterns.Entities.AbstractClasses;
using Patterns.Entities.Interfaces;
using Patterns.Enums;
using System;

namespace Patterns.Entities
{
    /// <summary>
    /// Комплектация телефона, который продается в магазине
    /// </summary>
    public class PhonePack: IMyCloneable<PhonePack>, ICloneable, IMyCloneable<Charger>, IMyCloneable<EarPods>
    {
        public PhonePack(BaseIPhone phone, Charger charger, EarPods earPods )
        {
            Phone = phone;
            Charger = charger;
            EarPods = earPods; 
            _price = DataBaseImitation.GetInstance().GetPhonePackPrice(phone.Model);
        }

        public PhonePack(PhonePack phonePack)
            : this(phonePack.Phone.MyClone(), phonePack.Charger.MyClone(), phonePack.EarPods.MyClone()) { }
        private BaseIPhone Phone { get; }
        private Charger Charger { get; }
        private EarPods EarPods { get; }
        private decimal _price;

        public virtual PhonePack MyClone() => new PhonePack(this);
        public virtual object Clone() => new PhonePack(this);
        Charger IMyCloneable<Charger>.MyClone() => Charger.MyClone();
        EarPods IMyCloneable<EarPods>.MyClone() => EarPods.MyClone();
        public bool GiftIsOk => Phone.Model == PhoneModel.IPhone7s || Phone.Model == PhoneModel.IPhoneXS;

        public void Print()
        {
            Phone.PrintInfo();
            Charger.PrintInfo();
            EarPods.PrintInfo();
            Console.WriteLine($">>> Price {_price}");
            Console.WriteLine(Environment.NewLine);
        }
     }
}
