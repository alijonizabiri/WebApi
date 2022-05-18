using Service;
using Domain;

var m = new ManagerService();

var list = m.GetManagers();

foreach (var item in list)
{
    System.Console.WriteLine(item.FirsName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.DepartmentId);
    System.Console.WriteLine(item.EmployeeId);
}