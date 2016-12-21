using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Global.NormBool == true)
        {
            Label1.Text = "Difficulty: True";
            Global.NormBool = false;
        }

        if (Global.GenBool == true)
        {
            Label2.Text = "Subject: True";
            Global.GenBool = false;
        }

    }
}