using System.Text;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string message, string delimiter)
    {
        int start = message.IndexOf(delimiter);
        return message[(start + 1)..];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string message, string first, string second)
    {
        // hope this works
        StringBuilder sb = new();
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i].ToString() == first)
            {
                i++;
                if (message[i].ToString() != second)
                {
                    sb.Append(message[i]);
                }
                else break;
            }
        }
        return sb.ToString();
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string message)
    {
        return message.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string input)
    {
        return input.SubstringBetween("[", "]");
    }
}