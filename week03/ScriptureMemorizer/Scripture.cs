
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] words = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return _reference.GetDisplayText() + " " +
               string.Join(" ", displayWords);
    }

    public void HideRandomWords(int numberToHide)
    {
        // Collect words that have not been hidden yet.
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // Hide random words without selecting the same word twice.
        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    // Extra feature: Count words that are still visible.
    public int GetWordsRemaining()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }
}
