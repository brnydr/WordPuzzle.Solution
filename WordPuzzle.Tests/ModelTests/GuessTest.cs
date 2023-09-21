using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordPuzzle.Models;

namespace WordPuzzle.Test;

[TestClass]
public class GuessTests
{
  [TestMethod]
  public void GuessConstructor_ShouldCreateInstanceOfGuess_Void()
  {
    Guess newGuess = new Guess("new");
    Assert.AreEqual(typeof(Guess), newGuess.GetType());
  }

  [TestMethod]
  public void SetWord_ShouldSetWord_Void()
  {
    Guess newGuess = new Guess("fifth");
    string word = "fifth";
    Assert.AreEqual(newGuess.Word, word);
  }

  [TestMethod]
  public void GetCharArray_ReturnsCharArray_CharArray()
  {
    Guess newGuess = new Guess("fifth");
    char[] test = { 'a' };

    Assert.AreEqual(test.GetType(), newGuess.CharArr.GetType());    

  }
  
}