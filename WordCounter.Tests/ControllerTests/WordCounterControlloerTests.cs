using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;
using WordCounter.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter
{
  [TestClass]
  public class WordCounterControllerTest : Controller
  {
      [TestMethod]
      public void Index_ReturnWordCounterIndex_true()
      {
        WordCounterController controller = new WordCounterController();

        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      // [TestMethod]
      // public void Index_ReturnWordCounterIndex_string()
      // {
      //   //code goes here
      //   //attempted to test
      // }
  }
}
