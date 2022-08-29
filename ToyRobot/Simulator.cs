using System;
using ToyRobot.Enums;

namespace ToyRobot
{
    public class Simulator
    {
        private Robot _robot = new Robot();
        private Table _table;
        private bool _robotPlacced = false;


        public Simulator(int tableLength, int tableWidth)
        {
            _table = new Table(tableLength, tableWidth);
        }

        public void ProcessCommands(string args)
        {
            if (args == null)
                throw new ArgumentNullException("Missing Command");

            if (args.Length == 0)
                throw new ArgumentException("Command is empty");

            string[] commands = args.Split(' ');

            Command _command;
            if (!Enum.TryParse(commands[0].ToUpper(), out _command))
                throw new ArgumentException("Unable to Parse command");


            if (!_robotPlacced && _command != Command.PLACE)
                throw new InvalidOperationException("PLACE must be the first command");


            switch (_command)
            {
                case Command.PLACE:
                    string[] placeParameters = commands[1].Split(',');
                    if (placeParameters.Length < 2)
                        throw new ArgumentException($"Not enough parameters for PLACE. Minimum 2, got {placeParameters.Length}");

                    int x;
                    if (!int.TryParse(placeParameters[0], out x))
                        throw new ArgumentException($"Place parameter 0 is not a proper integer");

                    int y;
                    if (!int.TryParse(placeParameters[1], out y))
                        throw new ArgumentException($"Place parameter 1 is not a proper integer");

                    Position position = new Position(x, y);
                    if (_table.IsValidPosition(position))
                    {
                        if (placeParameters.Length>2 && placeParameters[2]!=null)
                        {
                            Direction _direction;
                            if (!Enum.TryParse(placeParameters[2], out _direction))
                                throw new ArgumentException("Place parameter: unable to parse direction");


                            _robot.Place(position, _direction);
                            _robotPlacced = true;
                        }
                        else
                        {
                            _robot.Place(position);
                        }
                    }
                        break;
                case Command.MOVE:
                    if (_table.IsValidPosition(_robot.TryMove()))
                        _robot.Move();

                    break;
                case Command.LEFT:
                    _robot.TurnLeft();
                    break;
                case Command.RIGHT:
                    _robot.TurnRight();

                    break;
                case Command.REPORT:
                    Console.WriteLine(_robot.Report());
                    break;
                default:
                    throw new ArgumentException($"Unrecognised command");
            }
        }
    }
}
