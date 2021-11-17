using Patterns.Enums;

namespace Patterns
{
    public static class Helper
    {
        public static string AmparegeToString(AdapterAmperage amperage)
        {
            if ( amperage == AdapterAmperage.PointFiveAmpere ) return "0.5 A";
            else return "2.4 A";
        }
    }
}
