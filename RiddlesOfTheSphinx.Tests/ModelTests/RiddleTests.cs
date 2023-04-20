using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiddlesOfTheSphinx.Models;

namespace RiddlesOfTheSphinx.Tests
{
    [TestClass]
    public class RiddleTests
    {
        [TestMethod]
        public void RiddleConstructor_CreatesInstanceOfRiddle_Riddle()
        {
          // Arrange
          // Act
          Riddle newRiddle = new Riddle();
      
          // Assert
          Assert.AreEqual(typeof(Riddle), newRiddle.GetType());
        }
    }
}