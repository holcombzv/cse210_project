using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        List<string> reflectionPrompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        List<string> reflectionQuestions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
        };
        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", reflectionPrompts, reflectionQuestions);

        List<string> listeningPrompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };
        Listening listening = new Listening("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listeningPrompts);

        Exit exit = new Exit("Exit", "");
        Menu menu = new Menu();
        menu.setActivity(breathing);
        menu.setActivity(reflection);
        menu.setActivity(listening);
        menu.setActivity(exit);

        Console.Clear();
        while(true) {
            menu.getSelection();
            menu.runSelection();
        }
    }
}