<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AMasterPage.master" AutoEventWireup="true" CodeFile="VehicleEdit.aspx.cs" Inherits="Admin_VehicleEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Add / Modify Vehicle
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<table class="">
        <tr>
            <td>Vehicle Name</td>
            <td>
                <asp:TextBox ID="txtVname" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>Vehicle Image</td>
            <td>
                <asp:FileUpload ID="FuImage" runat="server" />
                <asp:Image ID="Image1" runat="server" />
                <asp:HiddenField ID="HiddenField1" runat="server" />
            </td>
        </tr>
        
        <tr>
            <td>Want to Display?</td>
            <td>
                <asp:CheckBox ID="chkIsDisplay" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="Center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click" />
            </td>
        </tr>--%>




    <!-- BEGIN PAGE CONTENT-->
    <div class="row">
        <div class="col-md-10 ">
            <!-- BEGIN SAMPLE FORM PORTLET-->
            <div class="portlet box blue">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="fa fa-gift"></i>Vehicle Form
                    </div>
                    <div class="tools">
                        <a href="" class="collapse"></a>
                        <a href="#portlet-config" data-toggle="modal" class="config"></a>
                        <a href="" class="reload"></a>
                        <a href="" class="remove"></a>
                    </div>
                </div>
                <div class="portlet-body form">
                   
                        <br />
                        <div class="form-body" style="padding-left :30px;">
                            <div class="form-group">
                                <label>Vehicle Name</label>
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <i class="fa fa-envelope"></i>
                                    </span>
                                    <asp:TextBox ID="txtVname" CssClass="form-control" runat="server"></asp:TextBox>
                                    <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                                </div>
                            </div>
                            <br />

                            <div class="form-group">
                                <label for="exampleInputFile1">Vehicle Image</label>
                                <asp:FileUpload ID="FuImage" runat="server" />
                                <asp:Image ID="Image1" runat="server" />
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                                <%-- <p class="help-block">
                                    some help text here.
                                </p>--%>
                            </div>
                            <br />

                            <div class="form-group">
                                <label>Want to Display</label>
                                <div class="checkbox-list">
                                    <label>
                                        <asp:CheckBox ID="chkIsDisplay" runat="server" />
                                    </label>
                                </div>
                            </div>
                        </div>
                        <div class="form-actions">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn green" OnClick="btnSubmit_Click" />
                            <%--<button type="submit" class="btn blue">Submit</button>--%>
                            <button type="button" class="btn default">Clear</button>
                        </div>
            
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
</asp:Content>

