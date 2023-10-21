using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = setup();
        bool end = false;
        while(!end) {
            end = scripture.isHidden();
            Console.Clear();
            Console.WriteLine(scripture.getRenderText());
            Console.WriteLine("==================================\nType quit to end, otherwise, hit Enter.");
            string input = Console.ReadLine();
            if(input == "quit") {
                end = true;
            }
            scripture.hide(3);
        }
    }

    static Scripture setup() {
        Reference reference = new Reference("Doctrine & Covenants", 121, 41, 42);
        reference.addVerses(36);

        string text36 = "That the rights of the priesthood are inseparably connected with the powers of heaven, and that the powers of heaven cannot be controlled nor handled only upon the principles of righteousness.";
        List<Word> words36 = new List<Word>();
        foreach(string word in text36.Split(" ")) {
            words36.Add(new Word(word));
        }
        Verse verse36 = new Verse(36, words36);

        string text41 = "No power or influence can or ought to be maintained by virtue of the priesthood, only by persuasion, by long-suffering, by gentleness and meekness, and by love unfeigned;";
        List<Word> words41 = new List<Word>();
        foreach(string word in text41.Split(" ")) {
            words41.Add(new Word(word));
        }
        Verse verse41 = new Verse(41, words41);

        string text42 = "By kindness, and pure knowledge, which shall greatly enlarge the soul without hypocrisy, and without guile";
        List<Word> words42 = new List<Word>();
        foreach(string word in text42.Split(" ")) {
            words42.Add(new Word(word));
        }
        Verse verse42 = new Verse(42, words42);

        List<Verse> verses = new List<Verse>();
        verses.Add(verse36);
        verses.Add(verse41);
        verses.Add(verse42);
        Scripture scripture = new Scripture(reference, verses);
        return scripture;
    }
}