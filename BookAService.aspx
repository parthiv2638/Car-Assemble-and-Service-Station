<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CMasterPage.master" AutoEventWireup="true" CodeFile="BookAService.aspx.cs" Inherits="Customer_BookAService" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Book Appointment
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table table-bordered table-condensed table-hover ">
        <tr>
            <td>Vehicle</td>
            <td>
                <asp:DropDownList ID="ddlVehl" class="cusel select_styled white_select  cuselScrollArrows" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Date</td>
            <td>
                <asp:TextBox ID="txtDate" Placeholder="Enter Date Here Like YYYY-MM-DD"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Description</td>
            <td>
                <asp:TextBox ID="txtDesc" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>

        <asp:Label ID="lblMsg"  runat="server"></asp:Label>


        <tr>
            <td colspan="2" align="Center">
                <asp:Button class="" ID="btnSubmit" runat="server"  Text="Book Appointment" BackColor="#F25A23" CssClass="btn btn_orange" OnClick="btnSubmit_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
