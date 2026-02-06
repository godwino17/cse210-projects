using System;

public class ListingActivity : Messages
{
    // We add a queue kind of list to hold shuffled prompts. /\
    // This lets us serve prompts one at a time, in order, without repeats. 
    private Queue<string> _promptQueue;
    List<string> _prompt= new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Spirit this month?"};

    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
        //  this ensure that when a new ListingActivity is created, we shuffle once. /\
        // it also ensures that first prompt is random, but no duplicates appear until all prompts are used.
        ShufflePrompts();
    }

    private void ShufflePrompts()   // Ai    // added
    { 
        Random random = new Random(); 
        //  OrderBy(x => random.Next()) shuffles the list randomly.
        //  then We wrap the shuffled list in a Queue<string>        /\
        //  so that i we can select( Dequeue())  prompts sequentially to the user.
        _promptQueue = new Queue<string>(_prompt.OrderBy(x => random.Next())); 
    }

    public void DisplayPrompt()
    {
        // Console.WriteLine("List as many responses you can to the following prompt:");
        // Random random= new Random();
        // int index= random.Next(_prompt.Count);
        // Console.WriteLine($" --- {_prompt[index]} ---");       // My work before adding the queue
        // Console.Write("You may begin in: ");


        if (_promptQueue.Count == 0) // this ensure that If the queue is empty, we reshuffle (so the cycle can start again). /\
        // Otherwise, we Dequeue() the next prompt. /\
        // This guarantees no duplicates until all prompts are used.
        ShufflePrompts(); // reset when exhausted 
        string prompt = _promptQueue.Dequeue();
        Console.WriteLine("List as many responses you can to the following prompt:");  // Ai  modify
        Console.WriteLine($" --- {prompt} ---"); 
        Console.Write("You may begin in: ");
    }
}