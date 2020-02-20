using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_GameOfTwoStacks
{
    [TestClass]
    public class UnitTest_Game
    {
        [TestMethod]
        public void Test_GameOfTwoStacks()
        {
            // Arrange
            int expected = 4;
            int maxScore = 10;
            int[] stackA = { 4, 2, 4, 6, 1 };
            int[] stackB = { 2, 1, 8, 5 };

            // Act
            int actual = new GameOfTwoStacks_DanielVilar.Game().GameOfTwoStacks(maxScore, stackA, stackB);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
