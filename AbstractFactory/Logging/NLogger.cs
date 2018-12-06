using System;
using AbstractFactory.Logging.Base;

namespace AbstractFactory.Logging
{
    public class NLogger : BaseLogging{
        public override void Log(){
            Console.WriteLine("NLogger");
        }
    }
}