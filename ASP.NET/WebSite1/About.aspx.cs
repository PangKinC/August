using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void normBtn_Click(object sender, EventArgs e)
    {
        Global.NormBool = true;
        Response.Redirect("Default.aspx");
    }

    protected void testSubject_CheckedChanged(object sender, EventArgs e)
    {
        Global.GenBool = true;
    }
}