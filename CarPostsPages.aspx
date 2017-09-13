<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CMasterPage.master" AutoEventWireup="true" CodeFile="CarPostsPages.aspx.cs" Inherits="Customer_CarPostsPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Adv" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table>
        <tr>
            <td width="60%">
                <div id="dis" runat="server">
       <!-- offers list -->
		
            <!--/ offers list -->







    </div>
            </td>
            <td width="40px">
                <div class="sidebar">
        	<div class="box">
            
            <!-- filter -->
	        <div class="widget-container widget_adv_filter">
				<h3 class="widget-title">ADJUST SEARCH RESULTS</h3>
					
               
                
                    <div class="row field_select" style="z-index:10">
                        <label class="label_title">Car Maker:</label>
                       <%-- <select class="select_styled white_select" name="car_maker">
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
                        <%--<select class="select_styled white_select" name="car_model">
                        	<option value="0" class="default">- SELECT -</option>
	                        <option value="1">626</option>
	                        <option value="2">323</option>
	                        <option value="3">3</option>
	                        <option value="4">5</option>
	                        <option value="5">7</option>
	                        <option value="6">СX-7</option>                                                
	                        <option value="7">MVP</option>
	                        <option value="8">RX-8</option>
	                        <option value="9">MX-3</option>
	                        <option value="10">MX-5</option>
	                        <option value="11">MX-6</option>
	                        <option value="12">BT-50</option>
	                        <option value="13">CX-9</option>                       
	                        </select>--%>
                        <asp:DropDownList ID="ddlModelno" class="select_styled white_select" AutoPostBack="true" OnSelectedIndexChanged="ddlModelno_SelectedIndexChanged" runat="server"></asp:DropDownList>
                    </div>
                    
                    <%--<div class="row field_select" style="z-index:8">
	                    <label class="label_title">Regist. from:</label>--%>
	                 <%--   <select class="select_styled white_select" name="car_year">
                        	<option value="2013">2013</option>
                            <option value="2012">2012</option>
                            <option value="2011">2011</option>
                            <option value="2010">2010</option>
                            <option value="2009">2009</option>
                            <option value="2008">2008</option>
                            <option value="2007">2007</option>
                            <option value="2006">2006</option>  
                            <option value="2005">2005</option>
                            <option value="2004">2004</option>
                            <option value="2003">2003</option>
	                    </select>--%>
                        

<%--                    </div>--%>
                    
                    <div class="row input_styled checklist">
                        <%--<label class="label_title2">Vehicle Type:</label><br>                            
                        <input type="checkbox" name="vehicle_type_1" id="vehicle_type_1" value="1"> <label for="vehicle_type_1">Compact Cars <span>(32)</span></label>
                        <input type="checkbox" name="vehicle_type_2" id="vehicle_type_2" value="2" checked> <label for="vehicle_type_2">SUVs & PickUps <span>(49)</span></label>
                        <input type="checkbox" name="vehicle_type_3" id="vehicle_type_3" value="3"> <label for="vehicle_type_3">Estate Saloons <span>(56)</span></label>
                        <input type="checkbox" name="vehicle_type_4" id="vehicle_type_4" value="4"> <label for="vehicle_type_4">Sedan Cars <span>(31)</span></label>
                        <input type="checkbox" name="vehicle_type_5" id="vehicle_type_5" value="5"> <label for="vehicle_type_5">Sports Cars <span>(23)</span></label>
                        <input type="checkbox" name="vehicle_type_6" id="vehicle_type_6" value="6"> <label for="vehicle_type_6">Van & Minibus <span>(46)</span></label>--%>
                    </div>
                    
                    <div class="row rangeField">
                        <label class="label_title2">Price Range:</label>
                        <div class="range-slider">
                            
                            <asp:TextBox ID="txtRange" placeholder="Price.." OnTextChanged="txtRange_TextChanged" runat="server"></asp:TextBox>
                        </div>                   
                        <div class="clear"></div>
                    </div>
                    
                    <div class="">
                        <label class="label_title2">Kilometers Starting:</label>
                        <div class="">
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
                        <%--<input type="checkbox" name="fuel_type_1" id="fuel_type_1" value="1"> <label for="fuel_type_1">Petrol  <span>(32)</span></label>
                        <input type="checkbox" name="fuel_type_2" id="fuel_type_2" value="2" checked> <label for="fuel_type_2">Diesel <span>(49)</span></label>
                        <input type="checkbox" name="fuel_type_3" id="fuel_type_3" value="3"> <label for="fuel_type_3">Natural Gas <span>(56)</span></label>
                        <input type="checkbox" name="fuel_type_4" id="fuel_type_4" value="4"> <label for="fuel_type_4">LPG <span>(31)</span></label>
                        <input type="checkbox" name="fuel_type_5" id="fuel_type_5" value="5"> <label for="fuel_type_5">Electric <span>(23)</span></label>
                        <input type="checkbox" name="fuel_type_6" id="fuel_type_6" value="6" checked> <label for="fuel_type_6">Hybrid <span>(46)</span></label>--%>
                        <asp:CheckBoxList ID="chkFuelType" AutoPostBack="true" OnSelectedIndexChanged="chkFuelType_SelectedIndexChanged" runat="server"></asp:CheckBoxList>

                    </div>
                    
                    <%--<div class="row input_styled checklist">
                        <label class="label_title2">Engine Size:</label><br>                            
                        <input type="checkbox" name="engine_power_1" id="engine_power_1" value="1" checked> <label for="engine_power_1">1.1 - 1.5  <span>(32)</span></label>
                        <input type="checkbox" name="engine_power_2" id="engine_power_2" value="2" checked> <label for="engine_power_2">1.6 - 2.0  <span>(49)</span></label>
                        <input type="checkbox" name="engine_power_3" id="engine_power_3" value="3"> <label for="engine_power_3">2.1 - 3.0  <span>(56)</span></label>
                        <input type="checkbox" name="engine_power_4" id="engine_power_4" value="4"> <label for="engine_power_4">3.1 - 4.0 <span>(31)</span></label>
                        <input type="checkbox" name="engine_power_5" id="engine_power_5" value="5"> <label for="engine_power_5">4.1 +   <span>(23)</span></label>
                    </div>--%>
                    
                    <div class="row input_styled checklist">
                        <label class="label_title2">Car Colour:</label><br>                            
                        <%--<input type="checkbox" name="car_color_all" id="car_color_all" value="0" checked> <label for="car_color_all">All Colours <span>(332)</span></label>
                        <input type="checkbox" name="car_color_1" id="car_color_1" value="1"> <label for="car_color_1">Silver <span>(49)</span></label>
                        <input type="checkbox" name="car_color_2" id="car_color_2" value="2"> <label for="car_color_2">Black <span>(56)</span></label>
                        <input type="checkbox" name="car_color_3" id="car_color_3" value="3"> <label for="car_color_3">Brown <span>(31)</span></label>
                        <input type="checkbox" name="car_color_4" id="car_color_4" value="4"> <label for="car_color_4">White <span>(23)</span></label>
                        <input type="checkbox" name="car_color_5" id="car_color_5" value="5"> <label for="car_color_5">Red <span>(46)</span></label>
                        <input type="checkbox" name="car_color_6" id="car_color_6" value="5"> <label for="car_color_6">Green <span>(46)</span></label>
                        <input type="checkbox" name="car_color_other" id="car_color_other" value="7"> <label for="car_color_other">Other <span>(115)</span></label>--%>
                        <asp:CheckBoxList ID="chkCarColor" class="label_title2" AutoPostBack="true" OnSelectedIndexChanged="chkCarColor_SelectedIndexChanged" runat="server"></asp:CheckBoxList>
                    </div>
                    
                    <div class="row rowSubmit">
                        <span class="btn btn_search"><input type="submit" value="SEARCH"></span>
                    </div>
                    
              
                
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
            </td>
        </tr>
    </table>
    
        <!--/ sidebar --> 

</asp:Content> 
