using Patterns.AbstractFactories.Interfaces;
using Patterns.Entities;

namespace Patterns
{
    /// <summary>
    /// Класс, собирающий комплектующие в конечный продукт для продажи
    /// </summary>
    public class PhonePackBuilder
    {
        public PhonePackBuilder(IPnonePackFactory packFactory)
        {
            _packFactory = packFactory;
        }
        IPnonePackFactory _packFactory;

        public PhonePack CreatePhonePack()
        {
            return new PhonePack(_packFactory.CreatePhone(), _packFactory.CreateCharger(), _packFactory.CreateEarPods());
        }

    }
}
