using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Singleton.Log.Instance;
            log.Save("This is a fucking test!");
            log.Save("This is a fucking test2!");
        }
    }
}
