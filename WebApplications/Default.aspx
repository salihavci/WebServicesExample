<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplications._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" language="javascript">
        function getStudentById() {
            var id = document.getElementById("MainContent_txtStudentId").value;
            WebApplications.DatabaseWebService.GetStudentById(id, successCallback, errorCallback);
        }

        function successCallback(result) {
            document.getElementById("MainContent_txtName").value = result["Name"];
            document.getElementById("MainContent_txtGender").value = result["Gender"];
            document.getElementById("MainContent_txtTotalMarks").value = result["TotalMarks"];
        }

        function errorCallback(err) {
            alert(err.get_message());
        }

    </script>
    <table style="width: 100%;">
        <tr>
            <td>ID</td>
            <td>
                <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox>
                <input id="Button1" type="button" value="Get Student" onclick="getStudentById();" />
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Total Marks</td>
            <td>
                <asp:TextBox ID="txtTotalMarks" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
