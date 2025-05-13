class Student : Person
{
    // private bool _disposed = false;
    public void SayName()
    {
        Console.WriteLine(Name);
    }

    public void SubmitWork()
    {
        Console.WriteLine($"{Name} submitted the work");
    }

    // public void Dispose()
    // {
    //     Dispose(true);
    //     GC.SuppressFinalize(this);
    // }

    // protected virtual void Dispose(bool disposing)
    // {
    //     if (!_disposed)
    //     {
    //         _disposed = true;
    //     }
    // }
}