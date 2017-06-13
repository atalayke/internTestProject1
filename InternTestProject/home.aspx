<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="InternTestProject.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-decoration: underline">
    
        Grants and Principal Investigators</div>
        <p>
            View and modify information regarding grants and principal investigators.</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/grants.aspx">Grants</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/principalInvestigators.aspx">Principal Investigators</asp:HyperLink>
        </p>
    </form>
</body>
</html>
