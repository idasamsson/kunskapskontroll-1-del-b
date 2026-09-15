class Student(string name)
{
    public string Name = name;

    List<Student> courses = [];

    public override string ToString()
    {
        return $"Studenten heter {Name}.";
    }
}

