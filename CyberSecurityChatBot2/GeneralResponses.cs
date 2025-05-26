using System;

public static class GeneralResponses
{
    public static bool Respond(string input)
    {
        if (input.Contains("how are you"))
        {
            Console.WriteLine(" I’m good thanks! How can I help?");
            return true;
        }
        if (input.Contains("your purpose"))
        {
            Console.WriteLine("I help spread awareness about cybersecurity. Ask me about password safety, phishing, or safe browsing!");
            return true;
        }
        if (input.Contains("what can i ask"))
        {
            Console.WriteLine(" You can ask me anything about passwords, phishing scams, and browsing safely.");
            return true;
        }

        return false;
    }
}
