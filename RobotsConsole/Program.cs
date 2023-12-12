using Robot;

RobotMobile robot = new("Robot bot",new RobotPoint(10,10), 10);
robot.SetName("test");
Console.WriteLine(robot.GetName());

Console.WriteLine(robot.start());
Console.WriteLine(robot.clean());
Console.WriteLine(robot.move(new RobotPoint(15,15)));

RobotMobile changeName(RobotMobile robot, string newName)
{
    robot.SetName(newName);
    return robot;
}

var updatedRobot = changeName(robot, "Bob");
Console.WriteLine(updatedRobot.GetName());

