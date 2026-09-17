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

      public bool Enroll(Student student)
    {
        if(Students.Contains(student))
        {
            return false;
        }
        if(Students.Count >= MaxSeats)
            {
                Console.WriteLine("Kursen är tyvärr full.");
                return false;
            }

        Students.Add(student);
        student.Courses.Add(this);
        return true;
    }

    public bool Remove(Student student)
    {
        if(Students.Contains(student))
        {
            Students.Remove(student);
            student.Courses.Remove(this);
            return true;
        }
        else
        {
            Console.WriteLine("Studenten läser inte den här kursen.");
            return false;
        }
    }

    public void RollCall()
    {
        Console.WriteLine($"Studenter som läser {this.Name} är:");

        foreach (Student student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }

    public override string ToString()
        {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
        }
}
