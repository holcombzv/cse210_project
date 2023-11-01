using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Activity testActivity = new Activity("testActivity", "Funzos funzone where the fun is in the zone.");
        // Console.Clear();
        // testActivity.startMessage();
        // testActivity.endMessage();

        Breathing testBreathing = new Breathing("testBreathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        testBreathing.run();

        List<string> prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
        };

        Console.Clear();
        Reflection testReflection = new Reflection("testReflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", prompts, questions);
        testReflection.run();
    }
}