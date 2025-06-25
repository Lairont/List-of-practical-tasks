using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Converter
    {
        // Поля для хранения курсов валют по отношению к BYN
        private double UsdRate;
        private double EurRate;
        private double RubRate;

        // Пользовательский конструктор, принимает курсы валют
        public Converter(double usd, double eur, double rub)
        {
            UsdRate = usd; // Курс USD к BYN
            EurRate = eur; // Курс EUR к BYN
            RubRate = rub; // Курс RUB к BYN (за 1 RUB)
        }

        // Метод конвертации из BYN в выбранную валюту
        public double ConvertFromBYN(string currency, double amount)
        {
            // Используем switch для выбора валюты
            switch (currency.ToUpper())
            {
                case "USD":
                    return amount / UsdRate; // Конвертация в USD
                case "EUR":
                    return amount / EurRate; // Конвертация в EUR
                case "RUB":
                    return amount / RubRate; // Конвертация в RUB
                default:
                    // Если введена неверная валюта, генерируем исключение
                    throw new ArgumentException("Неверно указана валюта.");
            }
        }

        // Метод конвертации из валюты в BYN
        public double ConvertToBYN(string currency, double amount)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return amount * UsdRate; // Конвертация из USD в BYN
                case "EUR":
                    return amount * EurRate; // Конвертация из EUR в BYN
                case "RUB":
                    return amount * RubRate; // Конвертация из RUB в BYN
                default:
                    throw new ArgumentException("Неверно указана валюта.");
            }
        }
    }
}