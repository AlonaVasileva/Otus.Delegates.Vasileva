using System;
using System.Collections.Generic;

namespace Otus.Delegates.Vasileva
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fileFinder = new FileFinder();
            fileFinder.FileFound += (sender, e) =>
            {
                Console.WriteLine($"File found: {e.FileName}");
            };

            //  делегат для отмены поиска
            bool shouldContinue = true;
            fileFinder.FindFiles("C:\\Users\\vasilevaea\\source\\repos\\Otus.Delegates.Vasileva\\Test", () => shouldContinue);

            // Для тестирования функции расширения
            var items = new List<MyClass> { new MyClass { Value = 10 }, new MyClass { Value = 20 } };
            var maxItem = items.GetMax(item => item.Value);
            Console.WriteLine($"Max item: {maxItem.Value}");
            Console.ReadKey();
        }
    }
}
