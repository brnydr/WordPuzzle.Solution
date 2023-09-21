using System.Collections.Generic;
using System;
using System.IO;

namespace WordPuzzle.Models
{
  public class Game 
  {
    public Words AllPossibleWords { get; set; } //= { "depth", "stray", "sheet", "agony" };
    public string Letters { get; set; }

    public List<Guess> pastGuesses { get; set; }  //{"a" : 5} 


    public bool GameStatus { get; set; } = true;
    public string TheWord {get; set; }

    public char[] CharArr { get; set; }


    public Game()
    {
      AllPossibleWords = new Words();
      this.OnStart();
    }

    //n   yn   yy
    //0   10   11
    public void Guess(Guess word)
    {
      int index = 0; 
      int[] results = new int[5];
      
      foreach(char c in word.CharArr)
      {
        string subStr = c.ToString();
        
        if (this.TheWord.Contains(subStr))  // -> Contains -> 'c'-> "crab" 
        {
          if (this.TheWord.CharAt(index) == index) // TheWord = 'apply'
          {
            results[index] = 11;
          }
          results[index] = 10;
        } else
        {
          results[index] = 0;
        } 
        index++;
      }

      word.Guesses = results;

      this.pastGuesses.Add(word);
      
      this.GuessCount++;
      
    }


    internal void OnStart()
    {
      Random random = new Random();
      int index = random.Next(AllPossibleWords.wordList.Count);
      this.TheWord = "aphid"; //AllPossibleWords.wordList[index];
      this.CharArr = this.TheWord.ToCharArray();
    }
    
    
    

  }

}