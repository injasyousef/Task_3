// See https://aka.ms/new-console-template for more information
using Task3_2;



var employees=new List<Emloyee>();

while (true)
{
    Console.WriteLine("Enter Employee information (name,age,salary) Or -1 to exit");
    string input=Console.ReadLine();
    string[] info = input.Split();

    if (info[0] == "-1")
    {
        break;
    }else if (info.Length != 3)
    {
        Console.WriteLine("Error!");
    }
    else
    {
        employees.Add(new Emloyee(info[0], int.Parse(info[1]), double.Parse(info[2])));
    }
}

Console.WriteLine("Employees:");
for (int i = 0; i < employees.Count; i++)
{
    Console.WriteLine("Employee [ Name = " + employees[i].getName() + ", Age = " + employees[i].getAge() + ", Salary = " + employees[i].gatSalary()+" ].");
}