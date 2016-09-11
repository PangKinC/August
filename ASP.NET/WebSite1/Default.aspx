<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        var isCtrl = false;
        document.attachEvent('onkeyup', KeyUpHandler);
        document.attachEvent('onkeydown', KeyDownHandler);
 
        function KeyUpHandler()
        {
            if (event.keyCode == 17)
            {
                isCtrl=false;
            }
        }
 
        function KeyDownHandler()
        {
            if (event.keyCode == 17)
            {
                isCtrl=true;
            }
            if (event.keyCode == 81)
            {
                document.getElementById('btnOne').click();
            }
            else if (event.keyCode == 67 && isCtrl == true)
            {
                
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtOne" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
        <p>
            <asp:Button ID="btnOne" runat="server" Height="26px" OnClick="btnOne_Click" Text="Test" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
