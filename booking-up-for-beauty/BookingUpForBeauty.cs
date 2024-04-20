using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime dt = DateTime.Parse(appointmentDateDescription);
        Console.WriteLine(dt.ToLongDateString());
        return dt;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        // if < 0, then current instance is earlier hence in the past!
        return appointmentDate.CompareTo(DateTime.Now) < 0;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        string message = $"You have an appointment on {DateTime.SpecifyKind(appointmentDate, DateTimeKind.Local)}.";
        return message;
    }

    public static DateTime AnniversaryDate()
    {
        throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
    }
}
