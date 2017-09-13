<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AMasterPage.master" AutoEventWireup="true" CodeFile="PackageTypeEdit.aspx.cs" Inherits="Admin_PackageTypeEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Add / Modify Package
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<table class="">
        <tr>
            <td>Package Name</td>
            <td>
                <asp:TextBox ID="txtPackname" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Package Amount</td>
            <td>
                <asp:TextBox ID="txtPackamt" runat="server"></asp:TextBox>
            </td>
        </tr>--%>

        <%--<tr>
            <td>Package Image</td>
            <td>
                <asp:FileUpload ID="FuImage" runat="server" />
                <asp:Image ID="Image1" runat="server" />
                <asp:HiddenField ID="HiddenField1" runat="server" />
            </td>
        </tr>



        <tr>
            <td>Package Des1</td>
            <td>
                <asp:TextBox ID="txtPackDes1" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Package Des2</td>
            <td>
                <asp:TextBox ID="txtPackDes2" runat="server"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td>Package Des3</td>
            <td>
                <asp:TextBox ID="txtPackDes3" runat="server"></asp:TextBox>
            </td>
        </tr>




        <tr>
            <td>Package Des4</td>
            <td>
                <asp:TextBox ID="txtPackDes4" runat="server"></asp:TextBox>
            </td>
        </tr>




        <tr>
            <td>Pack Best For</td>
            <td>
                <asp:TextBox ID="txtPackBest" runat="server"></asp:TextBox>
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
        </tr>
    </table>
</asp:Content>--%>



 <!-- BEGIN PAGE CONTENT-->
    <div class="row">
        <div class="col-md-10 ">
            <!-- BEGIN SAMPLE FORM PORTLET-->
            <div class="portlet box blue">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="fa fa-gift"></i>Package Form
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
                                <label>Package Name</label>
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <i class="fa fa-envelope"></i>
                                    </span>
                                    <asp:TextBox ID="txtPackname"  CssClass="form-control" runat="server"></asp:TextBox>
                                    <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                                </div>
                            </div>
                            <br />

                            

                            <div class="form-group">
                            <label>Package Amount</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtPackamt" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                             <div class="form-group">
                            <label>Package Des1</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtPackDes1" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>





                             <div class="form-group">
                            <label>Package Des2</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtPackDes2" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>




                            <div class="form-group">
                            <label>Package Des3</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtPackDes3" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>







                            <div class="form-group">
                            <label>Package Des4</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtPackDes4" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>





                            <div class="form-group">
                            <label>Package Best For</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtPackBest" CssClass="form-control" runat="server"></asp:TextBox>
                                <%--<input type="text" class="form-control" placeholder="Email Address">--%>
                            </div>
                        </div>





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


