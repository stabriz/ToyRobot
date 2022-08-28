using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _stop = false;
            while(!_stop)
            {
                var command = Console.ReadLine();
                
                if (command.ToLower() == "exit")
                {
                    _stop = true;
                }
                else
                {
                   
                }
            }
        }
    }
}
