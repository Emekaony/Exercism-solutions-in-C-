static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string _id = id == null ? "" : $"[{id}] - ";
        return $"{_id}{name} - {department?.ToUpper() ?? "OWNER"}";
    }
}
