class Course
{
    public string Name;

    public int MaxSeats;

    public List<Course> Students = [];

    public Course(string name, int maxSeats)
    {
        string Name = name;
        int MaxSeats = maxSeats;
    }


public override string ToString()
    {
    return $"Kursen {Name} har {MaxSeats}platser.";
    }
}
