using System.Text;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(": ")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[');
        int end = logLine.IndexOf(']');
        return logLine.Substring(start + 1, end - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        StringBuilder sb = new(Message(logLine));
        sb.AppendFormat(" ({0})", LogLevel(logLine));
        return sb.ToString();
    }
}
