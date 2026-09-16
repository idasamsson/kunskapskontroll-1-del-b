class Course
{
    public string Name;

    public int MaxSeats;

    public List<Student> Students = [];

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

      public void Enroll(Student student)
    {
        if(!Students.Contains(student))
        {
            Students.Add(student);
            student.Join(this);
        }
    }


public override string ToString()
    {
    return $"Kursen {Name} har {MaxSeats} platser.";
    }
}
