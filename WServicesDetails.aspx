<%@ Page Title="" Language="C#" MasterPageFile="~/Workers/WMasterPage.master" AutoEventWireup="true" CodeFile="WServicesDetails.aspx.cs" Inherits="Workers_WServicesDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">  
          <div id="DisProduct" runat ="server" ></div>
    <table>
        <tr>
            <td colspan="2" align="Center">
                <asp:Button ID="btnSubmit" runat="server" Text="Complete All Tasks" CssClass="btn" OnClick="btnSubmit_Click"/>
            </td>
        </tr>
    </table>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="btn" Runat="Server">
</asp:Content>


