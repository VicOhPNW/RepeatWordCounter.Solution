using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;
using WordCounter.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter
{
  [TestClass]
  public class HomeControllerTest : Controller
  {
    [TestMethod]
    public bool Index_ReturnHomeIndex_true()
    {
      HomeController hc = new HomeController();
      var view = hc.Index();

      //Assert
      
    }

  }
}
