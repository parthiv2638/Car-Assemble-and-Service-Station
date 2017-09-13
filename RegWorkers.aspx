<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AMasterPage.master" AutoEventWireup="true" CodeFile="RegWorkers.aspx.cs" Inherits="Admin_RegWorkers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Worker Registration
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<table>
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
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
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
                <asp:FileUpload ID="FuImage" runat="server" />
            </td>
        </tr>


        <tr>
            <td>Area</td>
            <td>
                <asp:DropDownList ID="ddlArea" runat="server"></asp:DropDownList>
            </td>
        </tr>




        <tr>
            <td colspan="2" align="Center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>--%>




     <div class="row">
        <div class="col-md-12 ">
            <!-- BEGIN SAMPLE FORM PORTLET-->
            <div class="portlet box blue">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="fa fa-gift"></i>Worker Registration Form
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



                        <div class="form-group">
                            <label>First Name</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtFname" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                        <div class="form-group">
                            <label>Last Name</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtLname" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>





                        <div class="form-group">
                            <label>Address</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtAddress" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                         <div class="form-group">
                            <label>Contact No</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtCntn" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                        <div class="form-group">
                            <label>Postal Code</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtPcode" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                        <div class="form-group">
                            <label>User Name</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtUname" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                        <div class="form-group">
                            <label>Password</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtPwd" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>





                        <div class="form-group">
                            <label>Email Id</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtEmailId"  CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                        
                        <div class="form-group">
                            <label>Date Of Birth</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class=""></i>
                                </span>
                                <asp:TextBox ID="txtDOB"  CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>



                        <div class="form-group">
                                <label for="exampleInputFile1">Image</label>
                                <asp:FileUpload ID="FuImage" runat="server" />
                                <asp:Image ID="Image1" runat="server" />
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                                <%-- <p class="help-block">
                                    some help text here.
                                </p>--%>
                            </div>
                        




                        <div class="form-group">
                            <label>Area</label>
                            <asp:DropDownList ID="ddlArea" class="form-control" runat="server">
                            </asp:DropDownList>
                        </div>



                        <div class="form-actions">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn green" OnClick="btnSubmit_Click" />
                            <%--<button type="submit" class="btn blue">Submit</button>--%>
                            <button type="button" class="btn default">Clear</button>
                        </div>
                </div>
            </form>
        </div>
    </div>
    <!-- END SAMPLE FORM PORTLET-->
</asp:Content>