<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayersDetails.aspx.cs" Inherits="PlayerListAssignment.PlayersDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        <asp:RadioButton ID="CricketPlayers" runat="server" Text="Cricket" OnCheckedChanged="CricketPlayers_CheckedChanged" AutoPostBack="true"/>
        
        <asp:RadioButton ID="TennisPlayers" runat="server" Text="Tennis" OnCheckedChanged="TennisPlayers_CheckedChanged" AutoPostBack="true"/>
       
        <asp:Panel ID="Panel1" runat="server">
            <asp:HyperLink ID="HyperLink1"  runat="server" NavigateUrl="SouravGanguly.html">Sourav Ganguly </asp:HyperLink>
            <asp:HyperLink ID="HyperLink2"  runat="server" NavigateUrl="https://en.wikipedia.org/wiki/MS_Dhoni">   Mahendra Singh Dhoni    </asp:HyperLink>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="https://en.wikipedia.org/wiki/Rafael_Nadal">Rafael Nadal    </asp:HyperLink>
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="https://en.wikipedia.org/wiki/Novak_Djokovic">    Novak Djokovic    </asp:HyperLink>
        </asp:Panel>
        <p>
            &nbsp;</p>
                    </div>
    </form>
</body>
</html>
