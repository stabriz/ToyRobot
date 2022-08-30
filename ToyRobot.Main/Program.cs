using System;

namespace ToyRobot.Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //create the simulator with the table size
            Simulator simulator = new Simulator(6, 6); 
            var _stop = false;
            try
            {
                while (!_stop)
                {
                    Console.Write("> ");
                    var command = Console.ReadLine();

                    if (command.ToLower() == "exit")
                    {
                        _stop = true;
                    }
                    else
                    {
                        simulator.ProcessCommands(command);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
