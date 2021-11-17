using System;
using Patterns.Enums;
using Patterns.Entities.Interfaces;

namespace Patterns.Entities
{
    /// <summary>
    /// Наушники для телефона 
    /// </summary>
    public class EarPods : IMyCloneable<EarPods>, ICloneable
    {
        public EarPods(EarPodsConnection connection)
        {
            _connection = connection;
            _price = DataBaseImitation.GetInstance().GetEarPodsPrice(connection);
        }

        private EarPods(EarPods earPods)
            : this(earPods._connection) { }


        private EarPodsConnection _connection;
        private decimal _price;
        private string ConvertConnection => Enum.GetName(_connection);

        public void Print()
        {
            System.Console.WriteLine($"EarPods ( {ConvertConnection} ) price = {_price}");
        }
        public void PrintInfo() => Console.WriteLine($"* EarPods ( {ConvertConnection} )");

        public virtual EarPods MyClone()
        {
            return new EarPods(this);
        }

        public virtual object Clone()
        {
            return new EarPods(this);
        }
    }
}
