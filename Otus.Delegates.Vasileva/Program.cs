using System;
using System.Collections.Generic;
using System.IO;

namespace Otus.Delegates.Vasileva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var finder = new FileFinder();
            finder.FileFound += Finder_FileFound;

            // Пункт 4: Пример поиска файлов в текущем каталоге
            finder.SearchFiles(Directory.GetCurrentDirectory());

            // Пункт 1: Пример использования GetMax
            var numbers = new List<ExampleClass>
            {
                new ExampleClass { Value = 1 },
                new ExampleClass { Value = 3 },
                new ExampleClass { Value = 2 }
            };

            var maxItem = numbers.GetMax(item => item.Value);
            Console.WriteLine($"Max Value: {maxItem.Value}");
        }

        private static void Finder_FileFound(object sender, FileArgs e)
        {
            Console.WriteLine($"File found: {e.FileName}");
            if (e.FileName.EndsWith(".txt")) 
            {
                e.Cancel = true; 
            }
        }
    }
}
