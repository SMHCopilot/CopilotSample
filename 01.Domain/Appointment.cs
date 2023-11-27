using System;

public class Appointment
{
    public int Id { get; private set; }
    public DateTime StartTime { get; private set; }
    public TimeSpan Duration { get; private set; }
    public Doctor Doctor { get; private set; }
    public Patient Patient { get; private set; }

    // Constructor and methods for appointment handling
}
