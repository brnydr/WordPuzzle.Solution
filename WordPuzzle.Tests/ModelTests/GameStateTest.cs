using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPuzzle.Models;

namespace WordPuzzle.Test;


[TestClass]
public class GameStateTest

{
  [TestMethod]
  public void GameConstructor_ShouldCreateInstanceOfGame_Void()
  {
    GameState newGame = new GameState();

    Assert.AreEqual(typeof(GameState), newGame.GetType());
  }

  [TestMethod]
  public void OnNewInstance_WordsArrShouldEqual_Int()
  {
    GameState newGame = new GameState();
    int actual = newGame.AllPossibleWords.wordList.Count; //Words  -> wordsList {...}
    int expected = 2309;

    Assert.AreEqual(actual, expected);
  }

  [TestMethod]
  public void OnNewInstance_ShouldSetChallengeWord_Void()
  {
    GameState newGame = new GameState();
    string randomStr = "string";
    Assert.AreEqual(randomStr.GetType(), newGame.TheWord.GetType());
   
  }
}
