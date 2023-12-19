namespace Level27Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            Console.WriteLine("What commands do you want to give the robot? Max 3.");

            string[] commandChoices = { "on", "off", "north", "south", "east", "west" };

            foreach (var command in commandChoices.Select((name, index) => (name, index)))
            {
                Console.WriteLine($"{command.index + 1}. {command.name}");
            }

            for (int i = 0; i < robot.Commands.Length; i++)
            {
                string? input = Console.ReadLine();
                IRobotCommand newCommand = input switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "south" => new SouthCommand(),
                    "north" => new NorthCommand(),
                    "west" => new WestCommand(),
                    "east" => new EastCommand(),
                    _ => throw new NotImplementedException(),
                };

                robot.Commands[i] = newCommand;
            }

            Console.WriteLine();

            robot.Run(robot);
        }
    }
}