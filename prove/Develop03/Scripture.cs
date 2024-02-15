using System;
using System.Collections.Generics;

class Scripture
{
    private string text;
    private string verseRange;
    private List<Verse> verses;

    public Scripture(string text)
    {
        this.text = text;
        verseRange ="";
        verses = new List<Verse>();
    }


    public Scripture(string text, string verseRange)
    {
        this.text = text;
        this.verseRange = verseRange;
        verses = new List<Verse>();
        
    }
}