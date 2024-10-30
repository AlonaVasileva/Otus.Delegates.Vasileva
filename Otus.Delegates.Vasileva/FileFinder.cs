using Otus.Delegates.Vasileva;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Otus.Delegates.Vasileva
{
    public class FileFinder
    {
        public event EventHandler<FileArgs> FileFound;

        public void FindFiles(string directoryPath, Func<bool> shouldContinue)
        {
            foreach (var file in Directory.GetFiles(directoryPath))
            {
                if (!shouldContinue())
                {
                    break;
                }
                OnFileFound(new FileArgs(file));
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }
    }
}





