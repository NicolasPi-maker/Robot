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

foreach (RobotDate robotDate in robotList)
{
    Console.WriteLine(robotDate._name);
}

var robotDictionary = new Dictionary<int, RobotDate>()
{
    {
        1, new RobotDate(3,"Robot 3","Marche")
    },
    {
        2, new RobotDate(4,"Robot 4","Marche")
    }
};

foreach (var (key, value) in robotDictionary)
{
    Console.WriteLine(value._name);
}

var robotQueue = new Queue<RobotDate>();
robotQueue.Enqueue(new RobotDate(5, "Robot 5", "Arrêt"));
robotQueue.Enqueue(new RobotDate(6, "Robot 6", "Pause"));

foreach (RobotDate robotDate in robotQueue)
{
    Console.WriteLine(robotDate._name);
}

var robotLinkedList = new LinkedList<RobotDate>();
robotLinkedList.AddLast(new RobotDate(7, "Robot 7", "Pause"));
robotLinkedList.AddLast(new RobotDate(8, "Robot 8", "Pause"));

foreach (RobotDate robotDate in robotLinkedList)
{
    Console.WriteLine(robotDate._name);
}

var robotStack = new Stack<RobotDate>();
robotStack.Push(new RobotDate(9, "Robot 9", "Marche"));
robotStack.Push(new RobotDate(10, "Robot 10", "Arrêt"));

foreach (RobotDate robotDate in robotStack)
{
    Console.WriteLine(robotDate._name);
}

var robotObservableCollection = new ObservableCollection<RobotDate>();
robotObservableCollection.Add(new RobotDate(11, "Robot 11", "Marche"));
robotObservableCollection.Add(new RobotDate(12, "Robot 12", "Marche"));

foreach (RobotDate robotDate in robotObservableCollection)
{
    Console.WriteLine(robotDate._name);
}

var robotSortedList = new SortedList<int, RobotDate>();
robotSortedList.Add(0, new RobotDate(13, "Robot 13", "Marche"));
robotSortedList.Add(1, new RobotDate(14, "Robot 14", "Arrêt"));

foreach (var (key, value) in robotSortedList)
{
    Console.WriteLine(value._name);
}


// Il manque le point 5 et 6 de la slide 109 du powerpoint //

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


