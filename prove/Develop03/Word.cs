using System;
using System.Collections.Generic;

namespace Develop03;

public class Word
{
    public List<string> WordList { get; set; }

    public Word(List<string> wordList)
    {
        WordList = wordList;
    }

    public bool AreAllWordsHidden()
    {
        return !WordList.Contains("__");
    }

    public void ReplaceRandomWords()
    {
        Scripture scripture = new Scripture();

        scripture.Hide(WordList);
    }
}