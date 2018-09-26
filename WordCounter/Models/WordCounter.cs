using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence; //property - user input to be searched
    private string _word;
    private string _wordCount;

    public RepeatCounter(string sentence, string word)  //constructor
    {
      _sentence = sentence; //to be searched
      _word = word;         //to be counted
    }

    // Methods
    //validate input sentence
    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }
    //validate input word
    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }
    public string GetWordCount()
    {
      return _wordCount;
    }
    public void SetWordCount(int inputResult)
    {
      _wordCount = inputResult.ToString();
    }

    //count the number of words
    public int CountRepeatWords()
    {
      string findWord = _word.ToLower();
      string lowerCaseSentence = _sentence.ToLower();
      string[] sentenceToArray = lowerCaseSentence.Split();
      int count = 0;

      foreach(string word in sentenceToArray)
      {
        if(word == findWord)
        {
          count += 1;
        }
      }
      return count;
    }
  }
}
