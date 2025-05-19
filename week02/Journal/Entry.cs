using System;


public class Entry
{
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;


    public PromptGenerator _promptGenerator = new PromptGenerator();

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"> {_entryText}");
        Console.WriteLine();
    }
}