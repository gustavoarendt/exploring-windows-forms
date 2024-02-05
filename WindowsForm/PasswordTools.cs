using System.Text.RegularExpressions;
using System;
using System.ComponentModel;
using WindowsForm;

public class PasswordChecker
{
    public int GenerateSecurityLevel(string password)
    {
        if (password == null) return 0;
        int pointsPerSize = GetPointsPerSize(password);
        int pointsPerLowerCase = GetPointsPerLowerCase(password);
        int pointsPerUpperCase = GetPointsPerUpperCase(password);
        int pointsPerLength = GetPointsPerLength(password);
        int pointsPerSymbols = GetPointsPerSymbols(password);
        int pointsPerRepetition = GetPointsPerRepetition(password);
        return pointsPerSize + pointsPerLowerCase + pointsPerUpperCase
            + pointsPerLength + pointsPerSymbols - pointsPerRepetition;
    }

    private int GetPointsPerSize(string password)
    {
        return Math.Min(10, password.Length) * 7;
    }

    private int GetPointsPerLowerCase(string password)
    {
        int score = password.Length - Regex.Replace(password, "[a-z]", "").Length;
        return Math.Min(2, score) * 5;
    }

    private int GetPointsPerUpperCase(string password)
    {
        int score = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
        return Math.Min(2, score) * 5;
    }

    private int GetPointsPerLength(string password)
    {
        int score = password.Length - Regex.Replace(password, "[0-9]", "").Length;
        return Math.Min(2, score) * 6;
    }

    private int GetPointsPerSymbols(string password)
    {
        int score = Regex.Replace(password, "[a-zA-Z0-9]", "").Length;
        return Math.Min(2, score) * 5;
    }

    private int GetPointsPerRepetition(string password)
    {
        System.Text.RegularExpressions.Regex regex = new Regex(@"(\w)*.*\1");
        bool repeat = regex.IsMatch(password);
        if (repeat)
        {
            return 30;
        }
        else
        {
            return 0;
        }
    }

    public string GetPasswordLevel(string password)
    {
        int score = GenerateSecurityLevel(password);

        if (score < 50)
            return PasswordLevel.WORST.GetDescription();
        else if (score < 60)
            return PasswordLevel.WEAK.GetDescription();
        else if (score < 80)
            return PasswordLevel.ACCEPTABLE.GetDescription();
        else if (score < 100)
            return PasswordLevel.STRONG.GetDescription();
        else
            return PasswordLevel.SECURE.GetDescription();
    }
}

public enum PasswordLevel
{
    [Description("Inaceitável")]
    WORST,
    [Description("Fraca")]
    WEAK,
    [Description("Aceitável")]
    ACCEPTABLE,
    [Description("Forte")]
    STRONG,
    [Description("Segura")]
    SECURE
}
