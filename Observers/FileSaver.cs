using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Observers
{

    
    public class FileSaver :IObserver<AbstractStringSubject>
    {
        public string file;
        public FileSaver(string file)
        {
            this.file = file;

        }
        void Update(AbstractStringSubject sub)
        {
            File.AppendAllText(file, sub.Item);

        }
    }
}