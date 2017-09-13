<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CMasterPage.master" AutoEventWireup="true" CodeFile="Cars.aspx.cs" Inherits="Customer_Cars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Adv" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div class="header header_thin" style="background-image:url(images/temp/slider_1_1.jpg)">
            
	<div class="header_title">
    	<h1>Showing <span>RESULTS</span> for your Car search</h1>
    </div>

</div>
<!--/ header -->

<!-- breadcrumbs -->
<div class="middle_row row_white breadcrumbs">
    <div class="container">
        <p><a href="index.html">Home</a>  <span class="separator">&rsaquo;</span>  <a href="search.html">My Car Search</a>  <span class="separator">&rsaquo;</span>  <span class="current">143 Results</span></p>
        <a href="offers-search.html" class="link_search">Start a New Search</a>
    </div>
</div>
<!--/ breadcrumbs -->

<!-- middle -->   
<div id="middle" class="cols2 sidebar_left">
	<div class="container clearfix">  
		<!-- content -->
        <div class="content">
        	
            <!-- sorting, pages -->
	        <div class="list_manage">
            	<div class="inner clearfix">
                <div action="#" method="post" class="form_sort">
                    <span class="manage_title">Sort by:</span>
                        <select class="select_styled white_select" name="sort_list" id="sort_list">
                            <option value="1">Latest Added</option>
                            <option value="2" selected>Price High - Low</option>
                            <option value="3">Price Low - Hight</option>
                            <option value="4">Names A-Z</option>
                            <option value="5">Names Z-A</option>
                        </select>
                </div>    
                
                <%--<div class="pages_jump">
                    <span class="manage_title">Jump to page:</span>
                    <div action="#" method="post">
                        <input type="text" name="jumptopage" value="15" class="inputSmall"><input type="submit" class="btn-arrow" value="Go">
                    </div>
                </div>--%>
                
                <div class="pages">
                    <span class="manage_title">Page: &nbsp;<strong>1 of 25</strong></span> <a href="#" class="link_prev">Previous</a><a href="#" class="link_next">Next</a>
                </div>
                 
                </div>
	        </div>
          	<!--/ sorting, pages -->
            
            <!-- offers list -->
            <%--<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div id="dis" runat="server">--%>
			<div runat="server" class="offer_list clearfix">
                <div id="dis" runat="server"></div> 

            </div>
              <%-- </div>
</asp:Content>--%>
            <!--/ offers list -->
            
            <!-- pagination -->
            <div class="tf_pagination">
	            <div class="inner">
	            	<a class="page_prev" href="#"><span></span>PREV</a> 
                	<a class="page_next" href="#"><span></span>NEXT</a>
                
                	<span class="page-numbers page_current">1</span> <a href="#" class="page-numbers">2</a>  <a href="#" class="page-numbers">3</a> <a href="#" class="page-numbers">4</a> <a href="#" class="page-numbers">5</a> <a href="#" class="page-numbers">6</a> <a href="#" class="page-numbers">7</a> &hellip;  <a href="#" class="page-numbers">18</a>     
                      
	            </div>
            </div>
            <!--/ pagination -->
            
        </div>
        <!--/ content -->
        
        <!-- sidebar -->
        <div class="sidebar">
        	<div class="box">
            
            <!-- filter -->
	        <div class="widget-container widget_adv_filter">
				<h3 class="widget-title">ADJUST SEARCH RESULTS</h3>
					
                <div action="#" method="get" class="side_form">
                
                    <div class="row field_select" style="z-index:10">
                        <label class="label_title">Car Maker:</label>
                        <%--<select class="select_styled white_select" name="car_maker">
                        	<option value="0" class="default">- SELECT -</option>
	                        <option value="1">Alfa Romeo</option>
	                        <option value="2">Audi</option>
	                        <option value="3">BMW</option>
	                        <option value="4">Chevrolet</option>
	                        <option value="5">Ford</option>
	                        <option value="6">Honda</option>                                                
	                        <option value="7">Lexus</option>
	                        <option value="8">Mazda</option>
	                        <option value="9">Mercedes Benz</option>
	                        <option value="10">Mitsubishi</option>
	                        <option value="11">Nissan</option>
	                        <option value="12">Opel</option>
	                        <option value="13">Toyota</option>                       
	                        <option value="14">Volkswagen</option>
	                        <option value="15">Volvo</option>                        
	                    </select>--%>
                        <asp:DropDownList ID="ddlVecl" class="select_styled white_select" name="car_maker" OnSelectedIndexChanged="ddlVecl_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
                    </div>
                    
                    <div class="row field_select" style="z-index:9">
                        <label class="label_title">Model:</label>
                        <asp:DropDownList ID="ddlModelno" class="select_styled white_select" OnSelectedIndexChanged="ddlModelno_SelectedIndexChanged" AutoPostBack="true"  runat="server"></asp:DropDownList>
                    </div>
                    
                    
                    
                    
                    
                    <div class="row rangeField">
                        <label class="label_title2">Price Range:</label>
                        <div class="range-slider">
                            <asp:TextBox ID="txtRange" placeholder="Price.." runat="server"></asp:TextBox>
                        </div>                   
                        <div class="clear"></div>
                    </div>
                    
                    <div class="row rangeField">
                        <label class="label_title2">Kilometers Starting:</label>
                        <div class="range-slider">
                           <asp:DropDownList ID="ddlPrange1" CssClass="select_styled white_select" runat="server">
                                <asp:ListItem Text ="1000"></asp:ListItem>
                                <asp:ListItem Text ="2000"></asp:ListItem>
                                <asp:ListItem Text ="3000"></asp:ListItem>
                            </asp:DropDownList>
                        </div>                   
                        <div class=""></div>
                    </div>



                    <div class="row rangeField">
                        <label class="label_title2">Kilometers End Range:</label>
                        <div class="range-slider">
                            <asp:DropDownList ID="ddlPRange2" AutoPostBack="true" CssClass="select_styled white_select" runat="server">
                                <asp:ListItem Text ="10000"></asp:ListItem>
                                <asp:ListItem Text ="20000"></asp:ListItem>
                                <asp:ListItem Text ="50000"></asp:ListItem>
                            </asp:DropDownList>
                            
                        </div>                   
                        <div class="clear"></div>
                    </div>
                    
                    <div class="row input_styled checklist">
                        <label class="label_title2">Fuel Type:</label><br>                            
                        <asp:CheckBoxList ID="chkFuelType" AutoPostBack="true" OnSelectedIndexChanged="chkFuelType_SelectedIndexChanged" runat="server"></asp:CheckBoxList>
                    </div>
                    
                    
                    
                    <div class="row input_styled checklist">
                        <label class="label_title2">Car Colour:</label><br>                            
                         <asp:CheckBoxList ID="chkCarColor" class="label_title2 " OnSelectedIndexChanged="chkCarColor_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:CheckBoxList>
                    </div>
                    
                    <div class="row rowSubmit">
                        <span class="btn btn_search"><input type="submit" value="SEARCH"></span>
                    </div>
                    
                </f>    
                
                <script type="text/javascript" >
                    jQuery(document).ready(function ($) {
                        // Price Range Input
                        $("#price_range").slider({
                            from: 100,
                            to: 100000,
                            limits: false,
                            scale: ['$100', '$100k'],
                            heterogeneity: ['50/50000'],
                            step: 100,
                            smooth: true,
                            dimension: '$',
                            skin: "round_blue"
                        });
                        $("#miliage").slider({
                            from: 0,
                            to: 500000,
                            limits: false,
                            scale: ['0', '500k'],
                            heterogeneity: ['50/250000'],
                            step: 5000,
                            smooth: true,
                            skin: "round_blue"
                        });
                    });
                </script>           
			</div>
	        <!--/ filter -->
            
            <div class="box_bot"></div>
            </div>
        </div>
        <!--/ sidebar -->  
              
    </div>
</div>
<!--/ middle -->

<!-- popular brands -->
<div class="middle_row row_white brand_list">
    <div class="container">
            <h2>MOST POPULAR BRANDS:</h2>
            <ul>
                <li><a href="#"><img src="images/temp/brand_logo_1.png" alt=""></a></li>
                <li><a href="#"><img src="images/temp/brand_logo_2.png" alt=""></a></li>
                <li><a href="#"><img src="images/temp/brand_logo_3.png" alt=""></a></li>
                <li><a href="#"><img src="images/temp/brand_logo_4.png" alt=""></a></li>
                <li><a href="#"><img src="images/temp/brand_logo_5.png" alt=""></a></li>
                <li><a href="#"><img src="images/temp/brand_logo_6.png" alt=""></a></li>
                <li><a href="#"><img src="images/temp/brand_logo_7.png" alt=""></a></li>
                <li><a href="#"><img src="images/temp/brand_logo_8.png" alt=""></a></li>
            </ul>
            
            <a href="#" class="link_more">View All Popular Brands</a>
    </div>
</div>
<!--/ popular brands -->

<div class="footer">
	<div class="container clearfix">
    
		<div class="f_col f_col_1">  
            <h3>Vehicles:</h3>
            <ul>
                <li><a href="#"><span>Motorbikes</span></a></li> 
                <li><a href="#"><span>Compacts</span></a></li>
                <li><a href="#"><span>Sedans</span></a></li>
                <li><a href="#"><span>4x4 SUVs</span></a></li>
                <li><a href="#"><span>Pickups</span></a></li>
                <li><a href="#"><span>Vans & Trucks</span></a></li>                                
            </ul>
        </div>
        <!--/ footer col 1 -->
        
        <div class="f_col f_col_2">        	
			<h3>Services:</h3>
            <ul>
                <li><a href="#"><span>Buy a car</span></a></li> 
                <li><a href="#"><span>Sell your Car</span></a></li>
                <li><a href="#"><span>Buy Back</span></a></li>
                <li><a href="#"><span>Repair Shop </span></a></li>
            </ul>
        </div>
        <!--/ footer col 2 -->
        
        <div class="f_col f_col_3">        	
            <h3>Privacy:</h3>
            <ul>
                <li><a href="#"><span>Terms & Conditions</span></a></li> 
                <li><a href="#"><span>Privacy Statement</span></a></li>
                <li><a href="#"><span>F.A.Q.</span></a></li>
                <li><a href="#"><span>Support</span></a></li>
                <li><a href="#"><span>Confidentiality</span></a></li>
            </ul>
        </div>        
        <!--/ footer col 3 -->
        
        <div class="f_col f_col_4">   
           	<h3>OUR SHOWROOM</h3>
            <div class="footer_address">
                <div class="address">
	                21 Sunset Blvd, Los Angeles<br>
	                California, 90453
                </div>
                <div class="hours">
                	Mon - Fri: 9AM - 7 PM<br>
					Sat - Sun: 9AM - 2 PM
				</div>
                <a href="contact.html" class="notice">View Bigger Map</a>
            </div>
            <div class="footer_map" style="background:url(images/temp/footer_map.jpg);"><a href="contact.html" class="amap"></a></div>
      	</div>
        <!--/ footer col 4 -->
        
        <div class="clear"></div>
        
        <div class="footer_social">
        	<div class="social_inner">
			    <a href="#" class="social-google"><span>Google +1</span></a>
			    <a href="#" class="social-fb"><span>Facebook</span></a>
			    <a href="#" class="social-twitter"><span>Twitter</span></a>
			    <a href="#" class="social-dribble"><span>Dribble</span></a>
			    <a href="#" class="social-linkedin"><span>LinkedIn</span></a>
			    <a href="#" class="social-vimeo"><span>Vimeo</span></a>
			    <a href="#" class="social-flickr"><span>Flickr</span></a>
			    <a href="#" class="social-da"><span>Devianart</span></a>
            </div>
		</div>
        
        <div class="footer_contacts">
        	<span class="phone">555-39.84.35</span>
            <span class="email">hello@autotrader.com</span>
        </div>
        
        <div class="copyright">
        AutoTrader Wordpress theme by <a href="http://themefuse.com/">Themefuse</a>  &nbsp;|&nbsp;  <a href="http://themefuse.com/" class="link_white">Premium WordPress themes</a>
        </div>
        	        
    </div> 
</div>

</div>
    </div>
</asp:Content>

