using System;

class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public Lecture(string title, string description, DateTime date, string time, Address address, string speakerName)
        : this(title, description, date, time, address, speakerName, GenerateRandomCapacity())
    {
    }

    private static int GenerateRandomCapacity()
    {
        Random random = new Random();
        int capacity = random.Next(1, 9) * 25;
        return capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}
