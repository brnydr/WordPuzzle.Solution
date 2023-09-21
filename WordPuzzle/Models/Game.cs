using System.Collections.Generic;
using System;
using System.IO;

namespace WordPuzzle.Models
{
  public class Game 
  {
    public Words AllPossibleWords { get; set; } //= { "depth", "stray", "sheet", "agony" };
    public string Letters { get; set; }

    public Dictionary<char, int> charFrequency = new Dictionary<char, int>();
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
    public int Guess(Guess word)
    {
      int index = 0;
      foreach(char c in word.CharArr)
      {
        if(this.charFrequency.ContainsKey(c) && this.charFrequency[c]>0)
        {
          if(this.TheWord.CharAt(index) == c)
          {
            results[index] = 11;
          }
          else
          {
            results[index] = 10;
          }
          this.charFrequency[c]--;
        }git
        else
        {
          results[index] = 0;
        }

        index++;
      }

      word.Guesses = results;

      return results;
      
    }


    internal void OnStart()
    {
      Random random = new Random();
      int index = random.Next(AllPossibleWords.wordList.Count);
      this.TheWord = "aphid"; //AllPossibleWords.wordList[index]; 
      this.CharArr = this.TheWord.ToCharArray();
      foreach (char c in this.TheWord)
      {
        if (this.charFrequency.ContainsKey(c))
        {
          this.charFrequency[c]++;
        }
        else
        {
          this.charFrequency.Add(c, 1);
        }
      }
    }
    
    
    

  }

}