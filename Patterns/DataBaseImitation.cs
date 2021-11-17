using Patterns.Enums;

namespace Patterns
{
    /// <summary>
    /// Имитация БД, Singletone
    /// </summary
    public class DataBaseImitation
    {
        private DataBaseImitation()
        {
            
        }
        private static DataBaseImitation _instance;
        public static DataBaseImitation GetInstance()
        {
            if ( _instance == null ) _instance = new DataBaseImitation();
            return _instance;
        }

        public decimal GetEarPodsPrice(EarPodsConnection connection)
        {
            if ( connection == EarPodsConnection.MiniJack ) return 1800.00m;
            else return 2300.00m;
        }
        public decimal GetAdapterPrice(AdapterAmperage amperage)
        {
            if ( amperage == AdapterAmperage.PointFiveAmpere ) return 500.00m;
            else return 1500.00m;
        }
        public decimal GetCablePrice(CableConnection connection)
        {
            if ( connection == CableConnection.Lightning ) return 490.00m;
            else return 150.00m;
        }
        public decimal GetPhonePackPrice(PhoneModel model)
        {
            if ( model == PhoneModel.IPhoneXS ) return 45000.00m;
            else if ( model == PhoneModel.IPhone7s ) return 20000.00m;
            else return 2500.00m;
        }

    }
}
