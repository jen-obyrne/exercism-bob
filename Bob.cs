
using System.Text.RegularExpressions;
public static class Bob
{
    public static string Hey(string statement)
    {
        statement = statement.Trim();
        
        if (statement != string.Empty)
        {
            if (IsAllCaps(statement))
            {
                return "Whoa, chill out!";
            }
            if (statement.EndsWith("?"))
            {
                return "Sure.";
            }
            return "Whatever.";
        }

        return "Fine. Be that way!";
    }

    public static bool IsAllCaps(string statement)
    {
        var capitalisedLetters = statement.ToUpper();
        var containsLetter = Regex.Matches(statement, @"[a-zA-Z]").Count >= 1;

        return containsLetter && capitalisedLetters == statement;
    }
}