namespace src;

internal class Program
{
    static void Main(string[] args)
    {
        Store<Student> students = new();

        students.Add(new Student(1, "Ahmed"));
        students.Add(new Student(2, "Nada"));
        students.Add(new Student(3, "Omar"));
        students.Add(new Student(4, "Sara"));
        students.Add(new Student(5, "Youssef"));

        var student1 = students.GetById(2);
        


        Store<Course> courses = new();

        courses.Add(new Course(1, "C# Programming", 500m));
        courses.Add(new Course(2, "Database Fundamentals", 400m));
        courses.Add(new Course(3, "Web Development", 600m));

        var course1 = courses.GetById(1);




        try
        {
            students.Add(new Student(2, "Nada"));
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }




        var items = students.GetAll().Page(2, 2);
        foreach(var item in items)
        {
            Console.WriteLine($"{item.Id}  =>  {item.Name}");
        }




        var CourseList = new List<Course> 
                    { new(1, "OOP", 500m),
                    new(2, "C#", 200m) };

        Console.WriteLine(CourseList.FindById(1)?.Title);


        //var error = new Store<string>();  must not compile
    }
}
