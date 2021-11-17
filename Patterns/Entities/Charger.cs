using Patterns.Enums;
using Patterns.Entities.Interfaces;
using System;

namespace Patterns.Entities
{
    /// <summary>
    /// Зарядное устройство для телефона 
    /// </summary>
    public class Charger: IMyCloneable<Charger>, IMyCloneable<Adapter>, IMyCloneable<Cable>, ICloneable
    {
        public Charger()
        {
            _adapter = new Adapter(AdapterAmperage.PointFiveAmpere);
            _cable = new Cable(CableConnection.DXP30Pin);
        }

        private Charger(Charger charger)
        {
            this.SetAdapter(charger._adapter);
            this.SetCable(charger._cable);
        }

        Adapter _adapter;
        Cable _cable;

        public Charger SetAdapter(Adapter adapter)
        {
            if ( adapter is null )
            {
                Console.WriteLine("Параметр adapter не можэет быть NULL");
                throw new ArgumentException();
            }
            _adapter = adapter.MyClone();
            return this;
        }

        public Charger SetCable(Cable cable)
        {
            if ( cable is null )
            {
                Console.WriteLine("Параметр cable не можэет быть NULL");
                throw new ArgumentException();
            }
            _cable = cable.MyClone();
            return this;
        }

        public virtual Charger MyClone()
        {
            return new Charger(this);
        }
        public virtual object Clone()
        {
            return new Charger() 
            {
                _adapter = (Adapter)this._adapter.Clone(), _cable = (Cable)this._cable.Clone() 
            };
        }

        Adapter IMyCloneable<Adapter>.MyClone() => _adapter.MyClone();
        Cable IMyCloneable<Cable>.MyClone() => _cable.MyClone();

        public void Print()
        {
            System.Console.WriteLine
                (
                    "Charger paremeters:\n" +
                    $"* Adapter - {_adapter.AmperageValue}\n"+
                    $"* Cable - {_cable.ConnectionType}\n"
                );
        }
        public void PrintInfo()
        {
            System.Console.WriteLine
                (
                    $"* Adapter - {_adapter.AmperageValue}\n" +
                    $"* Cable - {_cable.ConnectionType}"
                );
        }
    }
}
