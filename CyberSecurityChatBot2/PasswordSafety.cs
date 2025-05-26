using System;
using System.Collections.Generic;
public static class PasswordSafety
{
    
    static List<string> tips = new List<string>
{
"Use a unique password for every account.",
"Avoid using personal information in passwords.",
"Use a combination of uppercase, lowercase, numbers, and symbols.",
"Enable two-factor authentication.",
"Change passwords regularly.",
"Don’t write your passwords down.",
"Use a password manager to store strong passwords.",
"Avoid common passwords like '123456' or 'password'.",
"Don’t share your passwords with others.",
"Use long passphrases when possible.",
"Avoid using your name or birthdate.",
"Keep recovery questions private.",
"Check for compromised passwords using online tools.",
"Use biometric logins where available.",
"Be careful with password reset emails."
};

    public static void Respond()
    {
        var rand = new Random();
        int index = rand.Next(tips.Count);
        Console.WriteLine($"Password Tip: {tips[index]}");
    }
}
