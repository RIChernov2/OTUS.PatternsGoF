using System;
using Patterns;
using Patterns.AbstractFactories;
using Patterns.AbstractFactories.Interfaces;
using Patterns.Entities;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            string chosedName
                = Input(PrintNameRequestMessage, NameInputIsCorrect, PrintInputErrorMessage);

            string[] partnerName = chosedName == "1" ? _femaleName : _maleName;

            Console.WriteLine($"\n > {partnerName[0]} очень хочет себе айфон!!! \n");

            string chosedPhone
                = Input(PrintPhoneRequestMessage, PhoneInputIsCorrect, PrintInputErrorMessage);

            IPnonePackFactory factory;
            if ( chosedPhone == "1" ) factory = new Phone4sPackFactory();
            else if ( chosedPhone == "2" ) factory = new Phone7sPackFactory();
            else factory = new PhoneXSPackFactory();

            PhonePackBuilder builder = new PhonePackBuilder(factory);
            PhonePack yourIPhone = builder.CreatePhonePack();

            Console.WriteLine($"\nВы захотели сделать {partnerName[2]} подарок.\n");

            string chosedPresent
                = Input(PrintPresentRequestMessage, PresentInputIsCorrect, PrintInputErrorMessage);
            PhonePack partnerIPhone;
            if ( chosedPresent == "1" ) partnerIPhone = yourIPhone.MyClone();
            else partnerIPhone = (PhonePack)yourIPhone.Clone();

            Console.WriteLine($"\nВы подарили {partnerName[1]} телефон как у себя,"+
                                $" ведь он классный и меет такие вот параметры:");
            partnerIPhone.Print();

            Console.WriteLine("Чтобы узнать, что было дальше, нажмите Enter!");
            Console.ReadLine();

            if ( partnerIPhone.GiftIsOk )
            {
                Console.WriteLine($"{partnerName[0]} в восторге от подарка! Клянется, что будет любить вас вечно!");
                Console.WriteLine("\nHappy End ))\n");
            }
            else
            {
                Console.WriteLine
                    ($"{partnerName[0]} {partnerName[3]}, что нуждается в человеке, который любит \"по-настоящему\"\n" +
                    "и может подарить \"нормальный телефон\"!\n"+
                    $"После чего {partnerName[0]} {partnerName[4]} в вас подарком, {partnerName[5]} вещи и {partnerName[6]} Арсену!");
                Console.WriteLine("\nUnhappy End ((\n");
            }



            Console.WriteLine("Press Enter to finish");
            Console.ReadLine();
        }

        static string[] _femaleName = new string[] { "Маша", "Маше", "любимой", "сказала", "бросила", "собрала", "ушла"};
        static string[] _maleName = new string[] { "Сергей", "Сергею", "любимому", "сказал", "бросил", "собрал", "ушел"};

        public static string Input 
            (Action printRquest, Func<string, bool> checkInput, Action printErrorMessage)
        {
            string input = "";
            bool nameInputIsCorrect = false;
            printRquest();
            do
            {
                input = Console.ReadLine();
                nameInputIsCorrect = checkInput(input);
                if ( !nameInputIsCorrect )
                {
                    printErrorMessage();
                    printRquest();
                }
            } 
            while ( !nameInputIsCorrect );
            return input;
        }


        public static void PrintNameRequestMessage() 
            => Console.Write($"Выберите, как зовут вашу половинку:\n1. {_femaleName[0]}\n2. {_maleName[0]}\n\n> ");

        public static void PrintPhoneRequestMessage()
            => Console.Write($"Какой у вас айфон:\n1. IPhone4s \n2. IPhone7s\n3. IPhoneXS\n\n> ");

        public static void PrintPresentRequestMessage()
            => Console.Write($"Вам надо решить, вы обернете коробку в красивую бумагу или подарите в стандартной упаковке:\n" +
                                "1. Обернуть (использовать IMyCloneable) \n" +
                                "2. Стандартная коробка (использовать ICloneable)\n\n> ");

        public static bool NameInputIsCorrect(string input) => input == "1" || input == "2";
        public static bool PhoneInputIsCorrect(string input) => input == "1" || input == "2" || input == "3";

        public static bool PresentInputIsCorrect(string input) => input == "1" || input == "2";

        public static void PrintInputErrorMessage()
    => Console.WriteLine("\nОшибка ввода данных! Попробуйте еще раз.\n");
    }
}
