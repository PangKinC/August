using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private List<Button> btnList;
    private String[] wordsList;
    private String[] readFile;
    private String word;
    private String hidden;
    private int randomIndex;

    protected void Page_Load(object sender, EventArgs e)
    {
        btnList = new List<Button>() { qBtn, wBtn, eBtn, rBtn, tBtn, yBtn, uBtn, iBtn, oBtn, pBtn,
                                       aBtn, sBtn, dBtn, fBtn, gBtn, hBtn, jBtn, kBtn, lBtn,
                                       zBtn, xBtn, cBtn, vBtn, bBtn, nBtn, mBtn };
        if (!Page.IsPostBack)
        {
            setup();
        }
    }

    public void setup()
    {
        wordLbl.Text = "";
        // readFile = File.ReadAllLines(@"C:\Users\Suijin\Documents\GitHub\August\ASP.NET\WordGame\Resources\words.txt");
        readFile = File.ReadAllLines(@"C:\Users\student\Kin Pang\GitHub\August\ASP.NET\WordGame\Resources\wordsP.txt");
        randomIndex = (new Random().Next(readFile.Length));
        word = readFile[randomIndex].ToUpper();

        foreach (Button b in btnList) {
            b.Enabled = true;
        }

        for (int i = 0; i < word.Length; i++) {
            hidden += " _ ";
        }

        wordLbl.Text = hidden;
        testLbl2.Text = word;
    }

    protected void letterGuessed (object sender, EventArgs e)
    {
        Button btn = sender as Button;
        char letter = btn.Text.ElementAt(0);

        string test = word;

        //string letter = e.CommandArgument.ToString();
        //letter.ToCharArray();

        if (word.Contains(letter)) {
            char[] hiddenChar = hidden.ToCharArray();
            char[] wordChar = word.ToCharArray();

 

            for (int i = 0; i < wordChar.Length; i++) {
                if (wordChar[i] == letter) { hiddenChar[i] = letter; }
            }

            hidden = new string(hiddenChar);
            updateScreen();
        }

        testLbl.Text += btn.Text;

        foreach (Button b in btnList) {
            if (b.Text.Equals(btn.Text)) { b.Enabled = false; }
        }

    }

    protected void updateScreen()
    {
        wordLbl.Text = hidden;
    }

}