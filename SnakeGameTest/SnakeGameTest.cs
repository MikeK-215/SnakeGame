using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeGame;
using System.Linq;

namespace SnakeGameTest
{
    [TestClass]
    public class GameStateTests
    {
        [TestMethod]
        public void GameState_Initializes_Correctly()
        {
            var state = new GameState(10, 10);
            Assert.AreEqual(10, state.Rows);
            Assert.AreEqual(10, state.Cols);
            Assert.AreEqual(Direction.Right, state.Dir);
            Assert.IsFalse(state.GameOver);
            Assert.AreEqual(0, state.Score);
            Assert.AreEqual(3, state.SnakePositions().Count());
        }

        [TestMethod]
        public void Move_Advances_Snake_And_Removes_Tail()
        {
            var state = new GameState(10, 10);
            var initialHead = state.HeadPosition();
            state.Move();
            Assert.AreNotEqual(initialHead, state.HeadPosition());
            Assert.AreEqual(3, state.SnakePositions().Count());
        }

        [TestMethod]
        public void ChangeDirection_Updates_Direction()
        {
            var state = new GameState(10, 10);
            state.ChangeDirection(Direction.Down);
            state.Move();
            Assert.AreEqual(Direction.Down, state.Dir);
        }

        [TestMethod]
        public void Snake_Eats_Food_And_Score_Increases()
        {
            var state = new GameState(5, 5);
            // Place food directly in front of the snake
            var head = state.HeadPosition();
            var foodPos = head.Translate(state.Dir);
            state.Grid[foodPos.Row, foodPos.Col] = GridValue.Food;
            state.Move();
            Assert.AreEqual(1, state.Score);
            Assert.AreEqual(4, state.SnakePositions().Count());
        }

        [TestMethod]
        public void Snake_Hits_Wall_GameOver()
        {
            var state = new GameState(4, 4);
            // Move snake to the right edge
            for (int i = 0; i < 10; i++)
            {
                state.Move();
                if (state.GameOver) break;
            }
            Assert.IsTrue(state.GameOver);
        }

        [TestMethod]
        public void Snake_Cannot_Reverse_Direction()
        {
            var state = new GameState(10, 10);
            state.ChangeDirection(Direction.Left); // Opposite of initial Right
            state.Move();
            Assert.AreEqual(Direction.Right, state.Dir);
        }
    }
}
