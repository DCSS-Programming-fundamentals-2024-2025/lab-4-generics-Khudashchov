using generics.Interfaces;

class Faculty
{
    public int Id;
    public string Name;
    private IRepository<Group, int> _groups = new InMemoryRepository<Group, int>();

    public void AddGroup(Group g)
    {
        _groups.Add(g.Id, g);
    }
    public void RemoveGroup(int Id)
    {
        _groups.Remove(Id);
    }

    public IEnumerable<Group> GetAllGroups()
    {
        return _groups.GetAll();
    }

    public Group GetGroup(int Id)
    {
        return _groups.Get(Id);
    }

    public void AddStudentToGroup(int groupId, Student s)
    {
        Group group = GetGroup(groupId);
        if (group != null)
        {
            group.AddStudent(s);
        }
        else
        {
            throw new Exception("Group not found");
        }
    }
    public void RemoveStudentFromGroup(int groupId, int studentId)
    {
        Group group = GetGroup(groupId);
        if (group != null)
        {
            group.RemoveStudent(studentId);
        }
        else
        {
            throw new Exception("Group not found");
        }
    }

    public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
    {
        Group group = GetGroup(groupId);
        if (group != null)
        {
            return group.GetAllStudents();
        }
        else
        {
            throw new Exception("Group not found");
        }
    }

    public Student FindStudentInGroup(int groupId, int studentId)
    {
        Group group = GetGroup(groupId);
        if (group != null)
        {
            return group.FindStudent(studentId);
        }
        else
        {
            throw new Exception("Group not found");
        }
    }

    
}