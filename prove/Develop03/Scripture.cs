using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string _text;
    private List<Word> _words;
    private HashSet<int> _hiddenIndices;

    public string Reference { get; private set; }
    public string Text { get; private set; }
    public bool AllWordsHidden => _words.All(w => w.Hidden);

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        InitializeWords();
        _hiddenIndices = new HashSet<int>();
    }

    private void InitializeWords()
    {
        _words = Text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(word => new Word(word))
                      .ToList();
    }

    public void HideWords(Random random)
    {
    
        while (true)
        {
            int index = random.Next(0, _words.Count);
            if (!_hiddenIndices.Contains(index))
            {
                _words[index].Hide();
                _hiddenIndices.Add(index);
                break;
            }
        }
    }

    public void Display()
    {
        Console.Clear();

        foreach (Word word in _words)
        {
            Console.Write(word.Hidden ? "_____" : word.Text);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}