class Student(string name)
{
    public string Name = name;

    List<Course> Courses = [];

     public void Join(Course courses)
    {
        if(!Courses.Contains(course))
        {
            Courses.Add(course);
            course.Enroll(this);
        }
    }

    public override string ToString()
    {
        return $"Studenten heter {Name}.";
    }
}

