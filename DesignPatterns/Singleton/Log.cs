using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "myText.txt";

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }
        private Log()
        {

        }

        public void Save(string text)
        {
            File.AppendAllText(_path, text + Environment.NewLine);
        }

    }
}
