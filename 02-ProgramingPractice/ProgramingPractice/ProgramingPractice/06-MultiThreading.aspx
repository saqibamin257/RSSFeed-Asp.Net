<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="06-MultiThreading.aspx.cs" Inherits="ProgramingPractice._06_MultiThreading" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">        
        <div>
            <asp:Button runat="server" Text="Single Thread Process" OnClick="SingleThread_Click" />
        </div>
        <div>
            <asp:Button runat="server" Text="Multi Thread Process" OnClick="MultiThread_Click" />
        </div>
        <p runat="server" id="p2">
          
        </p>
    </form>
</body>
</html>
