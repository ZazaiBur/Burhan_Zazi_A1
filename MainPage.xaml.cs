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
        words.Add(new Word("dog", "Woof."));
        words.Add(new Word("computer", "A machine is used for many thing."));
        // Add more words here
    }

    // Picking a random word from the list
    public void PickRandomWordpublic class Game
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
        words.Add(new Word("grape", "A fruit that may be used in wine."));
        words.Add(new Word("grade", "A value that represents a students marks or maturity (in a way)."));
        words.Add(new Word("quick", "Another word for fast."));
        words.Add(new Word("cozey", "Nice and _____."));
        words.Add(new Word("field", "Please let this be a normal ______trip."));
        words.Add(new Word("chewy", "This steak is nice and _____."));
        words.Add(new Word("joker", "Batman's main villian."));
        words.Add(new Word("hippy", "Take a bath _____! (Up the movie.)."));
        words.Add(new Word("boxer", "What profession was Muhammed Ali?"));
        
    }

    // Picking a random word from the list
    public void PickRandomWord()
    {
        Random random = new Random();
        currentWord = words[random.Next(words.Count)];
    }

    // Checking if guess is correct
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
            return "Correct letter at the given Place!";
        else if (wordText.Contains(letter))
            return "Letter exists in the word, but not at the given Place.";
        else
            return "Letter not found in the word!";
    }

    // Method to get statistics
    public string GetStatistics()
    {
        double winPercentage = (playedCount > 0) ? (double)winCount / playedCount * 100 : 0;
        return $"Games Played: {playedCount}\nWin Percentage: {winPercentage}%\nCurrent Streak: {currentStreak}\nMax Streak: {maxStreak}";
    }
// up untill this point i had quite some help from chatgpt (With foundation and some game logic) as i already had some issues already and is why the code might look a bit fishy
}
