﻿using System;

namespace ToyRobot.Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //create the simulator with the table size
            Simulator simulator = new Simulator(7, 7);
            var _stop = false;

            while (!_stop)
            {
                try
                {
                    Console.Write("> ");
                    var command = Console.ReadLine();

                    if (command.ToLower().Equals("exit"))
                    {
                        _stop = true;
                    }
                    else
                    {
                        simulator.ProcessCommands(command);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
