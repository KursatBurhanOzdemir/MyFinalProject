using System;

namespace Business.CSS
{
  public class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
