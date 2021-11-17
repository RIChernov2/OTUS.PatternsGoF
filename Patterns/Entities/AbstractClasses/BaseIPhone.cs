using System;
using Patterns.Entities.Interfaces;
using Patterns.Enums;

namespace Patterns.Entities.AbstractClasses
{
    /// <summary>
    /// Абстракция телефона
    /// </summary>
    public abstract class BaseIPhone: IMyCloneable<BaseIPhone>, ICloneable
    {
        public BaseIPhone()
        {
            Model = PhoneModel.IPhone4s;
            EarPodsConnection = EarPodsConnection.MiniJack;
            CableConnection = CableConnection.DXP30Pin;
            AdapterAmperage = AdapterAmperage.PointFiveAmpere;
        }
        public BaseIPhone(BaseIPhone phone)
        {
            this.SetModel(phone.Model);
            this.SetEarPodsConnection(phone.EarPodsConnection);
            this.SetCableConnection(phone.CableConnection);
            this.SetAdapterAmperage(phone.AdapterAmperage);
        }

        public PhoneModel Model { get; protected set; }
        public EarPodsConnection EarPodsConnection { get; protected set; }
        public CableConnection CableConnection { get; protected set; }
        public AdapterAmperage AdapterAmperage { get; protected set; }

        protected BaseIPhone SetModel(PhoneModel model)
        {
            Model = model;
            return this;
        }
        protected BaseIPhone SetEarPodsConnection(EarPodsConnection connection)
        {
            EarPodsConnection = connection;
            return this;
        }
        protected BaseIPhone SetCableConnection(CableConnection connection)
        {
            CableConnection = connection;
            return this;
        }
        protected BaseIPhone SetAdapterAmperage(AdapterAmperage amperage)
        {
            AdapterAmperage = amperage;
            return this;
        }

        public abstract object Clone();
        public abstract BaseIPhone MyClone();
       
        public void Print()
        {
            System.Console.WriteLine
                (
                    "Phone parameters:\n" +
                    $"* Model - {Enum.GetName(Model)}\n" +
                    $"* EarPodsConnection - {Enum.GetName(EarPodsConnection)}\n"+
                    $"* CableConnection - {Enum.GetName(CableConnection)}\n" +
                    $"* AdapterAmperage - {Helper.AmparegeToString(AdapterAmperage)}\n"
                );
        }

        public void PrintInfo() => Console.WriteLine($"* Model - {Enum.GetName(Model)}");
    }
}
