﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SecondCarPosts.aspx.cs" Inherits="Customer_SecondCarPosts" %>

<!doctype html>
<!--[if lt IE 7 ]><html lang="en" class="no-js ie6"> <![endif]-->
<!--[if IE 7 ]><html lang="en" class="no-js ie7"> <![endif]-->
<!--[if IE 8 ]><html lang="en" class="no-js ie8"> <![endif]-->
<!--[if IE 9 ]><html lang="en" class="no-js ie9"> <![endif]-->
<!--[if (gt IE 9)|!(IE)]><!--><html lang="en" class="no-js"> <!--<![endif]-->
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
<meta name="author" content="ThemeFuse">
<meta name="keywords" content="">
<meta name="viewport" content="width=device-width,initial-scale=1">
<title>AutoTrader - Homepage</title>
<link href='http://fonts.googleapis.com/css?family=Cabin:400,400italic,500,600,700|PT+Serif+Caption:400,400italic' rel='stylesheet' type='text/css'>
<link rel="shortcut icon" href="favicon.html">

<link href="style.css" media="screen" rel="stylesheet">
<link href="screen.css" media="screen" rel="stylesheet">
<!-- custom CSS -->
<link href="custom.css" media="screen" rel="stylesheet">

<!-- main JS libs  -->
<script src="js/libs/modernizr.min.js"></script>
<script src="js/libs/respond.min.js"></script>					 
<script src="js/libs/jquery.min.js"></script>

<!-- scripts  -->
<script src="js/jquery.easing.min.js"></script>
<script src="js/general.js"></script>
<script src="js/hoverIntent.js"></script>
<!-- carousel -->
<script src="js/jquery.carouFredSel.min.js"></script>
<script src="js/jquery.touchSwipe.min.js"></script>
<!-- styled select -->
<link rel="stylesheet" href="css/cusel.css">
<script src="js/cusel-min.js"></script>

<link href="rs-plugin/css/settings.css" media="screen" rel="stylesheet">
<script src="rs-plugin/js/jquery.themepunch.plugins.min.js"></script>
<script src="rs-plugin/js/jquery.themepunch.revolution.min.js"></script>

</head>

<body>
    <form id="frm1" runat="server">
<div class="body_wrap">
	
	<!-- header top bar -->
	<div class="header_top">
		<div class="container">
		
			<div class="logo">
				<a href="index.html"><img src="images/logo.png" alt=""></a>
			</div>
			
			<!-- topmenu -->    
			<nav id="topmenu" class="clearfix">            
				<ul class="dropdown">    
                	<li class="menu-level-0 current-menu-ancestor"><a href="CHome.aspx"><span>Home</span></a>
						<%--<ul class="submenu-1">
	                    	<li class="menu-level-1 current-menu-item"><a href="index.html"><span>Home Slider 1</span></a></li>
                            <li class="menu-level-1"><a href="index2.html"><span>Home Slider 2</span></a></li>
                            <li class="menu-level-1"><a href="index3.html"><span>Home Slider 3</span></a></li>
						</ul>--%>
					</li>                                                                            
					<li class="menu-level-0"><a href="Customerhome.aspx"><span>Own Cars</span></a>
                    	<%--<ul class="submenu-1">
	                    	<li class="menu-level-1"><a href="offers-search.html"><span>Search Page</span></a></li>
                            <li class="menu-level-1"><a href="offers-list.html"><span>Offers List - Filter Right</span></a></li>
                            <li class="menu-level-1"><a href="offers-list-left.html"><span>Offers List - Filter Left</span></a></li>
                            <li class="menu-level-1"><a href="car-makers.html"><span>Car Makers</span></a></li>
						</ul>--%>
                    </li>       
                    <li class="menu-level-0 mega-nav"><a href="PackagesLists.aspx"><span>SPECIAL PACKAGES</span></a>
                    <%--	<ul class="submenu-1">
							<li class="menu-level-1 mega-nav-widget">
								<!-- widget recent entries -->
								<div class="widget-container widget_recent_entries"> 
									<h3 class="widget-title">Latest News</h3>								
									<ul>
										<li class="clearfix">
											<a href="blog-details.html" class="link-name">What You Should Know No About Using a CDN With WordPress</a>
											<div class="post-meta"><span class="post-date">posted 1 days ago</span> <a href="blog-details.html#comments">3 comments</a></div>
										</li>
										<li class="clearfix">
											<a href="blog-details.html" class="link-name">Black Friday! Everything half price. K, Thanx, Bye!</a>
											<div class="post-meta"><span class="post-date">posted 2 days ago</span> <a href="blog-details.html#comments">23 comments</a></div>
										</li>
										<li class="clearfix">
											<a href="blog-details.html" class="link-name">Our first FREE WordPress theme is now available - Gadgetry</a>
											<div class="post-meta"><span class="post-date">posted 3 days ago</span> <a href="blog-details.html#comments">34 comments</a></div>
										</li>
									</ul>
								</div>
								<!--/ widget recent entries -->
							</li>
							<li class="menu-level-1 mega-nav-widget">                            	
								<!-- widget latest entries from category -->
								<div class="widget-container widget_featured_posts"> 
									<h3 class="widget-title">Fresh from our Blog</h3>
									<ul>
										<li class="post-item">
											<div class="post-title"><a href="blog-details.html">What Today's Video Games Say About The Moment We Live In</a></div>
											<div class="post-meta">written by <span class="post-author">Jenna Pratt</span></div>
											<div class="post-image"><a href="blog-details.html"><img src="images/temp/featured_thumb_1.jpg" alt=""></a></div>
											<div class="post-descr">
	                                        <p>Vivamus hendrerit arcu sed erat molestie adro vehicula. Sed auctor neque eu tellus rhoncus ut eleifend nibh porttitor. </p>
	                                        </div>
											<div class="post-more"><a href="blog-details.html">READ THE ARTICLE</a></div>
										</li>																		                    
									</ul>										
								</div>
								<!--/ widget latest entries from category -->
							</li>     
							<li class="menu-level-1 mega-nav-widget">        
								<!-- twiiter widget -->
								<div class="widget-container widget_twitter">							
									<h3 class="widget-title">Twitter Activity</h3>							
									<div class="tweet_list">											   
										<div class="tweet_item clearfix">
											<div class="tweet_image"><img src="images/temp/twitter_avatar.png" width="30" height="30" alt="" /></div>
											<div class="tweet_text">
												<div class="inner">
												Lorem ipsum dolor sit amet, consectetur adiping elit.  <a href="#">http://t.co/dwRp8eds</a>
												<span class="tweet_time">About 3 hours ago</span>
												</div>
											</div>
										</div>   
										
										<div class="tweet_item clearfix">
											<div class="tweet_image"><img src="images/temp/twitter_avatar.png" width="30" height="30" alt="" /></div>
											<div class="tweet_text">
												<div class="inner">
												Lorem ipsum dolor sit amet, consectetur adiping elit. Class aptent taciti sociosqu ad litora torquent per conubia nostr <a href="#">http://t.co/dwRp8eds</a>
												<span class="tweet_time">About 7 hours ago ago</span>
											  </div>
											</div>
										</div>								
									</div>
									<a href="#" class="link-more">FOLLOW US ON TWITTER</a>
							</div>
							<!--/ twiiter widget -->
							</li>												
						</ul>  --%>
                    </li>
	                <li class="menu-level-0 mega-nav"><a href="ServicesHistory.aspx"><span>Services</span></a>
	                	<%--<ul class="submenu-1">                      	                                                                                                  
	                        <li class="menu-level-1 mega-nav-widget">                            	
	                            <!-- widget text -->
	                            <div class="widget-container widget_text"> 
	                                <h3 class="widget-title">Welcome Text</h3>
	                                <div class="textwidget">
	                                    <p>Easily add a functional and highly customizable Mega Menu to your WordPress website. Choose your option of five different color schemes within the WordPress admin, or style it to your liking with your own stylesheet. </p>
	                                    <p>Lorem ipsum dolor sit amet, consectetur adiping elit. Class aptent taciti sociosqu ad litora torquent per conubia nostr.</p>
	                                </div>
	                            </div>
	                            <!--/ widget text -->
	                        </li>	                        
                            <li class="menu-level-1"><a href="#"><span>Vehicles</span></a>
	                            <ul class="submenu-2">                                
	                                <li class="menu-level-2"><a href="blog.html"><span>Motorbikes</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>Compacts</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>Sedans</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>4x4 SUVs</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>Pickups</span></a></li>
	                                <li class="menu-level-2 more-nav"><a href="blog.html"><span>view all</span></a></li>
	                            </ul>
							</li>
	                        <li class="menu-level-1"><a href="#"><span>Submenu</span></a>
	                            <ul class="submenu-2">                                
	                                <li class="menu-level-2"><a href="blog.html"><span>1st Blog Category</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>Second Category</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>3rd Category</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>Forth Category</span></a></li>
	                                <li class="menu-level-2"><a href="blog.html"><span>Another Category</span></a></li>
	                                <li class="menu-level-2 more-nav"><a href="blog.html"><span>view all</span></a></li>
	                            </ul>
							</li>                        	                                                                    
	                    </ul>--%>
	                </li>
                    <li class="menu-level-0"><a href="#"><span>Pages</span></a>
						<ul class="submenu-1">
                        	<li class="menu-level-1"><a href="blog.html"><span>Blog</span></a></li>							
							<li class="menu-level-1"><a href="page-about.html"><span>About Page</span></a></li>
							<li class="menu-level-1"><a href="page-faq.html"><span>FAQ</span></a></li>
                            <li class="menu-level-1"><a href="SecondCarPosts.aspx"><span>Second Hand Cars</span></a></li>
                            <li class="menu-level-1"><a href="#"><span>Shortcodes</span></a>
								<ul class="submenu-2">                        		
									<li class="menu-level-2"><a href="shortcodes-buttons.html"><span>Buttons & Lists</span></a></li> 
									<li class="menu-level-2"><a href="shortcodes-text.html"><span>Text & Images</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-charts.html"><span>Charts</span></a></li>  
									<li class="menu-level-2"><a href="shortcodes-columns.html"><span>Columns</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-columns-full.html"><span>Columns full width</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-lightbox.html"><span>Lightbox</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-media.html"><span>Videos & Galleries</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-maps.html"><span>Google Maps</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-tabs.html"><span>Tabs & Toggles</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-tables.html"><span>Boxes & Tables</span></a></li>                            
									<li class="menu-level-2"><a href="shortcodes-typography.html"><span>Typography</span></a></li>
									<li class="menu-level-2"><a href="shortcodes-widgets.html"><span>Custom Widgets</span></a></li>
								</ul>   
							</li>
							<li class="menu-level-1"><a href="CProfile.aspx"><span>Profile</span></a></li>
							<li class="menu-level-1"><a href="CLogout.aspx"><span>log Out</span></a></li>
						</ul>
					</li> 
					<li class="menu-level-0"><a href="contact.html"><span>Location</span></a></li>                                
				</ul>   
			</nav>    
		<!--/ topmenu -->
		</div>
	</div>
	<!--/ header top bar -->
		
<!-- header -->
<div class="header header_thin" style="background-image:url(images/temp/slider_1_1.jpg)">
            
	<div class="header_title">
    	<h1>Showing <span>RESULTS</span> for your Car search</h1>
    </div>

</div>
<!--/ header -->

<!-- breadcrumbs -->
<div class="middle_row row_white breadcrumbs">
    <div class="container">
        <p><a href="index.html">Home</a>  <span class="separator">&rsaquo;</span>  <a href="search.html">My Car Search</a></p>
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
            

                  <%
                    DataClassesDataContext dc1 = new DataClassesDataContext();
                    var data = (from t in dc1.CarPosts
                    join tv in dc1.Vehicles on t.Vid equals tv.Vid
                    // join tvn in dc.VehicleNumbers on t.Vnumberid equals tvn.Vnumberid
                    //where t.Userid.Equals(Session["Userid"])
                    select new
                    {
                        t.Carid,
                        t.CarImg,
                        t.CarDesp,
                        t.Price,
                        t.KM,
                        t.DOP,
                        t.IsDr,
                        t.IsNegotiable,
                        t.ModelNo,
                        t.Year,
                        t.IsFirstOwner,
                        t.WithPolicy,
                        tv.Vid,
                        tv.Vname,
                        tv.Vimg,
                    }).ToList();
                                        string str1 = "";
                                        foreach (var item in data)
                                        {
                                            str1 += "<div class='offer_item clearfix'><div class='offer_image'><a href='offers-details.html'><img src='../Images/" + item.CarImg + "'   alt=''></a></div><div class='offer_aside'><h2><a href='offers-details.html'> " + item.Vname + "</a></h2><div class='offer_descr'><p>Off-road Vehicle/Pickup Truck, Used vehicle, Automatic transmission, Diesel, 190 kW (258 PS), Fuel consumption combined: 6.8 l/100 km</p></div><div class='offer_data'><div class='offer_price>" + item.Price + "</div><span class='offer_miliage'>55,689 KM</span><span class='offer_regist'>" + item.DOP + "</span></div></div></div></div>";
                                        }
                                        Response.Write(str1);
                                    %>
                 
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
                        <asp:DropDownList ID="ddlVecl" class="select_styled white_select" name="car_maker" AutoPostBack="true" runat="server"></asp:DropDownList>
                    </div>
                    
                    <div class="row field_select" style="z-index:9">
                        <label class="label_title">Model:</label>
                        <asp:DropDownList ID="ddlModelno" class="select_styled white_select" AutoPostBack="true" OnSelectedIndexChanged="ddlModelno_SelectedIndexChanged" runat="server"></asp:DropDownList>
                    </div>
                    
                    
                    
                    
                    
                    <div class="row rangeField">
                        <label class="label_title2">Price Range:</label>
                        <div class="range-slider">
                            <asp:TextBox ID="txtRange" placeholder="Price.." OnTextChanged="txtRange_TextChanged" runat="server"></asp:TextBox>
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
                            <asp:DropDownList ID="ddlPRange2" AutoPostBack="true" CssClass="select_styled white_select" runat="server" OnSelectedIndexChanged="ddlPRange2_SelectedIndexChanged">
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
                         <asp:CheckBoxList ID="chkCarColor" class="label_title2" AutoPostBack="true" OnSelectedIndexChanged="chkCarColor_SelectedIndexChanged" runat="server"></asp:CheckBoxList>
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
        </form>
</body>
</html>