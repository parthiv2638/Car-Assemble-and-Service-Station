<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AMasterPage.master" AutoEventWireup="true" CodeFile="AProfile.aspx.cs" Inherits="Admin_AProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <h3 class="page-title">User Account
    </h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div runat="server" id="dis">
        <!-- BEGIN PAGE CONTENT-->
        <div class="row">
            <div class="col-md-12">

                <!-- BEGIN PROFILE CONTENT -->
                <div class="profile-content">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="portlet light">
                                <div class="portlet-title tabbable-line">
                                    <div class="caption caption-md">
                                        <i class="icon-globe theme-font hide"></i>
                                        <span class="caption-subject font-blue-madison bold uppercase">Profile Account</span>
                                    </div>
                                    <ul class="nav nav-tabs">
                                        <li class="active">
                                            <a href="#tab_1_1" data-toggle="tab">Personal Info</a>
                                        </li>
                                        <li>
                                            <a href="#tab_1_2" data-toggle="tab">Change Avatar</a>
                                        </li>
                                        <li>
                                            <a href="#tab_1_3" data-toggle="tab">Change Password</a>
                                        </li>
                                        <li>
                                            <a href="#tab_1_4" data-toggle="tab">Privacy Settings</a>
                                        </li>
                                    </ul>
                                </div>
                                <div class="portlet-body">
                                    <div class="tab-content">
                                        <!-- PERSONAL INFO TAB -->
                                        <div class="tab-pane active" id="tab_1_1">
                                            <div role="form" action="#">
                                                <div class="form-group">
                                                    <label class="control-label">First Name</label>
                                                    <asp:TextBox ID="txtFname" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">Last Name</label>
                                                    <asp:TextBox ID="txtLname" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">Mobile Number</label>
                                                    <asp:TextBox ID="txtCntn" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">Address</label>

                                                    <asp:TextBox ID="txtAddress" Rows="3" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">Postal Code</label>
                                                    <asp:TextBox ID="txtPcode" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">Date Of Birth</label>
                                                    <asp:TextBox ID="txtDOB" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">Registered Email</label>
                                                    <asp:TextBox ID="txtEmailId" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="margiv-top-10">
                                                    <a href="#" class="btn green-haze">Save Changes </a>
                                                    <a href="#" class="btn default">Cancel </a>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- END PERSONAL INFO TAB -->
                                        <!-- CHANGE AVATAR TAB -->
                                        <div class="tab-pane" id="tab_1_2">


                                            <div class="form-group">
                                                <div class="fileinput fileinput-new" data-provides="fileinput">
                                                    <div class="" style="width: 200px; height: 150px;">

                                                        <asp:Image ID="Image1" CssClass="fileinput-new thumbnail" runat="server" />
                                                        <asp:HiddenField ID="HiddenField1" runat="server" />
                                                    </div>
                                                    <div class="fileinput-preview fileinput-exists thumbnail" style="max-width: 200px; max-height: 150px;">
                                                    </div>
                                                    <div>
                                                        <span class="btn default btn-file">
                                                            <span class="fileinput-new">Select image </span>

                                                            <input type="file" name="...">
                                                        </span>
                                                        <a href="#" class="btn default fileinput-exists" data-dismiss="fileinput">Remove </a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="margin-top-10">
                                                <a href="#" class="btn green-haze">Submit </a>
                                                <a href="#" class="btn default">Cancel </a>
                                            </div>

                                        </div>
                                        <!-- END CHANGE AVATAR TAB -->
                                        <!-- CHANGE PASSWORD TAB -->
                                        <div class="tab-pane" id="tab_1_3">
                                            <div action="#" runat="server">
                                                <div class="form-group">
                                                    <label class="control-label">Current Password</label>
                                                    <asp:TextBox ID="txtOldPwd" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">New Password</label>
                                                    <asp:TextBox ID="txtNewPwd" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label class="control-label">Re-type New Password</label>
                                                    <asp:TextBox ID="txtReNewPwd" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="margin-top-10">
                                                    <asp:Button ID="btnChngPwd" class="btn green-haze" runat="server" Text="Change Password" OnClick="btnChngPwd_Click" />

                                                    <a href="#" class="btn default">Cancel </a>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- END CHANGE PASSWORD TAB -->
                                        <!-- PRIVACY SETTINGS TAB -->
                                        <div class="tab-pane" id="tab_1_4">
                                            <div action="#">
                                                <table class="table table-light table-hover">
                                                    <tr>
                                                        <td>Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus..
                                                        </td>
                                                        <td>
                                                            <label class="uniform-inline">
                                                                <input type="radio" name="optionsRadios1" value="option1" />
                                                                Yes
                                                            </label>
                                                            <label class="uniform-inline">
                                                                <input type="radio" name="optionsRadios1" value="option2" checked />
                                                                No
                                                            </label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Enim eiusmod high life accusamus terry richardson ad squid wolf moon
                                                        </td>
                                                        <td>
                                                            <label class="uniform-inline">
                                                                <input type="checkbox" value="" />
                                                                Yes
                                                            </label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Enim eiusmod high life accusamus terry richardson ad squid wolf moon
                                                        </td>
                                                        <td>
                                                            <label class="uniform-inline">
                                                                <input type="checkbox" value="" />
                                                                Yes
                                                            </label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Enim eiusmod high life accusamus terry richardson ad squid wolf moon
                                                        </td>
                                                        <td>
                                                            <label class="uniform-inline">
                                                                <input type="checkbox" value="" />
                                                                Yes
                                                            </label>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <!--end profile-settings-->
                                                <div class="margin-top-10">
                                                    <a href="#" class="btn green-haze">Save Changes </a>
                                                    <a href="#" class="btn default">Cancel </a>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- END PRIVACY SETTINGS TAB -->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- END PROFILE CONTENT -->
            </div>
        </div>
        <!-- END PAGE CONTENT-->
    </div>
</asp:Content>
