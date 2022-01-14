<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="finalProject_1913864.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>finalProj</title>

    <style type="text/css">
        .auto-style1 {

            text-align: center;
        }

        .auto-style2 {

            width: 140px;
            height: 290px;
        }

        .auto-style3 {

            height: 290px;
        }

        h1 {

            font-size: 3.625rem;
            margin: 50px auto 0 auto;
            color: #000000;

        }

        .btn {

            border: solid 1px grey;
            padding: 1px 2px 1px 2px;
            border-radius: 8px;
            margin: 3px 2px;
            background-color:#ff0000;

        }

        .body {

            background-color: #808080;
            text-align: center;
           
        }

        .table-hover {}

    </style>
</head>
<body class="body">
    <h1 class="auto-style1">Saint Michel Technology Instituition</h1>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style">
                <tr>

                    <td class="auto-style2">

                        <asp:Label ID="lblName" runat="server" Text="Label"> Select a Teacher </asp:Label>
                        <br />
                        <asp:ListBox ID="lstTeacher" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstTeacher_OnSelectedIndexChanged" Width="125px" Height="89px"></asp:ListBox>

                        &nbsp;</td>

                    <td class="auto-style3">
                        <table class="auto-style4" align="center">

                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="lblEmployeeId" runat="server" Text="Employee Id:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtEmployeeId" ReadOnly="true" runat="server"></asp:TextBox>
                                </td>
                            </tr>


                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="lblCourseCode" runat="server" Text="Course Code:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCourseCode" ReadOnly="true" runat="server"></asp:TextBox>
                                </td>
                            </tr>


                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="lblGroupNumber" runat="server" Text="Group Number:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtGroupNumber" ReadOnly="true" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style8">
                                    <asp:Label ID="lblAssignedDate" runat="server" Text="Assigned Date:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAssignedDate" ReadOnly="true" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                        </table>
                    </td>

                    <td class="auto-style3">
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="btn" Height="26px" Width="168px" />
                        <br />
                        <br />
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn" Width="84px" Height="30px"/>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn" Width="97px" Height="31px"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style11">
                        <asp:GridView ID="gridresults" runat="server" BackColor="White" BorderColor="YellowGreen" BorderStyle="None"
                            BorderWidth="1px" CellPadding="5" GridLines="Vertical" CssClass="table table-condensed table-hover" Width="435px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">&nbsp;</td>

                    <td class="auto-style11">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
