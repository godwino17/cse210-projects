using System;

public class ReflectingActivity : Messages
{   
    private List<string> _promptQuestion= new List<string> {"Why was this experience meaningful to you? ", "Have you ever done anything like this before? ", "How did you get started? ", "How did you feel when it was completed? ", "What made this time different from other time when you were not as successful? ","What is your favorite thing about this experience? ", "What could you learn from this experience that applied to other situation? ", "What did you learn about yourself through this experience? ", "How can you keep this experience in mind in the future? "};

    private List<string> _promptMessage= new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you help someone in need.", "Think of a time when you did something truly selfless."};
    private Queue<string> _questionQueue; 
    private Queue<string> _messageQueue; 
    public ReflectingActivity(string activityName, string description) : base(activityName,description)
    {
        ShuffleQuestions(); 
        ShuffleMessages(); 
    }

    private void ShuffleQuestions() 
    { 
        Random random = new Random(); 
        _questionQueue = new Queue<string>(_promptQuestion.OrderBy(x => random.Next())); 
    }

    private void ShuffleMessages() 
    { 
        Random random = new Random(); 
        _messageQueue = new Queue<string>(_promptMessage.OrderBy(x => random.Next())); 
    }

    public void RandomPrompt() 
    {
        // Console.WriteLine("Consider the following prompt:");
        // Console.WriteLine();
        // Random random= new Random();
        // int i= random.Next(_promptMessage.Count);
        // Console.WriteLine($" --- {_promptMessage[i]} ---"); 
        // Console.WriteLine();

        if (_messageQueue.Count == 0) 
        ShuffleMessages(); 
        string prompt = _messageQueue.Dequeue(); 
        Console.WriteLine("Consider the following prompt:\n");  
        Console.WriteLine($" --- {prompt} ---\n");
    }

    public string  RandomPromptQuestion()
    {
        // Random random= new Random();
        // int index= random.Next(_promptQuestion.Count);    
        // return $"> {_promptQuestion[index]}";

        if (_questionQueue.Count == 0) 
        ShuffleQuestions();
        return $"> {_questionQueue.Dequeue()}";
    }

    public void Animation()
    {
        List<string> symbol= new List<string> {"|", "/", "-", "\\"};
        DateTime sTime= DateTime.Now;
        DateTime eTime= sTime.AddSeconds(5);
        int x=0;
        while (DateTime.Now < eTime)
        {
            string s= symbol[x];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            x++;
            if (x >= symbol.Count)
            {
                x=0;
            }
        }
    }
}