using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_CarPostsPages : System.Web.UI.Page
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
        }



        var data = (from t in dc.CarPosts
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
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

        for (int i = 0; i < data.Count; i++)
        {
            str += "<div class='offer_item clearfix'>";
            str += "<div class='offer_image'>";
            str += "<a><img src='../Images/" + data[i].CarImg + "' height ='162px' width ='230px'></a>";
            str += "</div>";
            str += "<div class='offer_aside'>";
            str += "<h2><a href=CustProductList.aspx?Id=" + data[i].Vid + ">" + data[i].Vname + "</a></h2>";
            str += "<div class='offer_descr'>";
            str += "<p>" + data[i].CarDesp + "</p></div>";
            str += "<div class='offer_price'>";
            str += "$" + data[i].Price + "</div>";
            str += "<span class='offer_miliage'>" + data[i].KM + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + data[i].DOP + "</span><br><br>";
            str += "<div class='offer_price'>" + "Doctor Car:-";
            str += data[i].IsDr + "</div>";
            str += "<span class='offer_miliage'>" + "1st Owner:-" + data[i].IsFirstOwner + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + "With Policy:-" + data[i].WithPolicy + "</span>";
            str += "<span class='offer_regist'>" + "Negotiable:-" + data[i].IsNegotiable + "</span>";
            str += "<span class='offer_regist'>" + "Year:-" + data[i].Year + "</span>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }


    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("VehicleTypeProductEdit.aspx");
    //}
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

        for (int i = 0; i < data.Count; i++)
        {
            str += "<div class='offer_item clearfix'>";
            str += "<div class='offer_image'>";
            str += "<a><img src='../Images/" + data[i].CarImg + "' height ='162px' width ='230px'></a>";
            str += "</div>";
            str += "<div class='offer_aside'>";
            str += "<h2><a href=CustProductList.aspx?Id=" + data[i].Vid + ">" + data[i].Vname + "</a></h2>";
            str += "<div class='offer_descr'>";
            str += "<p>" + data[i].CarDesp + "</p></div>";
            str += "<div class='offer_price'>";
            str += "$" + data[i].Price + "</div>";
            str += "<span class='offer_miliage'>" + data[i].KM + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + data[i].DOP + "</span><br><br>";
            str += "<div class='offer_price'>" + "Doctor Car:-";
            str += data[i].IsDr + "</div>";
            str += "<span class='offer_miliage'>" + "1st Owner:-" + data[i].IsFirstOwner + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + "With Policy:-" + data[i].WithPolicy + "</span>";
            str += "<span class='offer_regist'>" + "Negotiable:-" + data[i].IsNegotiable + "</span>";
            str += "<span class='offer_regist'>" + "Year:-" + data[i].Year + "</span>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
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

        for (int i = 0; i < data.Count; i++)
        {
            str += "<div class='offer_item clearfix'>";
            str += "<div class='offer_image'>";
            str += "<a><img src='../Images/" + data[i].CarImg + "' height ='162px' width ='230px'></a>";
            str += "</div>";
            str += "<div class='offer_aside'>";
            str += "<h2><a href=CustProductList.aspx?Id=" + data[i].Vid + ">" + data[i].Vname + "</a></h2>";
            str += "<div class='offer_descr'>";
            str += "<p>" + data[i].CarDesp + "</p></div>";
            str += "<div class='offer_price'>";
            str += "$" + data[i].Price + "</div>";
            str += "<span class='offer_miliage'>" + data[i].KM + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + data[i].DOP + "</span><br><br>";
            str += "<div class='offer_price'>" + "Doctor Car:-";
            str += data[i].IsDr + "</div>";
            str += "<span class='offer_miliage'>" + "1st Owner:-" + data[i].IsFirstOwner + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + "With Policy:-" + data[i].WithPolicy + "</span>";
            str += "<span class='offer_regist'>" + "Negotiable:-" + data[i].IsNegotiable + "</span>";
            str += "<span class='offer_regist'>" + "Year:-" + data[i].Year + "</span>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
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

        for (int i = 0; i < data.Count; i++)
        {
            str += "<div class='offer_item clearfix'>";
            str += "<div class='offer_image'>";
            str += "<a><img src='../Images/" + data[i].CarImg + "' height ='162px' width ='230px'></a>";
            str += "</div>";
            str += "<div class='offer_aside'>";
            str += "<h2><a href=CustProductList.aspx?Id=" + data[i].Vid + ">" + data[i].Vname + "</a></h2>";
            str += "<div class='offer_descr'>";
            str += "<p>" + data[i].CarDesp + "</p></div>";
            str += "<div class='offer_price'>";
            str += "$" + data[i].Price + "</div>";
            str += "<span class='offer_miliage'>" + data[i].KM + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + data[i].DOP + "</span><br><br>";
            str += "<div class='offer_price'>" + "Doctor Car:-";
            str += data[i].IsDr + "</div>";
            str += "<span class='offer_miliage'>" + "1st Owner:-" + data[i].IsFirstOwner + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + "With Policy:-" + data[i].WithPolicy + "</span>";
            str += "<span class='offer_regist'>" + "Negotiable:-" + data[i].IsNegotiable + "</span>";
            str += "<span class='offer_regist'>" + "Year:-" + data[i].Year + "</span>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
    protected void txtRange_TextChanged(object sender, EventArgs e)
    {
        var data = (from t in dc.CarPosts
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    where t.Price.StartsWith(txtRange.Text)
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

        for (int i = 0; i < data.Count; i++)
        {
            str += "<div class='offer_item clearfix'>";
            str += "<div class='offer_image'>";
            str += "<a><img src='../Images/" + data[i].CarImg + "' height ='162px' width ='230px'></a>";
            str += "</div>";
            str += "<div class='offer_aside'>";
            str += "<h2><a href=CustProductList.aspx?Id=" + data[i].Vid + ">" + data[i].Vname + "</a></h2>";
            str += "<div class='offer_descr'>";
            str += "<p>" + data[i].CarDesp + "</p></div>";
            str += "<div class='offer_price'>";
            str += "$" + data[i].Price + "</div>";
            str += "<span class='offer_miliage'>" + data[i].KM + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + data[i].DOP + "</span><br><br>";
            str += "<div class='offer_price'>" + "Doctor Car:-";
            str += data[i].IsDr + "</div>";
            str += "<span class='offer_miliage'>" + "1st Owner:-" + data[i].IsFirstOwner + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + "With Policy:-" + data[i].WithPolicy + "</span>";
            str += "<span class='offer_regist'>" + "Negotiable:-" + data[i].IsNegotiable + "</span>";
            str += "<span class='offer_regist'>" + "Year:-" + data[i].Year + "</span>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
    protected void ddlPRange2_SelectedIndexChanged(object sender, EventArgs e)
    {

                    var data = (from t in dc.CarPosts
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    where   (int.Parse (t.KM)  <= int.Parse (ddlPrange1.SelectedItem.Text)  && (int.Parse (t.KM )) >= int.Parse (ddlPRange2.SelectedItem.Text ))
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

        for (int i = 0; i < data.Count; i++)
        {
            str += "<div class='offer_item clearfix'>";
            str += "<div class='offer_image'>";
            str += "<a><img src='../Images/" + data[i].CarImg + "' height ='162px' width ='230px'></a>";
            str += "</div>";
            str += "<div class='offer_aside'>";
            str += "<h2><a href=CustProductList.aspx?Id=" + data[i].Vid + ">" + data[i].Vname + "</a></h2>";
            str += "<div class='offer_descr'>";
            str += "<p>" + data[i].CarDesp + "</p></div>";
            str += "<div class='offer_price'>";
            str += "$" + data[i].Price + "</div>";
            str += "<span class='offer_miliage'>" + data[i].KM + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + data[i].DOP + "</span><br><br>";
            str += "<div class='offer_price'>" + "Doctor Car:-";
            str += data[i].IsDr + "</div>";
            str += "<span class='offer_miliage'>" + "1st Owner:-" + data[i].IsFirstOwner + "</span>&nbsp;&nbsp;&nbsp;&nbsp;";
            str += "<span class='offer_regist'>" + "With Policy:-" + data[i].WithPolicy + "</span>";
            str += "<span class='offer_regist'>" + "Negotiable:-" + data[i].IsNegotiable + "</span>";
            str += "<span class='offer_regist'>" + "Year:-" + data[i].Year + "</span>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
            str += "</div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
}
