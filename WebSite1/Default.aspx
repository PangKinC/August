<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Dynamic Web Form </title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 1655px">
        <h1> My very first ASP.NET Web Forms page  </h1>
            <asp:Label ID="LabelDate" runat="server" Text="Please type in your name: "></asp:Label>  
            <asp:TextBox ID="TextBoxName" runat="server" Height="16px" style="margin-top: 0px" ValidationGroup="Test" Width="200px"></asp:TextBox>
            <asp:Button ID="ButtonName" runat="server" Text="Button" OnClick="Button1_Click" />

            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxName" Display="Dynamic" ErrorMessage="Invalid e-mail address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Test"></asp:RegularExpressionValidator>

            <br /> <br />
            <asp:Label ID="LabelOutput" runat="server" Text=""></asp:Label>
            <br /> <br />
            <asp:Label ID="LabelCheck" runat="server" Text="Please check or uncheck the box "></asp:Label> 
            <br /> <br />
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <br /> <br />
            <asp:Button ID ="ButtonCheckBox" runat="server" Text="Check Box Button" OnClick="ButtonCheckBox_Click" />
            <br /> <br />
            <asp:Label ID="LabelOutput2" runat="server"></asp:Label>
            <br /> <br />
            <asp:Label ID="LabelRadio" runat="server" Text="Please click the radio button"></asp:Label> 
            <br /> <br />
            <asp:RadioButton ID ="RadioCheck" runat="server" />
            <br /> <br /> 
            <asp:Button ID ="ButtonRadio" runat="server" Text="RadioButton Button" OnClick="ButtonRadio_Click" />
            <br /> <br />
            <asp:Label ID="LabelOutput3" runat="server"></asp:Label>
            <br /> <br />
            <asp:Label ID="LabelRadioList" runat="server" Text="Please click one of the the radio buttons"></asp:Label>
            <br /> <br /> 
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="Radio Button 1"></asp:ListItem>
                <asp:ListItem Value="Radio Button 2"></asp:ListItem>
                <asp:ListItem Value="Radio Button 3"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID ="RadioListButton" runat="server" Text="RadioButtonList Button" OnClick="RadioListButton_Click" />
            <br /> <br />
            <asp:Label ID="LabelOutput4" runat="server"></asp:Label>
            <br />
            <br /> <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="55px" ImageUrl="http://vignette2.wikia.nocookie.net/naruto/images/e/e0/Mangeky%C5%8D_Sharingan_Kakashi.svg/revision/latest?cb=20140427104242" Width="53px" PostBackUrl="http://vignette2.wikia.nocookie.net/naruto/images/e/e0/Mangeky%C5%8D_Sharingan_Kakashi.svg/revision/latest?cb=20140427104242" />
            <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br /> 
        <br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>Suijin</asp:ListItem>
            <asp:ListItem>Nijius</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="ListBoxButton" runat="server" OnClick="ListBoxButton_Click" Text="ListBox Button" />
        <br />
        <br />
        <asp:Label ID="LabelOutput5" runat="server"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" SelectedDate="2016-08-27"></asp:Calendar>
        <br />
        <asp:Label ID="LabelOutput6" runat="server"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Pikachu</asp:ListItem>
            <asp:ListItem>Charmander</asp:ListItem>
            <asp:ListItem>Bulbasaur</asp:ListItem>
            <asp:ListItem>Squirtle</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="CheckLButton" runat="server" OnClick="CheckLButton_Click" Text="CheckList Button" />
        <br />
        <br />
        <asp:Label ID="LabelOutput7" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelOutput8" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelOutput9" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelOutput10" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" Width="176px">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Name">
                    Kin
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Sport">
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
         
    </div>

    </form>
</body>
</html>
