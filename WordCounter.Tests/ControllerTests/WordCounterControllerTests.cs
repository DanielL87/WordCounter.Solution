using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordApp.Controllers;
using WordApp.Models;

namespace WordApp.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
        //Arrange
        WordCounterController controller = new WordCounterController();

        //Act
        IActionResult view = controller.Create("Walk the dog", "String");

        //Assert
        Assert.IsInstanceOfType(view, typeof(ActionResult));
    }
    }
}