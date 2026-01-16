using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<String> _textList = new List<string> { "What am i grateful for today? ", "My biggest win this week was? ", "What is one thing i will do differently tomorrow? ", "What self care practice can i prioritize? ", "What challenge i'm i facing and how i'll overcome it? ", "What did i learn about myself recently? ", "What is your happy memory? ", "What is your goal for the next 3 month? ", "If i had one thing i could do over today, what would it be? ", "What was the best part of my day? ", "Who was the most interesting person i interacted with today? ", "What was the best part of my day? ", "How did i see the hand of the lord in my life today? ","What was the strongest emotion i felt today? "};

    public string GetRandomGenerator()
    {
        Random random = new Random();
        int randomnums = random.Next(_textList.Count);
        string randChoices = _textList[randomnums];
        // return a random text as prompt
        return $"{randChoices} ";
    }
}