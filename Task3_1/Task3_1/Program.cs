// See https://aka.ms/new-console-template for more information
using Task3_1;


var students = new List<Student>();

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter Student #"+(i+1)+" Name and Grade");
    string input = Console.ReadLine();
    string[] info = input.Split();
    students.Add(new Student(info[0], double.Parse(info[1])));
}
calculateAvg(students);

void calculateAvg(List<Student> students)
{
    double sum = 0;
    double avg = 0;
    for(int i=0; i<students.Count; i++)
    {
        sum += students[i].getGrade();
    }
    avg = sum/students.Count;
    Console.WriteLine("The Avarage is: "+avg);
    Console.WriteLine("Student Above The Avarage:");
    for (int i = 0; i < students.Count; i++)
    {
        if (students[i].getGrade() > avg)
        {
            Console.WriteLine(students[i].getName() +" "+ students[i].getGrade());
        }
    }
}
