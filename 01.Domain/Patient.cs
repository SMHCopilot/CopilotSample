using System;

public class Patient
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public List<Appointment> Appointments { get; private set; } // Patient's Appointments

    // Constructor and methods to manage patient's data
}

