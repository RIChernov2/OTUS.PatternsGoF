using System;
using Patterns.Enums;
using Patterns.Entities.Interfaces;

namespace Patterns.Entities
{
    /// <summary>
    /// Кабель зарядного устройства 
    /// </summary>
    public class Cable : IMyCloneable<Cable>, ICloneable
    {

        public Cable(CableConnection connection)
        {
            _connection = connection;
            _price = DataBaseImitation.GetInstance().GetCablePrice(connection);
        }

        private Cable(Cable earPods)
            : this(earPods._connection) { }

        private CableConnection _connection;
        private decimal _price;
        public string ConnectionType => Enum.GetName(_connection);

        public void Print()
        {
            System.Console.WriteLine($"Cable ( {ConnectionType} ) price = {_price}");
        }

        public virtual Cable MyClone()
        {
            return new Cable(this);
        }

        public virtual object Clone()
        {
            return new Cable(this);
        }
    }
}
