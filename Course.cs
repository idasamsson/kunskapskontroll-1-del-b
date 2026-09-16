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
            if(Students.Count >= MaxSeats)
            {
                Console.WriteLine("Kursen är tyvärr full.");
            }
            else
            {
                Students.Add(student);
                student.Join(this);
            }
        }
        
    }

    public void Remove(Student student)
    {
        if (Students.Contains(student))
        {
            Students.Remove(student);
            student.Leave(this);
        }
    }


public override string ToString()
    {
    return $"{Name}, {Students.Count}/{MaxSeats} platser.";
    }
}
