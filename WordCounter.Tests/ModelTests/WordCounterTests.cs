using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetSentence_ReturnsSentenceInput_String()
    {
      //Arrange
      string sentence = "apple";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence);

      //Act
      string result = newRepeatCounter.GetSentence();

      //Assert
      Assert.AreEqual(sentence, result);
    }
  }
}
