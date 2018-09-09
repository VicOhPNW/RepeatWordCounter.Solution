using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _searchInput; //property - user input for Search
    private string _findInput; //property - user input for Find

    public RepeatCounter(string searchInput, string findInput) //constructor
    {
      _searchInput = searchInput;
      _findInput = findInput;
    }

    public string GetSearchInput() //method for search input validation
    {
      return _searchInput;
    }

    public void SetSearchInput(string newSearchInput)
    {
      _searchInput = newSearchInput;
    }

    public string GetFindInput() //method for find input validation
    {
      // return _findInput;
    }

  }
}
