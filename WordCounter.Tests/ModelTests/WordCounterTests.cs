using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;

namespace WordCounter
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetSearchInput_ReturnsSearchInput_String()
    {
      //Arrange
      string searchInput = "apple";
      RepeatCounter newRepeatCounter = new RepeatCounter(searchInput);

      //Act
      string result = newRepeatCounter.GetSearchInput();

      //Assert
      Assert.AreEqual(searchInput, result);
    }

    [TestMethod]
    public void SetSearchInput_SetSearchInput_String()
    {
      //Arrange
      string searchInput = "apple";
      RepeatCounter newRepeatCounter = new RepeatCounter(searchInput);

      //Act
      string updatedSearchInput = "orange";
      newRepeatCounter.SetSearchInput(updatedSearchInput);
      string result = newRepeatCounter.GetSearchInput();

      //Assert
      Assert.AreEqual(updatedSearchInput, result);
    }
  }
}
