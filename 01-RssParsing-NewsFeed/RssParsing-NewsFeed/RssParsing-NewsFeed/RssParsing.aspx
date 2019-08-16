<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RssParsing.aspx.cs" Inherits="RssParsing_NewsFeed.RssParsing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div id="div1" runat="server">
             <h2><b><u>News Feed</u></b></h2>
            <asp:GridView ID="NewsGridView" runat="server" AutoGenerateColumns="false">
             <Columns>
                <asp:TemplateField HeaderText="News ID" HeaderStyle-BackColor="Yellow">
                 <ItemTemplate>
                  <asp:Label ID = "NewsID" runat = "server" text = '<%#Eval("NewsID")%>' />
                  </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Title" HeaderStyle-BackColor="Yellow">
                 <ItemTemplate>
                  <asp:Label ID = "NewsID" runat = "server" text = '<%#Eval("Title")%>' />
                  </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Category" HeaderStyle-BackColor="Yellow">
                 <ItemTemplate>
                  <asp:Label ID = "NewsID" runat = "server" text = '<%#Eval("Category")%>' />
                  </ItemTemplate>
                </asp:TemplateField>
           </Columns>

            </asp:GridView>


            

        </div>
    </form>
</body>
</html>
