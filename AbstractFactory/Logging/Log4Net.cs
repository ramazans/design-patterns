using System;
using AbstractFactory.Logging.Base;

namespace AbstractFactory.Logging
{
    public class Log4Net : BaseLogging{
        public override void Log(){
            Console.WriteLine("Log4Net");
        }
    }
}