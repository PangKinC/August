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

        setup();

    }

    public void setup()
    {
        readFile = File.ReadAllLines(@"C:\Users\Suijin\Documents\GitHub\August\ASP.NET\WordGame\Resources\words.txt");
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

    public void updateScreen()
    {
        wordLbl.Text = hidden;
    }


    public void letterGuessed (object sender, CommandEventArgs e)
    {
        string letter = e.CommandArgument.ToString();
        letter.ToCharArray(); ;
        
        if (word.Contains(letter)) {
            char[] hiddenChar = hidden.ToCharArray();
            char[] wordChar = word.ToCharArray();

            for (int i = 0; i < wordChar.Length; i++) {
                if (wordChar[i] == letter[0]) { hiddenChar[i] = letter[0]; }
            }

            hidden = new string(hiddenChar);
            updateScreen();
        } 

        testLbl.Text += e.CommandArgument;

        foreach (Button b in btnList) {
            if (b.Text.Equals(e.CommandArgument)) { b.Enabled = false; }
        }

    }
    
}