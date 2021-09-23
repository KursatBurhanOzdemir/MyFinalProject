using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CSS
{
   public class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
