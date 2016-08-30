using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(RegularExpressionValidator1.IsValid)
        {
            LabelOutput.Text = "You entered a valid e-mail address.";
        }

       

        else 
        {
            LabelOutput.Text = "Invalid e-mail address.";

        }
  
        //LabelOutput.Text = "You have typed " + TextBoxName.Text.Length + " characters.";
    }

 
    protected void ButtonCheckBox_Click(object sender, EventArgs e)
    {
        if(CheckBox1.Checked)
        {
            LabelOutput2.Text = "The checkbox has been checked.";
        }
        else
        {
            LabelOutput2.Text = "The checkbox is unchecked.";
        }
    }

    protected void ButtonRadio_Click(object sender, EventArgs e)
    {
        if (RadioCheck.Checked)
        {
            LabelOutput3.Text = "The radio button is checked";
        }
        else
        {
            LabelOutput3.Text = "The radio button is unchecked";
        }
    }


    protected void RadioListButton_Click(object sender, EventArgs e)
    {
        LabelOutput4.Text = "You selected: " + RadioButtonList1.SelectedItem.Text;
    }

    protected void ListBoxButton_Click(object sender, EventArgs e)
    {
        LabelOutput5.Text = "You have chosen: " + ListBox1.SelectedItem.Text + " from the list box.";

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        LabelOutput6.Text = "Date selected is: " + Calendar1.SelectedDate.ToShortDateString();

    }

    protected void CheckLButton_Click(object sender, EventArgs e)
    {
        for(int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
           if (CheckBoxList1.Items[i].Selected)
            {
                LabelOutput7.Text += CheckBoxList1.Items[i].Value + "<br/>";

            }
        }
    }
}