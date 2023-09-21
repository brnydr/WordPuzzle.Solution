using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPuzzle.Models;

namespace WordPuzzle.Test;


[TestClass]
public class GameTest

{
  [TestMethod]
  public void GameConstructor_ShouldCreateInstanceOfGame_Void()
  {
    Game newGame = new Game();

    Assert.AreEqual(typeof(Game), newGame.GetType());
  }

  [TestMethod]
  public void OnNewInstance_WordsArrShouldEqual_Int()
  {
    Game newGame = new Game();
    int actual = newGame.AllPossibleWords.wordList.Count; //Words  -> wordsList {...}
    int expected = 2309;

    Assert.AreEqual(actual, expected);
  }

  [TestMethod]
  public void OnNewInstance_ShouldSetChallengeWord_Void()
  {
    Game newGame = new Game();
    string randomStr = "string";
    Assert.AreEqual(randomStr.GetType(), newGame.TheWord.GetType());
  }

  [TestMethod]
  public void Guess_ShouldReturnCorrect_ForArbitraryInput()
  {
    Game newGame = new Game();
    Guess testGuess = new Guess("aohid");

    int[] expected = [11, 0, 11, 11, 11];

    int[] actual = newGame.Guess(testGuess);

    CollectionAssert.AreEqual(expected, actual);
  }
  
}