using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

// First Project: Word Guessing Game.
/* My first project for portfolio, is a simple rendition of a word guessing game, unlike the traditional hangman 
 * game this, carries on until the timer expires.
 * Some features include having a final score which goes up for every word the user gets right and 
 * a multiplier which increases/decrease the less letters a user guesses incorrectly,
 * along with a hint for each of the hidden word */
 
// To-do List:
// -- Add timer to the game, decrement/increment depending if user guesses word correctly.
// Make the game detect keypresses from keyboard as a second input method.
// -- Create a hint for each of the hidden word possibly using the split() method.
// Let the hidden word ignore spaces so can use multiple words.
// Use Bootstrap & CSS to make things more pretty.

public partial class _Default : System.Web.UI.Page
{ 
    // Here we define all the variables that would be used in the program, I will explain a few below.
    // The two variables here both play a role in reading file path and turning it into a single string.
    private static string[] readPath;
    private static string readFile;

    // The different data structures to be used, we use the first list to add in the single string from the file.
    // The second dictionary adds from the first list then splits into the last two seperate lists.
    private static List<string> wholeList = new List<string>();
    private static Dictionary<int, string> splitList = new Dictionary<int, string>();
    private static List<string> wordsList = new List<string>();
    private static List<string> hintsList = new List<string>();

    // Delimiter which we use for our split() method to seperate the single string from file into multiple strings.
    private static char[] delimiter = { '_', '.' };
    // This list of buttons holds all the different alphabet keys.
    private static List<Button> btnList;
    // Boolean to determine whether word guess is correct.
    private static bool correctWord;
    // We use this to increment our timer used for the game.
    private static int seconds { get; set; }

    private static double score;
    private static double currentScore;
    private static double multiplier;

    private static char[] hiddenChar;
    private static char[] wordChar;

    private static string word;
    private static string hidden;
    private static string letter;
    private static string hint;

    private static int randomIndex;
    private static int wrongGuess;

    // The set of instructions which is done as soon as the page is loaded.
    protected void Page_Load(object sender, EventArgs e)
    {
        // Here we add the all the different buttons on the form, representing each of the alphabet keys.
        btnList = new List<Button>() { qBtn, wBtn, eBtn, rBtn, tBtn, yBtn, uBtn, iBtn, oBtn, pBtn,
                                       aBtn, sBtn, dBtn, fBtn, gBtn, hBtn, jBtn, kBtn, lBtn,
                                       zBtn, xBtn, cBtn, vBtn, bBtn, nBtn, mBtn };

        // This if statement goes through as long as the page is not in a postback state.
        if (!IsPostBack) 
        {
            // The readPath variable reads our file from the resources directory, note that we don't need to specify the whole path file.
            readPath = File.ReadAllLines(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"Resources\test.txt"));

            // Simple for loop which reads through the readPath and adds them into readFile as single string.
            for (int i = 0; i < readPath.Count(); i++) { readFile += readPath[i]; }
             
            // The list: wholelist then adds the above readFile string array and splits them with the characters specified above.
            wholeList.AddRange(readFile.Split(delimiter));

            // This time we add the wholelist into a dictionary using a for loop, note it takes the index from the 
            // for loop as the key for the dictionary, note there's a if statement so keys don't get duplicated.
            for (int i = 0; i < wholeList.Count(); i++) {
                if (!splitList.ContainsKey(i)) { splitList.Add(i, wholeList[i]); }
            }

            // Using a lambda expression, we do a modular calculation on the dictionary keys to split the values
            // into two different lists (the word and hint more specifically)
            wordsList = splitList.Where(item => item.Key % 2 == 0).Select(item => item.Value).ToList();
            hintsList = splitList.Where(item => item.Key % 2 != 0).Select(item => item.Value).ToList();

            // Sets the Score label to 0, only called here once because it changes throughout the game.
            // Then calls the setup method, which sets up a new hidden word and starts the timer for the game.
            scoreLbl.Text = "SCORE: 0";
            setup();
            startTimer(31);
            seconds = (int)Session["timer"];
        }   
    }

    // The setup() method is called everytime a word has been guessed to set up a new one.
    protected void setup()
    {
        // These three labels have to be reset to empty otherwise the display will not change for each new word.
        hidden = "";
        lettersLbl.Text = "";
        wordLbl.Text = "";

        // We set the correctWord to false as it's a new word.
        correctWord = false;
        // The following integers and doubles are reset for the score and multiplier as well as number of wrong guesses.
        wrongGuess = 0;
        multiplier = 2.00;
        score = 500;

        // These two labels text will be set to reflect the integer being reset.
        guessNoLbl.Text = "Wrong Letter Count: " + wrongGuess;
        multiLbl.Text = "Current Multiplier: x" + multiplier;

        // The random index uses the random class to assign new random number to take from the list.
        // It's max length never goes over max string count in the list.
        randomIndex = new Random().Next(wordsList.Count());

        // We assign to the word and hint the same random index, and to take a single object from a list.
        word = wordsList[randomIndex];
        hint = hintsList[randomIndex];

        // We set this label to the random hint from the above list.
        hintLbl.Text = word;

        // Using some regular expressions replace any spaces between words with a forward slash.
        hidden = new Regex(" ").Replace(word, " / ");
        // Then we replace each of the letter/number with a _ to make it hidden.
        hidden = new Regex("([a-zA-z0-9])").Replace(hidden, "_ ");
        // Finally we set the word label to the hidden word which is now a set of _
        wordLbl.Text = hidden;

        // Using two different for loops, we make go through the word length and assigns to hidden the same number of _
        /*for (int i = 0; i < word.Length; i++) {
            hidden += '_'; 
        }

        // Using some minor string format with substring we then place a space between each character.
        for (int i = 0; i < hidden.Length; i++) {
            wordLbl.Text += hidden.Substring(i, 1);
            wordLbl.Text += " ";
        }*/

        // Finally we enable all the buttons in the game again as it's a new word at this point.
        foreach (Button b in btnList) {
            b.Enabled = true;
        }
    }

    // The letterGuessed is called on every button click in which all buttons have this same method assigned to onCommand.
    // We also use the Command argument e instead of the usual sender as button for the value.
    public void letterGuessed (object sender, CommandEventArgs e)
    {
        // We take the command argument of the button then it into a string and finally a character array.
        letter = e.CommandArgument.ToString();
        letter.ToCharArray();
 
        // This if statement block checks the word in uppercase and see if it contains the above letter (char array)
        if (word.ToUpper().Contains(letter)) {
            // We then turn both the hidden and word into character arrays.
            hiddenChar = hidden.ToCharArray();
            wordChar = word.ToUpper().ToCharArray();
            
            // Using a for loop, which carries on until it reaches the max length of the word, it checks
            // Whether the character in the word matches the letter guessed. 
            // If it does we assign to the hidden string the new letter.
            for (int i = 0; i < word.Length; i++) {
                if (wordChar[i] == letter[0]) { hiddenChar[i] = letter[0]; }
            }

            // Hidden then recompiles as a new string the above hidden character array with the new letter.
            hidden = new string(hiddenChar);
            // We call the updateScreen() method to update all the visuals on screen.
            updateScreen();
        }
        // The else statement is called if the word didn't contain the letter.
        else {
            // It increments the letter label with each incorrect letter the user guessed.
            lettersLbl.Text += e.CommandArgument;
            // It also increments the wrong guess by a single 1 each incorrect guess.
            wrongGuess++;

            // This mini if else statement block changes the multiplier depending on the number of incorrect guesses.
            if (wrongGuess >= 1 && wrongGuess < 3) { multiplier = 1.75; }
            else if (wrongGuess >= 3 && wrongGuess < 5) { multiplier = 1.50; }
            else if (wrongGuess >= 5 && wrongGuess < 7) { multiplier = 1.25; }
            else { multiplier = 1.00; }
            // Finally again we called updateScreen() in order to update the relevant visuals.
            updateScreen();
        }

        // We use this foreach loop to make sure the same button cannot be pressed again.
        foreach (Button b in btnList) { if (b.Text.Equals(e.CommandArgument)) { b.Enabled = false; } }
    
        // Finally if the hidden word has all been revealed (made equal to word), we set correctWord to true.
        // Then updateScreen() method for visuals and finally the setup() method to start a new word.
        if (hidden == word) {
            score *= multiplier;
            correctWord = true;
            updateScreen();
            setup();
        }
    }
 
    // The updateScreen() method is used to refresh all the relevant information shown on screen to the user.
    protected void updateScreen()
    {
        // We have to set the word label to empty on each click otherwise it would just get longer and longer.
        wordLbl.Text = "";
 
        // If the user guessed the correct word, we finally increment the score with this if statement.
        if (correctWord == true) {
            // Note that currentScore is made equal to score which is always a static 500
            // But the score label withs currentScore rather score as to increment on each correct word guess.
            currentScore += score;
            scoreLbl.Text = "SCORE: " + currentScore;
        }

        // We update these respective labels the multiplier and the number of wrong guesses.
        guessNoLbl.Text = "Wrong Letter Count: " + wrongGuess;
        multiLbl.Text = "Current Multiplier: x" + multiplier;

        // Finally we use this for loop to keep the string format the same throughout the game.
        for (int i = 0; i < hidden.Length; i++) {
            wordLbl.Text += hidden.Substring(i, 1);
            wordLbl.Text += " ";
        }
    }

    // This mini method is purely here to start and increment the timer we use in the game.
    public void startTimer(int seconds)
    {
        // Note that it adds the timer on a new session created.
        Session.Add("timer", seconds);
        timer.Enabled = true;
    }

    // The timer tick method updates every 1000 milliseconds (1 second) with the following instructions
    protected void timer_Tick(object sender, EventArgs e)
    {
        // If seconds is over 0, the if statement block goes through, and decrements the seconds each second
        if (seconds > 0) {
            seconds--;
            // We make sure that timer session is equavilent to the seconds in question
            Session["timer"] = seconds;
            // Finally we assign to the timer label the seconds remaining
            timeLbl.Text = "Time remaining: " + seconds.ToString();
        }
        // Else if seconds is not over (aka is 0) this block of instructions goes off.
        else {
            // We show on the word label the whole word which the user was currently attempting.
            wordLbl.Text = word;
            // Disable every button found in the game.
            foreach (Button b in btnList) { b.Enabled = false; }
            // Finally we set the timer to not enabled (visible).
            timer.Enabled = false;
        }
    }
}