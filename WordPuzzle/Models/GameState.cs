using System.Collections.Generic;
using System;
using System.IO;



namespace WordPuzzle.Models

{
  public class GameState 
  {

    public string[] AllPossibleWords { get; set; } = { "depth", "stray", "sheet", "agony" };
    public string Letters { get; set; }
    public string Guess { get; set; }
    public bool GameStatus { get; set; } = true;
    public string TheWord {get; set; }


    public GameState()
    {

      TheWord = AllPossibleWords[0]; //depth

    }


    internal void OnStart()
    {
      Random random = new Random();
      int index = random.Next(AllPossibleWords.wordList.Count);
      this.TheWord = AllPossibleWords.wordList[index];
      
    }
  }

}