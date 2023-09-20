Users should be presented with a number of blank spaces corresponding to the number of letters in a word. Each round, users should guess a letter:

Game - turns, (board -> spaces)
Game
 Guess(char c) -> 
 {
    Word.contains('a') 
     {
      "a" : 1,
      "b" : 2,
     }
 
  _instances Guess <= 6 and Guess _instances [] -> sort and compare to  charArray[]   --> .sort()
  //MaxGuess = 6--
  
 }

  @foreach (Guess)
  {
    <div class = col-s-6>
  }

  <K,V> 
  {
    "a", 2
    "b", 3
  }

  Guess.foreach(key,value in Guess)
  {
    if(Word.contains(key))
    {
      this.isInWord =true;

      if(Word.GetIndexOf(key) === value)
      {
        this.IsAtIndex = true;
      }
    }
  }




 Guess -> {
  isInWord
  isAtIndex
}

Word -> static length 6

 E p i c o d u s

c h e e s e

x x e e x e



if the letter is in the word, the letter should show up on the webpage
if the letter is not in the word, the number of allowed guesses counts down by 1.
Once the number of guesses reaches 0, the game is over. If the user guesses the word before the number of guesses runs out, they win the game.

Think carefully about the objects you'll use before starting. There are multiple ways to solve this problem.

The computer can generate the words from a pre-set list.
The user should make a guess by entering a letter into a form. The app should tell them if it's right or wrong, and keep track of how many guesses they have left.
On the game page, display the letters they have guessed correctly so far, like: E p _ c _ d u s
Also, display the letters they have guessed incorrectly, and how many guesses they have left.
Make sure to display messages telling the user whether they've guessed correctly or incorrectly. Then a "Game Over" message if they're out of guesses.
Don't allow duplicate guesses. If the user tries to guess the same letter twice they should be told to try again.