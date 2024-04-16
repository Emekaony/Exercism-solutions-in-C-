using System.Text;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string message, string delimiter)
    {
        int start = message.IndexOf(delimiter);
        return message[(start + delimiter.Length)..];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string message, string first, string second)
    {
        int start = message.IndexOf(first);
        int end = message.IndexOf(second);
        // string substring is weird: "emeka".IndexOf("e") == "emeka".IndexOf("eme")
        return message[(start + first.Length)..end];
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