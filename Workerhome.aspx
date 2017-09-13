<%@ Page Title="" Language="C#" MasterPageFile="~/Workers/WMasterPage.master" AutoEventWireup="true" CodeFile="Workerhome.aspx.cs" Inherits="Workers_Workerhome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="c-block" id="carousel">
        <%--<h3 class="block-title">Home Page</h3>
        <p>Welcome to Assets Management System</p>--%>
        <div id="carousel-example-generic" class="carousel slide">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-generic" data-slide-to="1" class=""></li>
                <li data-target="#carousel-example-generic" data-slide-to="2" class=""></li>
                <li data-target="#carousel-example-generic" data-slide-to="3" class=""></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <img src="../Images/slider_1_4.jpg" alt="Slide-1">
                    <div class="carousel-caption">
                        <h3>Welcome to Car Assemble & Service Station</h3>
                        <p>We are happy to serve you</p>
                    </div>
                </div>
                <div class="item">
                    <img src="../Images/baner_big_2.jpg" alt="Slide-2">
                    <div class="carousel-caption">
                        <h3>Welcome to Car Assemble & Service Station</h3>
                        <p>We are happy to with you</p>
                    </div>
                </div>
                <div class="item">
                    <img src="../Images/baner_big_3.jpg" alt="Slide-3">
                    <div class="carousel-caption">
                        <h3>Welcome to Car Assemble & Service Station</h3>
                        <p>We are happy to with you</p>
                    </div>
                </div>
                <div class="item">
                    <img src="../Image/cover.jpg" alt="Slide-4">
                    <div class="carousel-caption">
                        <h3>Welcome to Assets Management System</h3>
                        <p>We are happy to with you</p>
                    </div>
                </div>
            </div>

            <!-- Controls -->
            <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                <span class="icon-prev"></span>
            </a>
            <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                <span class="icon-next"></span>
            </a>
        </div>
    </div>
</asp:Content>


