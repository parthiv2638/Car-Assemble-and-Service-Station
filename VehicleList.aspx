<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AMasterPage.master" AutoEventWireup="true" CodeFile="VehicleList.aspx.cs" Inherits="Admin_VehicleList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    List Of Vehicles
</asp:Content>
<asp:Content ID="Content3" runat ="server" ContentPlaceHolderID ="btn" >
    	<a class="btn btn-sm btn-default btn-circle" href="VehicleEdit.aspx"   >
										Add New <i class="fa fa-angle-down"></i>
										</a>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div id="dis" runat="server">
    </div>
</asp:Content>

