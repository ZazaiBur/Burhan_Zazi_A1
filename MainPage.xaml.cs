namespace Burhan_Zazi_A1

{
    public partial class MainPage : ContentPage
    {
        int count = 0; 

        public MainPage()
        {
            InitializeComponent();
        }

    }

}
public class Word
{
    public string Text { get; set; }
    public string Hint { get; set; }

    // Constructor to initialize the word and hint
    public Word(string text, string hint)
    {
        Text = text;
        Hint = hint;
    }
}
public class Game
{
    private List<Word> words = new List<Word>();
    private Word currentWord;
    private int playedCount;
    private int winCount;
    private int currentStreak;
    private int maxStreak;

    // Constructor to initialize the game
    public Game()
    {
        PopulateWords();
        PickRandomWord();
    }

    // Populating words list with at least 10 words
    public void PopulateWords()
    {
        words.Add(new Word("apple", "A fruit that keeps the doctor away."));
        words.Add(new Word("dog", "A man's best friend."));
        words.Add(new Word("computer", "A machine used for processing data."));
        // Add more words here
    }

    // Picking a random word from the list
    public void PickRandomWord()
    {
        Random random = new Random();
        currentWord = words[random.Next(words.Count)];
    }

    // Checking if the user's guess is correct
    public bool CheckGuess(string guess)
    {
        playedCount++;
        if (guess.Equals(currentWord.Text, StringComparison.OrdinalIgnoreCase))
        {
            winCount++;
            currentStreak++;
            if (currentStreak > maxStreak) maxStreak = currentStreak;
            PickRandomWord();
            return true;
        }
        else
        {
            currentStreak = 0;
            return false;
        }
    }

    // Method to reveal the hint
    public string GetHint()
    {
        return currentWord.Hint;
    }

    // Method to check if a letter exists at a certain index
    public string CheckLetter(char letter, int index)
    {
        string wordText = currentWord.Text.ToLower();
        if (index >= wordText.Length)
            return "Index out of bounds!";

        if (wordText[index] == letter)
            return "Correct letter at the given index!";
        else if (wordText.Contains(letter))
            return "Letter exists in the word, but not at the given index.";
        else
            return "Letter not found in the word.";
    }

    // Method to get statistics
    public string GetStatistics()
    {
        double winPercentage = (playedCount > 0) ? (double)winCount / playedCount * 100 : 0;
        return $"Games Played: {playedCount}\nWin Percentage: {winPercentage}%\nCurrent Streak: {currentStreak}\nMax Streak: {maxStreak}";
    }
}
