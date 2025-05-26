using System;
using System.Collections.Generic;

public static class Phishing
{
    static List<string> tips = new List<string>
{
"Never click on suspicious links.",
"Check the sender's email address.",
"Be wary of urgent messages asking for personal info.",
"Avoid downloading attachments from unknown senders.",
"Hover over links to preview the URL.",
"Verify emails with the source if unsure.",
"Don't give out sensitive information via email.",
"Beware of grammar and spelling mistakes in messages.",
"Use anti-phishing filters in your email client.",
"Look out for spoofed websites.",
"Check for HTTPS in the browser.",
"Ignore pop-up warnings that look suspicious.",
"Never enter passwords from links in emails.",
"Report phishing attempts to your provider.",
"Keep your software and antivirus updated."
};

    public static void Respond()
    {
        var rand = new Random();
        int index = rand.Next(tips.Count);
        Console.WriteLine($" Phishing Tip: {tips[index]}");
    }
}
