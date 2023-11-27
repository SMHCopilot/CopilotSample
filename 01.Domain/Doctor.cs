using System;

public class Doctor
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public DoctorType Type { get; private set; } // Enum for General Practitioner or Specialist
    public Schedule Schedule { get; private set; } // Weekly Schedule

    // Constructor and methods to manage doctor's data
}

