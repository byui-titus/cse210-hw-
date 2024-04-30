using System;
using System.Collections.Generic;

class PromptGenerator {
    private List<string> prompts;
    private List<string> motivationalQuotes;

    public PromptGenerator() {
        prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        //To add creativity and exceed the requirements, let's address another common problem that keeps people 
        //from writing in their journal: lack of motivation or inspiration.

        //One way to address this is by integrating a feature that provides daily motivational quotes along with
        // the journal prompts. This can help users start their journaling session with a positive mindset and a
        // spark of inspiration.

        motivationalQuotes = new List<string> {
            "The only way to do great work is to love what you do. - Steve Jobs",
            "Believe you can and you're halfway there. - Theodore Roosevelt",
            "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
            "You are never too old to set another goal or to dream a new dream. - C.S. Lewis",
            "The secret of getting ahead is getting started. - Mark Twain"
        };
    }

    public string GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

     public string GetRandomMotivationalQuote() {
        Random random = new Random();
        int index = random.Next(motivationalQuotes.Count);
        return motivationalQuotes[index];
    }
}
