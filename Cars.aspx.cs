using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Cars : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var datav = (from t in dc.Vehicles select t).ToList();
            ddlVecl.DataSource = datav;
            ddlVecl.DataTextField = "Vname";
            ddlVecl.DataValueField = "Vid";
            ddlVecl.DataBind();



            var datano = (from t in dc.CarPosts select t).ToList();
            ddlModelno.DataSource = datano;
            ddlModelno.DataTextField = "ModelNo";
            ddlModelno.DataValueField = "Carid";
            ddlModelno.DataBind();




            var dataf = (from t in dc.CarPosts select t).ToList();
            chkFuelType.DataSource = dataf;
            chkFuelType.DataTextField = "FuelType";
            chkFuelType.DataValueField = "Carid";
            chkFuelType.DataBind();



            var dataprc = (from t in dc.CarPosts select t).ToList();
            chkCarColor.DataSource = dataf;
            chkCarColor.DataTextField = "CarColor";
            chkCarColor.DataValueField = "Carid";
            chkCarColor.DataBind();




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
            dis.InnerHtml = str1;
        }
    }
    protected void chkCarColor_SelectedIndexChanged(object sender, EventArgs e)
    {
        var data = (from t in dc.CarPosts
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    where t.Carid.Equals(chkCarColor.SelectedValue)
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
        string str = "<div class='offer_list clearfix'>";
        foreach (var item in data)
        {
            str += "<div class='offer_item clearfix'><div class='offer_image'><a href='offers-details.html'><img src='../Images/" + item.CarImg + "'   alt=''></a></div><div class='offer_aside'><h2><a href='offers-details.html'> " + item.Vname + "</a></h2><div class='offer_descr'><p>Off-road Vehicle/Pickup Truck, Used vehicle, Automatic transmission, Diesel, 190 kW (258 PS), Fuel consumption combined: 6.8 l/100 km</p></div><div class='offer_data'><div class='offer_price>" + item.Price + "</div><span class='offer_miliage'>55,689 KM</span><span class='offer_regist'>" + item.DOP + "</span></div></div></div></div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
    protected void chkFuelType_SelectedIndexChanged(object sender, EventArgs e)
    {
        var data = (from t in dc.CarPosts
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    where t.Carid.Equals(chkFuelType.SelectedValue)
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
        string str = "<div class='offer_list clearfix'>";
        foreach (var item in data)
        {
            str += "<div class='offer_item clearfix'><div class='offer_image'><a href='offers-details.html'><img src='../Images/" + item.CarImg + "'   alt=''></a></div><div class='offer_aside'><h2><a href='offers-details.html'> " + item.Vname + "</a></h2><div class='offer_descr'><p>Off-road Vehicle/Pickup Truck, Used vehicle, Automatic transmission, Diesel, 190 kW (258 PS), Fuel consumption combined: 6.8 l/100 km</p></div><div class='offer_data'><div class='offer_price>" + item.Price + "</div><span class='offer_miliage'>55,689 KM</span><span class='offer_regist'>" + item.DOP + "</span></div></div></div></div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
    protected void ddlVecl_SelectedIndexChanged(object sender, EventArgs e)
    {
        var data = (from t in dc.CarPosts
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    where t.Carid.Equals(ddlVecl.SelectedValue)
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
        string str = "<div class='offer_list clearfix'>";
        foreach (var item in data)
        {
            str += "<div class='offer_item clearfix'><div class='offer_image'><a href='offers-details.html'><img src='../Images/" + item.CarImg + "'   alt=''></a></div><div class='offer_aside'><h2><a href='offers-details.html'> " + item.Vname + "</a></h2><div class='offer_descr'><p>Off-road Vehicle/Pickup Truck, Used vehicle, Automatic transmission, Diesel, 190 kW (258 PS), Fuel consumption combined: 6.8 l/100 km</p></div><div class='offer_data'><div class='offer_price>" + item.Price + "</div><span class='offer_miliage'>55,689 KM</span><span class='offer_regist'>" + item.DOP + "</span></div></div></div></div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
    protected void ddlModelno_SelectedIndexChanged(object sender, EventArgs e)
    {
        var data = (from t in dc.CarPosts
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    where t.Carid.Equals(ddlModelno.SelectedValue)
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
        string str = "<div class='offer_list clearfix'>";
        foreach (var item in data)
        {
            str += "<div class='offer_item clearfix'><div class='offer_image'><a href='offers-details.html'><img src='../Images/" + item.CarImg + "'   alt=''></a></div><div class='offer_aside'><h2><a href='offers-details.html'> " + item.Vname + "</a></h2><div class='offer_descr'><p>Off-road Vehicle/Pickup Truck, Used vehicle, Automatic transmission, Diesel, 190 kW (258 PS), Fuel consumption combined: 6.8 l/100 km</p></div><div class='offer_data'><div class='offer_price>" + item.Price + "</div><span class='offer_miliage'>55,689 KM</span><span class='offer_regist'>" + item.DOP + "</span></div></div></div></div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
}