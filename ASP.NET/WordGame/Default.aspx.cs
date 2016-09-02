using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// To-do List:
// Add timer to the game, decrement/increment depending if user guesses word correctly.
// Make the game detect keypresses from keyboard as a second input method.
// Create a hint for each of the hidden word possibly using the split() method.
// Let the hidden word ignore spaces so can use multiple words.
// Use Bootstrap & CSS to make things more pretty.

public partial class _Default : System.Web.UI.Page
{
    private static List<Button> btnList;
    private static string[] wordsList;
    private static string[] readFile;
    private static char[] hiddenChar;
    private static char[] wordChar;

    private static string path;
    private static string word;
    private static string hidden;
    private static string letter;

    private static int randomIndex;
    private static int wrongGuess;
    private static int timeLeft;

    private static double score;
    private static double currentScore;
    private static double multiplier;

    private static bool ansCorrect;

    protected void Page_Load(object sender, EventArgs e)
    {
        btnList = new List<Button>() { qBtn, wBtn, eBtn, rBtn, tBtn, yBtn, uBtn, iBtn, oBtn, pBtn,
                                       aBtn, sBtn, dBtn, fBtn, gBtn, hBtn, jBtn, kBtn, lBtn,
                                       zBtn, xBtn, cBtn, vBtn, bBtn, nBtn, mBtn };


        /*if (Session["timer"] == null)
        {
            startTimer(30);
            //Session["timeout"] = DateTime.Now.AddSeconds(30).ToString();
        }*/

        if (!IsPostBack) 
        {
            scoreLbl.Text = "SCORE: 0";
            setup();
            startTimer(30);
        }   
    }

    protected void setup()
    {
        hidden = "";
        lettersLbl.Text = "";
        wordLbl.Text = "";

        wrongGuess = 0;
        multiplier = 2.00;
        score = 500;
        timeLeft = 10;

        ansCorrect = false;

        noGuessLbl.Text = "Wrong Letter Count: " + wrongGuess;
        multiLbl.Text = "Current Multiplier: x" + multiplier;

        path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"Resources\wordsP.txt");
        readFile = File.ReadAllLines(path);
        randomIndex = (new Random().Next(readFile.Length));
        word = readFile[randomIndex].ToUpper();

        testLbl2.Text = word;

        for (int i = 0; i < word.Length; i++) {
            hidden += "_";
        }

        for (int i = 0; i < hidden.Length; i++) {
            wordLbl.Text += hidden.Substring(i, 1);
            wordLbl.Text += " ";
        }

        foreach (Button b in btnList) {
            b.Enabled = true;
        }
    }

    public void letterGuessed (object sender, CommandEventArgs e)
    {
        letter = e.CommandArgument.ToString();
        letter.ToCharArray();

        if (word.Contains(letter)) {
            hiddenChar = hidden.ToCharArray();
            wordChar = word.ToCharArray();

            for (int i = 0; i < wordChar.Length; i++) {
                if (wordChar[i] == letter[0]) { hiddenChar[i] = letter[0]; }
            }
       
            hidden = new string(hiddenChar);
            updateScreen();
        }

        else {
            lettersLbl.Text += e.CommandArgument;
            wrongGuess++;
        
            if (wrongGuess >= 1 && wrongGuess < 2) { multiplier = 1.75; }

            else if (wrongGuess >= 2 && wrongGuess < 4 ) { multiplier = 1.50; }

            else if (wrongGuess >= 4 && wrongGuess < 6) { multiplier = 1.25; }

            else { multiplier = 1.00; }

            updateScreen();
        }

        foreach (Button b in btnList)
        {
            if (b.Text.Equals(e.CommandArgument)) { b.Enabled = false; }
        }

        if (hidden == word) {
            score *= multiplier;
            ansCorrect = true;
            updateScreen();
            setup();
        }

    }

    public void startTimer(int seconds)
    {
        Session.Add("timer", seconds);
        timer.Enabled = true;
    }

    protected void updateScreen()
    {
        wordLbl.Text = "";
 
        if (ansCorrect == true) {
            currentScore += score;
            scoreLbl.Text = "SCORE: " + currentScore;
        }

        noGuessLbl.Text = "Wrong Letter Count: " + wrongGuess;
        multiLbl.Text = "Current Multiplier: x" + multiplier;

        for (int i = 0; i < hidden.Length; i++) {
            wordLbl.Text += hidden.Substring(i, 1);
            wordLbl.Text += " ";
        }
    }

    protected void timer_Tick(object sender, EventArgs e)
    {
        int seconds = (int)Session["timer"];
        if (seconds > 0)
        {
            seconds--;
            Session["timer"] = seconds;
            timeLbl.Text = seconds.ToString();
        }
        else
        {
            timer.Enabled = false;
        }
        /*if (timeLeft > 0)
        {
            timeLeft--;
            timeLbl.Text = "Time Remaining: " + timeLeft;
        }

        else
        {
            foreach (Button b in btnList)
            {
                b.Enabled = false;
            }

            timeLbl.Text = "Time's Up!";

            wordLbl.Text = word;

        
        }*/
        /*if (0 > DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timeout"].ToString())))
        {
            timeLbl.Text = "Number of seconds left: " +
            ((Int32)DateTime.Parse(Session["timeout"].
            ToString()).Subtract(DateTime.Now).TotalSeconds).ToString();
        }*/

    }
}