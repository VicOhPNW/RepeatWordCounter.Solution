using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence; //property - user input to be searched

    public RepeatCounter(string sentence) //constructor
    {
      _sentence = sentence;
    }
    public string GetSentence()
    {
      return _sentence;
    }
  }
}
