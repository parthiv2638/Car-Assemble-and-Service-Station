﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CMasterPage.master" AutoEventWireup="true" CodeFile="CHome.aspx.cs" Inherits="Customer_CHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Adv" Runat="Server">
    <div class="header" style="background:#000">
            
    <!-- header slider -->
    <div class="fullwidthbanner-container"> 
		<div class="fullwidthbanner">
        	<ul>
				<li data-transition="fade" data-slotamount="1" data-masterspeed="500">
					<img src="images/temp/slider_1_1.jpg" data-fullwidthcentering="on">
                    
                    <div class="caption sft text_line" data-x="10" data-y="190" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
                    <div class="caption sfb text_line" data-x="10" data-y="300" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
					<div class="caption sfl white_text big_title" data-x="10" data-y="220" data-speed="900" data-start="500" data-easing="easeOutExpo">
                         <a href="#"><strong>LUXURY CARS</strong></a>
                    </div>
                    <div class="caption sfr white_text subtitle" data-x="10" data-y="257" data-speed="900" data-start="700" data-easing="easeOutExpo">
                         Second-hand classics from <span>$25.990</span>
                    </div>
                    
				</li>
                <li data-transition="fade" data-slotamount="7" data-masterspeed="500">
					<img src="images/temp/slider_1_2.jpg" data-fullwidthcentering="on">
                    
                    <div class="caption sft text_line" data-x="550" data-y="250" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
                    <div class="caption sfb text_line" data-x="550" data-y="360" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
                    
					<div class="caption sft white_text big_title" data-x="550" data-y="280" data-speed="900" data-start="500" data-easing="easeOutExpo">
                         <a href="#"><strong>NEW & 2nd HAND</strong></a>
                    </div>
                    <div class="caption sfb white_text subtitle" data-x="550" data-y="317" data-speed="900" data-start="700" data-easing="easeOutExpo">
                         More than <span>3500</span> vehicles in our offer
                    </div>
				</li>
                <li data-transition="fade" data-slotamount="7" data-masterspeed="500">
					<img src="images/temp/slider_1_3.jpg" data-fullwidthcentering="on">
                    
                    <div class="caption sft text_line" data-x="10" data-y="190" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
                    <div class="caption sfb text_line" data-x="10" data-y="300" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
                    
					<div class="caption sfr white_text big_title" data-x="10" data-y="220" data-speed="900" data-start="500" data-easing="easeOutExpo">
                         <a href="#"><strong>QUALITY OF SERVICE</strong></a>
                    </div>
                    <div class="caption sfl white_text subtitle" data-x="10" data-y="257" data-speed="900" data-start="700" data-easing="easeOutExpo">
                        We guarantee <span>BEST PRICES</span> for second-hand cars
                    </div>
				</li>
                <li data-transition="fade" data-slotamount="7" data-masterspeed="500">
					<img src="images/temp/slider_1_4.jpg" data-fullwidthcentering="on">
                    
                    <div class="caption sft text_line" data-x="10" data-y="190" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
                    <div class="caption sfb text_line" data-x="10" data-y="300" data-speed="900" data-start="800" data-easing="easeOutExpo"></div>
                    
					<div class="caption sft black_text big_title" data-x="10" data-y="220" data-speed="900" data-start="500" data-easing="easeOutExpo">
                         <a href="#"><strong>SUPER SPORTS</strong></a>
                    </div>
                    <div class="caption sfb black_text subtitle" data-x="10" data-y="257" data-speed="900" data-start="700" data-easing="easeOutExpo">
                       Only the finest breed of <span>Supercars</span>
                    </div>
				</li>
            </ul>
        </div>          
	</div>
    
    <script>


        jQuery(document).ready(function ($) {

            if ($.fn.cssOriginal != undefined)
                $.fn.css = $.fn.cssOriginal;

            $('.fullwidthbanner').revolution({
                delay: 5000,
                startwidth: 950,
                startheight: 617,

                onHoverStop: "off",						// Stop Banner Timet at Hover on Slide on/off
                hideThumbs: 0,
                navigationType: "bullet",				// bullet, thumb, none
                navigationArrows: "none",				// nexttobullets, solo (old name verticalcentered), none

                navigationStyle: "round",				// round,square,navbar,round-old,square-old,navbar-old, or any from the list in the docu (choose between 50+ different item), custom

                navigationHAlign: "center",				// Vertical Align top,center,bottom
                navigationVAlign: "bottom",				// Horizontal Align left,center,right
                navigationHOffset: 0,
                navigationVOffset: 23,

                touchenabled: "on",						// Enable Swipe Function : on/off

                stopAtSlide: -1,							// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
                stopAfterLoops: -1,						// Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic

                hideCaptionAtLimit: 0,					// It Defines if a caption should be shown under a Screen Resolution ( Basod on The Width of Browser)
                hideAllCaptionAtLilmit: 0,				// Hide all The Captions if Width of Browser is less then this value
                hideSliderAtLimit: 0,					// Hide the whole slider, and stop also functions if Width of Browser is less than this value

                fullWidth: "on",
                shadow: 0								//0 = no Shadow, 1,2,3 = 3 Different Art of Shadows -  (No Shadow in Fullwidth Version !)

            });
        });
	</script>
    <!--/ header slider -->

</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
<%--    zdsfsdfsdf--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%--  sdfsd--%>
</asp:Content>

