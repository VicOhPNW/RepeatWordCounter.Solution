using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _searchInput; //property - user input for List
    public RepeatCounter (string searchInput) //constructor
    {
      _searchInput = searchInput;
    }

    public string GetSearchInput()
    {
      return _searchInput;
    }

    public void SetSearchInput (string newSearchInput)
    {
      // _searchInput = newSearchInput
    }
  }
}
