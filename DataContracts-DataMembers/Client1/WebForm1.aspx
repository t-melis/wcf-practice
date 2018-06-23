<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Client1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Date Of Birth"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Employee Type"></asp:Label>
            <asp:DropDownList ID="ddIEmployeeType" runat="server" OnSelectedIndexChanged="ddIEmployeeType_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="Select Employee Type" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Full Time Employee" Value="1"></asp:ListItem>
                <asp:ListItem Text="Part Time Employee" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Annual Salary"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Hourly Pay"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Hours Worked"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Employee" />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save Employee" />
        <br />
        <asp:Label ID="Label5" runat="server" ForeColor="#000099"></asp:Label>
    </form>
</body>
</html>
