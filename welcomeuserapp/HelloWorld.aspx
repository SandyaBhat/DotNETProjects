<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="welcomeuserapp.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello World</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <h2>Hello World!</h2>
       <span>Enter your name:</span>
        <input type="text" id="txtName" runat="server" />
        <asp:Button ID="btnsubmit"  runat="server" OnClick="btnsubmit_Click" Text="Submit" />    
        <br />
        <span id="spnmessage" runat="server"></span>
    </div>
    </form>
</body>
</html>
