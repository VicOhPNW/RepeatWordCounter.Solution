using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namepsace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetSearchInput_ReturnsSearchInput_String()
    {
      //Arrange
      string searchInput = "a";
      RepeatCounter newRepeatCounter = new RepeatCounter(searchInput);

      //Act
      string result = newRepeatCounter.GetSearchInput();

      //Assert
      Assert.AreEquual(searchInput, result);
    }
  }
}
