class Student(string name)
{
    public string Name = name;

    List<Course> Courses = [];

     public void Join(Course course)
    {
        if(!Courses.Contains(course))
        {
            Courses.Add(course);
            course.Enroll(this);  
        }
        
    }

    public void Leave(Course course)
    {
        if (Courses.Contains(course))
        {
           course.Remove(this);
           Courses.Remove(course);
        }
    }

        public void Schedule()
    {
        Console.WriteLine($"Kurser som {this.Name} läser är:");

        foreach (Course course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }
    public override string ToString()
    {
        return $"Studenten heter {Name} och läser kurserna {String.Join(", ", Courses.Select(c => c.Name))}.";
    }
}

