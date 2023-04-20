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
        [TestMethod]
        public void AnswerRiddle_IncorrectAnswer_ReturnsFalse()
        {
            // Arrange
            Riddle sphinxRiddle = new Riddle();
            string expectedRiddle = "What has a heart that doesn't beat?";
            string expectedAnswer = "A artichoke";

            // Act
            bool result = sphinxRiddle.AnswerRiddle(expectedRiddle, expectedAnswer);

            // Assert
            Assert.IsFalse(result);
        }
    }
}