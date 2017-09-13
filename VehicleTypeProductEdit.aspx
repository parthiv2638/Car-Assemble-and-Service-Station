<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AMasterPage.master" AutoEventWireup="true" CodeFile="VehicleTypeProductEdit.aspx.cs" Inherits="Admin_VehicleTypeProductEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Add / Modify Vehicle Type Product
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<table class="nav-justified">
        <tr>
            <td>Product</td>
            <td>
                <asp:DropDownList ID="ddlPro" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Vehicle</td>
            <td>
                <asp:DropDownList ID="ddlVecl" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Price</td>
            <td>
                <asp:TextBox ID="txtVTPPrc" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click2"/>
            </td>
        </tr>
    </table>


          <br />
                <div class="form-group">
                    <label>Vehicle</label>
                    <asp:DropDownList ID="ddlVecl" class="form-control" runat="server">
                    </asp:DropDownList>
                </div>



                <div class="form-group">
                    <label>Product</label>
                    <asp:DropDownList ID="ddlPro" class="form-control" runat="server">
                    </asp:DropDownList>
                </div>


    --%>
    <div class="row">
        <div class="col-md-10 ">
            <!-- BEGIN SAMPLE FORM PORTLET-->
            <div class="portlet box blue">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="fa fa-gift"></i>Vehicle Type Product Form
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
                            <label>Vehicle</label>
                            <asp:DropDownList ID="ddlVecl" class="form-control" runat="server">
                            </asp:DropDownList>
                        </div>



                        <div class="form-group">
                            <label>Product</label>
                            <asp:DropDownList ID="ddlPro" class="form-control" runat="server">
                            </asp:DropDownList>
                        </div>




                        <div class="form-group">
                            <label>Price</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fa fa-envelope"></i>
                                </span>
                                <asp:TextBox ID="txtVTPPrc" CssClass="form-control" runat="server"></asp:TextBox>
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
                        <div class="form-actions">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn green" OnClick="btnSubmit_Click2" />
                            <%--<button type="submit" class="btn blue">Submit</button>--%>
                            <button type="button" class="btn default">Clear</button>
                        </div>
                </div>
            </form>
        </div>
    </div>
    <!-- END SAMPLE FORM PORTLET-->
</asp:Content>
