<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Table Reservation</h2>
            <asp:Label ID="lblMessage" runat="server" Text="Reservation" ForeColor="green"></asp:Label>
            <table>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Room Type:</td>
                    <td>
                        <asp:DropDownList ID="ddlRoomType" runat="server">
                            <asp:ListItem Value="Single">Single</asp:ListItem>
                            <asp:ListItem Value="Double">Double</asp:ListItem>
                            <asp:ListItem Value="Suite">Suite</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Check-in Date:</td>
                    <td><asp:TextBox ID="txtCheckInDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Check-out Date:</td>
                    <td><asp:TextBox ID="txtCheckOutDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
