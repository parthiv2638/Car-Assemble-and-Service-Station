<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AMasterPage.master" AutoEventWireup="true" CodeFile="OperatorEdit.aspx.cs" Inherits="Admin_OperatorEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Change Authentication
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<table class="">
        <tr>
            <td>Opearator Name</td>
            <td>
                <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        
        <tr>
            <td>Want to Authneticate?</td>
            <td>
                <asp:CheckBox ID="chkIsDisplay" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="Center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>--%>



    <!-- BEGIN PAGE CONTENT-->
    <div class="row">
        <div class="col-md-10 ">
            <!-- BEGIN SAMPLE FORM PORTLET-->
            <div class="portlet box blue">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="fa fa-gift"></i>Change Authentication
                    </div>
                    <div class="tools">
                        <a href="" class="collapse"></a>
                        <a href="#portlet-config" data-toggle="modal" class="config"></a>
                        <a href="" class="reload"></a>
                        <a href="" class="remove"></a>
                    </div>
                </div>
                <div class="portlet-body form">
                    <form role="form">
                        <br />
                        <div class="form-body">
                            <div class="form-group">
                                <label>Operator Name</label>
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <i class="fa fa-envelope"></i>
                                    </span>
                                    <asp:TextBox ID="txtUname" CssClass="form-control" runat="server"></asp:TextBox>
                                    <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                                </div>
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
                    </form>
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
</asp:Content>
