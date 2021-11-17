using System;
using Patterns.Enums;
using Patterns.Entities.Interfaces;

namespace Patterns.Entities
{
    /// <summary>
    /// Адаптер зарядного устройства 
    /// </summary>
    public class Adapter : IMyCloneable<Adapter>, ICloneable
    {
        public Adapter(AdapterAmperage amperage)
        {
            _amperage = amperage;
            _price = DataBaseImitation.GetInstance().GetAdapterPrice(amperage);
        }

        private Adapter(Adapter charger)
            : this(charger._amperage) { }


        private AdapterAmperage _amperage;
        private decimal _price;
        public string AmperageValue => Helper.AmparegeToString(_amperage);

        public void Print()
        {
            System.Console.WriteLine($"Charger ( {AmperageValue} ) price = {_price}");
        }

        public virtual Adapter MyClone()
        {
            return new Adapter(this);
        }

        public virtual object Clone()
        {
            return new Adapter(this);
        }
    }
}
