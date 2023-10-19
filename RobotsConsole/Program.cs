using Robot;
using System.Drawing;

RobotMobile robot = new("Robot bot", 10, 10, 1,new RobotPoint(10,10));

Console.WriteLine(robot.start());
Console.WriteLine(robot.clean());
Console.WriteLine(robot.move(new RobotPoint(15,15)));