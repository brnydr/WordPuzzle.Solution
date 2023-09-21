

namespace WordPuzzle.Models
{
  public class Guess
  {
    public string Word { get; set; }
    public int[] PositionBooleanSet { get; set; } = new int[5]; // {0, 11, 10, 0, 11}
    public char[] CharArr = new char[5];
    public Guess(string word)
    {
      this.Word = word;
      this.CharArr = this.Word.ToCharArray();
    }
  }

  
}