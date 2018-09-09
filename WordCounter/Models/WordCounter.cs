using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _searchInput; //property - user input for Search

    public RepeatCounter(string searchInput) //constructor
    {
      _searchInput = searchInput;
    }

    public string GetSearchInput() //method for search input validation
    {
      return _searchInput;
    }
    public void SetSearchInput(string newSearchInput)
    {
      _searchInput = newSearchInput;
    }
  }
}
