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
        [TestMethod]
        public void AnswerRiddle_CorrectAnswer_ReturnsTrue()
        {
            // Arrange
            Riddle sphinxRiddle = new Riddle();
            string expectedRiddle = "What is always in front of you but can't be seen?";
            string expectedAnswer = "The future";

            // Act
            bool result = sphinxRiddle.AnswerRiddle(expectedRiddle, expectedAnswer);

            // Assert
            Assert.IsTrue(result);
        }
    }
}