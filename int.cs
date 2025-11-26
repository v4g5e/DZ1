
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int raiting = 8;
            Console.WriteLine($"Рейтинг - {raiting}");

            int votes = 3;
            Console.WriteLine($"Голосов - {votes} (это не выборы)");

            int ErrorCode = 404;
            Console.WriteLine($"Код ошибки - {ErrorCode}");

            int like = 10000;
            Console.WriteLine($"Лайков под видео - {like}");

            int year = 2025;
            Console.WriteLine($"Год - {year}");

            int temperature = 21;
            Console.WriteLine($"Темспература - {temperature}");

            int userID = 1;
            Console.WriteLine($"ID пользователя - {userID}");

            int BadGateway = 502;
            Console.WriteLine($"Ошибка - {BadGateway} (опять ошибко)");

            int balance = -500;
            Console.WriteLine($"Баланс на моей карте - {balance}");

            int surfaceTemp = -65;
            Console.WriteLine($"Температура поверхности - {surfaceTemp}");

            int otbitCount = 250;
            Console.WriteLine($"Отбито - {otbitCount} не знаю кого я отбивала но все отбиты");

            int missionID = 007;
            Console.WriteLine($"ID миссии - {missionID}");

            int errorCount = -33;
            Console.WriteLine($"Ошибок - {errorCount}");

            int missionBudget = -250000;
            Console.WriteLine($"Бюджет миссии- {missionBudget}");

            int fuelReserve = -1200;
            Console.WriteLine($"Запас топлива - {fuelReserve}");
        }
    }
}
