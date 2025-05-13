// Khudashchov Bogdan KP-41


class Program
{
    static void Main(string[] args)
    {
        Faculty fpm = new Faculty { Id = 1, Name = "FAM" };

        Group KP41 = new Group { Id = 41, Name = "KP-41" };
        Group KP42 = new Group { Id = 42, Name = "KP-42" };
        Group KP43 = new Group { Id = 43, Name = "KP-43" };

        fpm.AddGroup(KP41);
        fpm.AddGroup(KP42);
        fpm.AddGroup(KP43);

        Student student1 = new Student { Id = 1, Name = "Legeza" };
        Student student2 = new Student { Id = 2, Name = "Neshchadym" };

        fpm.AddStudentToGroup(KP41.Id, student1);
        fpm.AddStudentToGroup(KP42.Id, student2);

        Console.WriteLine($"Students in {KP41.Name}:");
        foreach (var student in fpm.GetAllStudentsInGroup(KP41.Id))
        {
            student.SayName();
        }

        Console.WriteLine($"Students in {KP42.Name}:");
        foreach (var student in fpm.GetAllStudentsInGroup(KP42.Id))
        {
            student.SayName();
        }

        IReadOnlyRepository<Student,int> studRepo = new InMemoryRepository<Student, int>();
        IReadOnlyRepository<Person,int>  persRepo = studRepo;

        var tt =  new InMemoryRepository<Person, int>();
        
        IWriteRepository<Person,int> persWrite = tt;
        IWriteRepository<Student,int> studWrite = persWrite;

        // tt.Add(new Person { Id = 1, Name = "Legeza" });

        // System.Console.WriteLine(tt.GetAll().Count());

        // studWrite.Add(new Student { Id = 2, Name = "Neshchadym" });
        // System.Console.WriteLine(tt.GetAll().Count());

        

    }
}