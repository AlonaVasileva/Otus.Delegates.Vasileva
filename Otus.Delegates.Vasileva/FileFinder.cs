using System;
using System.IO;

namespace Otus.Delegates.Vasileva
{
    internal class FileFinder
    {
        public event EventHandler<FileArgs> FileFound;

        public void SearchFiles(string directory)
        {
            if (!Directory.Exists(directory))
                throw new DirectoryNotFoundException($"Directory '{directory}' not found.");

            var files = Directory.GetFiles(directory);
            foreach (var file in files)
            {
                var args = new FileArgs { FileName = file };
                OnFileFound(args);
                // было ли отменено дальнейшее выполнение
                if (args.Cancel)
                    break; 
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }

    }
}
