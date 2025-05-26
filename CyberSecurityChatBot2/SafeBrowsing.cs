using System;
using System.Collections.Generic;

public static class SafeBrowsing
{
    static List<string> tips = new List<string>
{
"Always check for HTTPS in the URL.",
"Don’t download files from untrusted sites.",
"Use a secure and updated browser.",
"Enable your browser's security settings.",
"Avoid clicking on random pop-ups.",
"Keep your software and extensions updated.",
"Be cautious with free Wi-Fi networks.",
"Use a VPN when accessing sensitive information.",
"Don’t auto-save passwords in shared computers.",
"Clear cookies and cache regularly.",
"Avoid logging into sites via links in emails.",
"Use private browsing for sensitive sessions.",
"Only install extensions from trusted sources.",
"Be careful with shortened URLs.",
"Educate yourself regularly about new threats."
};

    public static void Respond()
    {
        var rand = new Random();
        int index = rand.Next(tips.Count);
        Console.WriteLine($" Safe Browsing Tip: {tips[index]}");
    }
}
