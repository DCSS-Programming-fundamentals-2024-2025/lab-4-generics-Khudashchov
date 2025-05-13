using generics.Interfaces;

class Group
{
    public int Id;
    public string Name;
    private IRepository<Student, int> _students = new InMemoryRepository<Student, int>();
    // private bool _disposed = false;

    public Group(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Group()
    {
    }
    public void AddStudent(Student s)
    {
        _students.Add(s.Id, s);
    }

    public void RemoveStudent(int studentId)
    {
        _students.Remove(studentId);
    }

    public IEnumerable<Student> GetAllStudents()
    {
        return _students.GetAll();
    }

    public Student FindStudent(int studentId)
    {
        return _students.Get(studentId);
    }

    // public void Dispose()
    // {
    //     _students.Dispose();

    //     Dispose(true);
    //     GC.SuppressFinalize(this);
    // }

    // protected virtual void Dispose(bool disposing)
    // {
    //     if (!_disposed)
    //     {
    //         if (disposing)
    //         {
    //             _students.Dispose();
    //         }
    //         _disposed = true;
    //     }
    // }
}