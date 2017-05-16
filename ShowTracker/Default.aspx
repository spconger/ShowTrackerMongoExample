<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <h2><%#Eval("VenueKey") %></h2>
                <p><%#Eval("Address") %> <br />
                   <%#Eval("City") %> <br />
                   <%#Eval("ZipCode") %> <br />
                    <%#Eval("email") %> <br />
                    <a href='<%#Eval("URL") %>' ><%# Eval("URL") %></a>


                </p>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
