
using System;

namespace CyberBot.App
{
    public static class TopicHandler
    {
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm functioning optimally to protect your cybersecurity!";
            if (input.Contains("purpose"))
                return "I educate users on online safety and cybersecurity awareness.";
            if (input.Contains("password"))
                return "Use long, complex passwords with symbols, and never reuse them!";
            if (input.Contains("phishing"))
                return "Be cautious of emails asking for personal info—always verify sources!";
            if (input.Contains("safe browsing"))
                return "Avoid clicking unknown links. Use HTTPS websites and enable ad-blockers.";
            if (input.Contains("social engineering"))
                return "Social engineering tricks you into revealing personal info—stay alert!";
            if (input.Contains("malware"))
                return "Malware can be hidden in downloads—use antivirus software and scan often.";

            return "I'm not sure about that. Try asking about passwords, phishing, or safe browsing.";
        }
    }
}



