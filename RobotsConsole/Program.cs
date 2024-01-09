using Robot;
using System.Collections.ObjectModel;

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

const int MAX_ROBOTS = 5;
var robotArray = new RobotMobile[MAX_ROBOTS];

RobotMobile robot1 = new("Robot 1", new RobotPoint(10,20), 10);
RobotMobile robot2 = new("Robot 2", new RobotPoint(15, 15), 10);
RobotMobile robot3 = new("Robot 3", new RobotPoint(20, 10), 10);

robotArray[0] = robot1;
robotArray[1] = robot2;
robotArray[2] = robot3;
robotArray[2] = new RobotMobile("Robot 4", new RobotPoint(50, 25), 5);

int averageSpeed = 0;
int y = 0;
Console.WriteLine(robotArray.Length);
foreach(var robotInArray in robotArray)
{
    if (robotInArray is RobotMobile)
    {
        y += 1;
        averageSpeed += robotInArray.getSpeed();
    }
}
averageSpeed /= y;

Console.WriteLine($"AverageSpeed: {averageSpeed}");
string robotMobileName = robotArray[2].GetName();

var robotList =  new List<RobotDate>()
{
    new RobotDate(1,"Robot 1","Arrêt"),
    new RobotDate(2,"Robot 2","Marche"),
};

var robotDictionary = new Dictionary<int, RobotDate>()
{
    {
        1, new RobotDate(3,"Robot 3","Marche")
    },
    {
        2, new RobotDate(4,"Robot 4","Marche")
    }
};

var robotQueue = new Queue<RobotDate>();
robotQueue.Enqueue(new RobotDate(5, "Robot 5", "Arrêt"));
robotQueue.Enqueue(new RobotDate(6, "Robot 6", "Pause"));

var robotLinkedList = new LinkedList<RobotDate>();
robotLinkedList.AddLast(new RobotDate(7, "Robot 7", "Pause"));
robotLinkedList.AddLast(new RobotDate(8, "Robot 8", "Pause"));

var robotStack = new Stack<RobotDate>();
robotStack.Push(new RobotDate(9, "Robot 9", "Marche"));
robotStack.Push(new RobotDate(10, "Robot 10", "Arrêt"));

var robotObservableCollection = new ObservableCollection<RobotDate>();

var robotLinqList = new List<RobotLinq>();
for (int i = 0; i < 10; i++)
{
    robotLinqList.Add(new RobotLinq($"robot {i}", 2002 + i, 10 + i, 15 + i));
}

IEnumerable<RobotLinq> robotListCreatedAfter2005 = robotLinqList.Where(element => element.Year > 2005);
Console.WriteLine("////////");
foreach (RobotLinq robotLinq in robotListCreatedAfter2005)
{
    Console.WriteLine(robotLinq.Year);
}

IEnumerable<RobotLinq> robotsSortedByYear = robotLinqList.OrderBy(element => element.Year);
Console.WriteLine("////////");
foreach (RobotLinq robotLinq in robotListCreatedAfter2005)
{
    Console.WriteLine(robotLinq.Year);
}

Console.WriteLine("////////");
int oldestRobot = robotLinqList.Max(element => element.Year);
Console.WriteLine(oldestRobot);


// Il manque le point 5 et 6 de la slide 109 du powerpoint //

var groupByYear = robotLinqList.GroupBy(element => element.Year);
Console.WriteLine("////////");
foreach (var group in groupByYear)
{
    Console.WriteLine(group.Count());
}

Console.WriteLine("////////");
var threeBefore2010 = robotLinqList.OrderByDescending(element => element.Year).Where(element => element.Year < 2010).Take(3);
foreach(var younRobot in threeBefore2010)
{
    Console.WriteLine(younRobot.Year);
}


Console.WriteLine("////////");
var oInNameandAfter2005 = robotLinqList.Where(element => element.Year > 2005).Where(element => element.Name.Contains("o"));
foreach (var robotNamedWithO in oInNameandAfter2005)
{
    Console.WriteLine(robotNamedWithO.Name);
}


Console.WriteLine("////////");
var constructYearAverage = robotLinqList.Average(element => element.Year);
Console.WriteLine(constructYearAverage);


