<%@ Page Title="" Language="C#" MasterPageFile="~/Workers/WMasterPage.master" AutoEventWireup="true" CodeFile="WProfile.aspx.cs" Inherits="Workers_WProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Profile
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td>First Name:-</td>
            <td>
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Last Name:</td>
            <td>
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Contact No</td>
            <td>
                <asp:TextBox ID="txtCntn" runat="server"></asp:TextBox>
            </td>
        </tr>




        <tr>
            <td>Postal Code</td>
            <td>
                <asp:TextBox ID="txtPcode" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Email Id</td>
            <td>
                <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Date of Birth</td>
            <td>
                <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td>Image</td>
            <td>
                <asp:Image ID="Userimg" runat="server" />
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>


        <tr>
            <td>Area</td>
            <td>
                <asp:TextBox ID="txtArea" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td></td>
            <td></td>
        </tr>




        <tr>
            <td colspan="2" align="Center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn"/>
            </td>
        </tr>
    </table>
</asp:Content>
