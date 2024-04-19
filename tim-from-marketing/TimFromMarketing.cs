using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        return $"{"[" + id?.ToString() + "]" ?? ""} - {name} - {department?.ToUpper() ?? "OWNER"}";
    }
}
