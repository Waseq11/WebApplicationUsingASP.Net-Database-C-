<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="finalProject_1913864.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>
    <style type="text/css">

        .allignment {

            margin: 150px 70px 150px 70px;
            text-align: center;
        }

        h1 {

            font-size: 3.625rem;
            margin: 50px auto 0 auto;
            color: #000000
        }

        .body {

            background-color: #00ff21;
            text-align: center;
        }


        .button {

            background: #11cdd4;
            border-radius: 8px;
            color: #ffffff;
            font-size: 20px;
            padding: 10px 20px 10px 20px;
            margin: 10px auto 10px

        }

        .table{
            margin: 0 auto 0 auto;
        }

        .btn {}

    </style>
</head>
<body class="body">
    <h1>Saint Michel Technology - Log in</h1>
    <form id="form1" runat="server">
        <div class ="allignment">
            <table class="table">
                <tr>
                    <td>
                        <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server" Height="35px" Width="191px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Height="36px" Width="192px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn" OnClick="btnLogin_Click" Width="273px" Height="50px" />
        </div>
    </form>
</body>
</html>
